using Components.Interfaces;
using System;

namespace Components.Speakers
{
    public class PhoneSpeaker : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
