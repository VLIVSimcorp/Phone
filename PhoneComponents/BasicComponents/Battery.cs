using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.BasicComponents
{
    public class Battery
    {
        public int size;
        public int volume;
        public Battery(int batterySize, int batteryVolume)
        {
            size = batterySize;
            volume = batteryVolume;
        }
    }
}