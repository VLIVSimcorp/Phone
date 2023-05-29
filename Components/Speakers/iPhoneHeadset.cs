﻿using Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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