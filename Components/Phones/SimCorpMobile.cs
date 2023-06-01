using Components.BasicComponents;
using Components.Battery;
using Components.CallPROVIDER;
using Components.Interfaces;
using Components.Output;
using Components.Provider;
using Components.Screens.ColorfulScreens;
using Components.Speakers;
using System.Windows.Forms;

namespace Components.Phones
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen => _vOLEDScreen;

        public override IPlayback PlaybackComponent => _playbackComponent;

        public override IOutput Output => _output;

        public override SMSProvider SMSProvider => _SMSProvider;

        public override BatteryBase Battery => _battery;

        public override CallProvider CallProvider => _callProvider;

        private readonly CallProvider _callProvider;
        private readonly BatteryBase _battery;
        private readonly OLEDScreen _vOLEDScreen;
        private IPlayback _playbackComponent;
        private readonly IOutput _output;
        private readonly SMSProvider _SMSProvider;
        public SimCorpMobile(TextBox textBoxOutput)
        {
            _output = new TextBoxOutput(textBoxOutput);
            _SMSProvider = new SMSProvider(_output, false);
            _battery = new BatteryTasks();
            _callProvider = new CallProvider();
            _vOLEDScreen = new OLEDScreen();
            _playbackComponent = new PhoneSpeaker();
        }
        public void SetPlaybackComponent(IPlayback playbackComponent)
        {
            _playbackComponent = playbackComponent;
            _output.WriteLine($"    Set {nameof(playbackComponent)} as playback to {nameof(SimCorpMobile)}...");
        }
       
    }

}
