using Components;
using Components.Phones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class MessageFormatting : Form
    {
        private readonly SimCorpMobile _simCorpMobile;
        public MessageFormatting()
        {
            InitializeComponent();
            _simCorpMobile = new SimCorpMobile(MessageBox1);
            UpdateBatteryVolumeTimer.Start();
            _simCorpMobile.SMSProvider.UpdateUsersEvent += CheckUser;
        }
        private void SearchByCriteria() 
        {
            List<SimCorpMessage> res = _simCorpMobile.SMSProvider.MessagesCach.ToList();
            if (SearchByUserComboBox.SelectedItem != null) 
            {
                res = res.Where(x => x.User == SearchByUserComboBox.SelectedItem.ToString()).ToList();
            }
            if (!string.IsNullOrWhiteSpace(SearchByText.Text)) 
            {
                res = res.Where(x => x.Text == SearchByText.Text).ToList();
            }
            res = res.Where(x => x.ReceivingTime.Date >= FromDateTimePicker.Value.Date && x.ReceivingTime.Date <= ToDateTimePicker.Value.Date).ToList();
            ShowMessages(res);
        }
        private void CheckUser(List<SimCorpMessage> messages)
        {
            var uniqueUsers = messages.Select(x => x.User).Distinct().ToList();
            if (SearchByUserComboBox.InvokeRequired) 
            {
                SearchByUserComboBox.Invoke(new MethodInvoker(delegate 
                {
                    if (SearchByUserComboBox.Items.Count != uniqueUsers.Count)
                    {
                        SearchByUserComboBox.Items.Clear();
                        SearchByUserComboBox.Items.AddRange(uniqueUsers.ToArray());
                    };
                }));
            }
            
        }
        private void ShowMessages(List<SimCorpMessage> messages) 
        {
            MessagesListView.Clear();
            var formatedMessages = _simCorpMobile.SMSProvider.GetFormatedMessages(messages);
            foreach (var message in formatedMessages)
            {
                ListViewItem newItem = new ListViewItem(message);
                MessagesListView.Items.Add(newItem);
            }
        }
        private void MessageFormatting_Load(object sender, EventArgs e)
        {
            FormattingComboBox.SelectedItem = FormattingComboBox.Items[0];
        }

        private void FormattingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FormattingComboBox.SelectedItem.ToString()) 
            {
                case "None":
                    _simCorpMobile.SMSProvider.SetMessageFormat(MessageFormat.None);
                    break;
                case "Start with date":
                    _simCorpMobile.SMSProvider.SetMessageFormat(MessageFormat.StartWithTime);
                    break;
                case "End with date":
                    _simCorpMobile.SMSProvider.SetMessageFormat(MessageFormat.EndWithTime);
                    break;
                case "Uppercase":
                    _simCorpMobile.SMSProvider.SetMessageFormat(MessageFormat.Uppercase);
                    break;
                case "Lowercase":
                    _simCorpMobile.SMSProvider.SetMessageFormat(MessageFormat.Lowercase);
                    break;
            }
        }
        private void MessageFormatting_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateBatteryVolumeTimer.Stop();
            _simCorpMobile.Battery.SwitchOFF();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            if (_simCorpMobile.SMSProvider.IsStoped)
            {
                _simCorpMobile.SMSProvider.Start();
            }
            else 
            {
                _simCorpMobile.SMSProvider.Stop();
            }
        }
        private void SearchByUserComboBox_Leave(object sender, EventArgs e)
        {
            SearchByCriteria();
        }

        private void SearchByText_Leave(object sender, EventArgs e)
        {
            SearchByCriteria();
        }

        private void FromDateTimePicker_Leave(object sender, EventArgs e)
        {
            SearchByCriteria();
        }

        private void ToDateTimePicker_Leave(object sender, EventArgs e)
        {
            SearchByCriteria();
        }

        private void UpdateBatteryVolumeTimer_Tick(object sender, EventArgs e)
        {
            BatteryVolumeProgressBar.Value = _simCorpMobile.Battery.Volume;
        }

        private void ChargingButton_Click(object sender, EventArgs e)
        {
            if (!_simCorpMobile.Battery.IsCharging)
            {
                _simCorpMobile.Battery.StartCharging();
            }
            else 
            {
                _simCorpMobile.Battery.StartDischarging();
            }
        }

        private void CallsButton_Click(object sender, EventArgs e)
        {
            CallForm callForm = new CallForm();
            callForm.UpdateCalls(_simCorpMobile.CallProvider.callCach);
            callForm.Show();
        }

        private void GenerateCallsButton_Click(object sender, EventArgs e)
        {
            if (_simCorpMobile.CallProvider.IsStoped)
            {
                _simCorpMobile.CallProvider.Start();
            }
            else
            {
                _simCorpMobile.CallProvider.Stop();
            }
        }
    }
}
