using Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
