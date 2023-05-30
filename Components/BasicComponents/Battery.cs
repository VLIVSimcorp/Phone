using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Components.BasicComponents
{
    public class Battery
    {
        public static int Charge = 100;
        Thread DischargeThread = new Thread(Discharge);
        static void Discharge()
        {
            Charge-=1;
            Thread.Sleep(3000);
        }
        public void StartBattery() 
        {
            DischargeThread.Start();
        } 
    }
}