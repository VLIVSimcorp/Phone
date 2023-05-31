using Components.BasicComponents;
using Components.Interfaces;
using Components.Output;
using Components.Provider;
using Components.Screens.ColorfulScreens;
using Components.Speakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components.Phones
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen => _vOLEDScreen;

        public override IPlayback PlaybackComponent => _playbackComponent;

        public override IOutput Output => _output;

        public override SMSProvider SMSProvider => _SMSProvider;

        public override Battery Battery => _battery;
        private readonly Battery _battery;
        private readonly OLEDScreen _vOLEDScreen = new OLEDScreen();
        private IPlayback _playbackComponent = new PhoneSpeaker();
        private readonly IOutput _output;
        private readonly SMSProvider _SMSProvider;
        public SimCorpMobile(TextBox textBoxOutput)
        {
            _output = new TextBoxOutput(textBoxOutput);
            _SMSProvider = new SMSProvider(_output);
            _battery = new Battery();
        }
        public void SetPlaybackComponent(IPlayback playbackComponent)
        {
            _playbackComponent = playbackComponent;
            _output.WriteLine($"    Set {nameof(playbackComponent)} as playback to {nameof(SimCorpMobile)}...");
        }
       
    }

}
