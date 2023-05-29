using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.BasicComponents
{
    public class Microphone
    {
        public double sensitivity;
        public (int minFrequency, int maxFrequency) frequencyRange;
        public Microphone()
        {

        }
    }
}
