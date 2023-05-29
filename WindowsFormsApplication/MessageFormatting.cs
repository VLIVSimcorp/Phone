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
            _simCorpMobile = new SimCorpMobile(MessageBox);
        }
        private void ShowMessages(List<SimCorpMessage> messages) 
        {
            MessagesListView.Clear();
            foreach (SimCorpMessage message in messages)
            {
                MessagesListView.Items.Add(new ListViewItem(new[] { message.User, message.Text}));
            }
        }
        private void MessageFormatting_Load(object sender, EventArgs e)
        {
            FormattingComboBox.SelectedItem = FormattingComboBox.Items[0];
            MessageTimer.Start();
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

        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            _simCorpMobile.SMSProvider.SendMessage(new SimCorpMessage("User 1", "Text 1"));
        }

        private void MessageFormatting_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageTimer.Stop();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UserTextBox.Text) && !string.IsNullOrWhiteSpace(MessageTextBox.Text)) 
            {
                _simCorpMobile.SMSProvider.SendMessage(new SimCorpMessage(UserTextBox.Text, MessageTextBox.Text));
                return;
            }
            MessageBox.Show("Fields must be filled", "No user or message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
