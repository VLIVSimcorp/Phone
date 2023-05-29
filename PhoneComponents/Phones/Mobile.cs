using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components;
using Components.BasicComponents;
using Components.Interfaces;

namespace Components.Phones
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }
        public abstract IPlayback PlaybackComponent { get; }
        public abstract IOutput Output { get; }

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
