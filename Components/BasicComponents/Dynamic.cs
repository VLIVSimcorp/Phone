using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.BasicComponents
{
    public class Dynamic
    {
        public double power;
        public int channels;
        public Dynamic(double dynamicPower, int dynamicChannels)
        {
            power = dynamicPower;
            channels = dynamicChannels;
        }
    }
}
