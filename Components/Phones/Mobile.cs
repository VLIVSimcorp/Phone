using Components.BasicComponents;
using Components.Battery;
using Components.CallPROVIDER;
using Components.Interfaces;
using Components.Provider;

namespace Components.Phones
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }
        public abstract IPlayback PlaybackComponent { get; }
        public abstract IOutput Output { get; }
        public abstract SMSProvider SMSProvider { get; }
        public abstract BatteryBase Battery { get; }
        public abstract CallProvider CallProvider { get; }
        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }
        public void Play(object data)
        {
            PlaybackComponent.Play(data);
        }
    }

}
