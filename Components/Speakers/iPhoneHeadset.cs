using Components.Interfaces;
using System;

namespace Components.Speakers
{
    public class iPhoneHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
    }
}
