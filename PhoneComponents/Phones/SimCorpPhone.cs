using Components.BasicComponents;
using Components.Interfaces;
using Components.Output;
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

        private readonly OLEDScreen _vOLEDScreen = new OLEDScreen();
        private IPlayback _playbackComponent = new PhoneSpeaker();
        private readonly IOutput _output;
        public SimCorpMobile(TextBox textBoxOutput)
        {
            _output = new TextBoxOutput(textBoxOutput);
        }
        public void SetPlaybackComponent(IPlayback playbackComponent)
        {
            _playbackComponent = playbackComponent;
        }

    }

}
