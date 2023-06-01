using Components.Interfaces;
using System;

namespace Components.Speakers
{
    public class UnofficialHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(UnofficialHeadset)} sound");
        }
    }
}
