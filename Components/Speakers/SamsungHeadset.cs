using Components.Interfaces;
using System;

namespace Components.Speakers
{
    public class SamsungHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}
