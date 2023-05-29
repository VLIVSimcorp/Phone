using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components.Phones;
using Components.Speakers;

namespace WindowsFormsApplication
{
    public partial class Main : Form
    {
        private readonly SimCorpMobile _simCorpMobile;
        public Main()
        {
            InitializeComponent();
            _simCorpMobile = new SimCorpMobile(phoneTextBox);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ApplyPlaybackButton_Click(object sender, EventArgs e)
        {
            if (iPhoneHeadsetRadioButton.Checked == true)
                _simCorpMobile.SetPlaybackComponent(new iPhoneHeadset());
            if (PhoneSpeakerRadioButton.Checked == true)
                _simCorpMobile.SetPlaybackComponent(new PhoneSpeaker());
            if (SamsungHeadsetRadioButton.Checked == true)
                _simCorpMobile.SetPlaybackComponent(new SamsungHeadset());
            if (UnofficialHeadsetRadioButton.Checked == true)
                _simCorpMobile.SetPlaybackComponent(new UnofficialHeadset());
        }
    }
}
