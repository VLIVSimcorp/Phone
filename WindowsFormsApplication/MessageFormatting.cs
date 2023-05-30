using Components;
using Components.Phones;
using Components.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void CheckUser()
        {
            var uniqueUsers = _simCorpMobile.SMSProvider.MessagesCach.Select(x => x.User).Distinct().ToList();
            if (SearchByUserComboBox.Items.Count != uniqueUsers.Count) 
            {
                SearchByUserComboBox.Items.Clear();
                SearchByUserComboBox.Items.AddRange(uniqueUsers.ToArray());
            }
        }
        private void ShowMessages(List<SimCorpMessage> messages) 
        {
            MessagesListView.Clear();
            foreach (SimCorpMessage message in messages)
            {
                MessagesListView.Items.Add(new ListViewItem(new[] {message.User, message.Text}));
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
    }
}
