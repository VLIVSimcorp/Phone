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
        public static int Volume = 100;
        Thread DischargeThread = new Thread(Discharge);
        Thread ChargeThread = new Thread(Charge);
        private static object locker = new object();
        private static bool IsCharging = false;
        public Battery()
        {
            DischargeThread.Start();
            ChargeThread.Start();
        }
        public void StartCharging()
        {
            IsCharging = true;
        }
        public void StopCharging() 
        {
            IsCharging = false;
        }
        static void Charge() 
        {
            while (true)
            {
                if (IsCharging)
                {
                    lock (locker)
                    {
                        if (Volume < 100)
                        {
                            Volume += 1;
                            Thread.Sleep(3000);
                        }
                    }
                }
            }
        }
        static void Discharge()
        {
            while (true)
            {
                if (!IsCharging)
                {
                    lock (locker)
                    {
                        if (Volume > 0)
                        {
                            Volume -= 1;
                            Thread.Sleep(3000);
                        }
                    }
                }
            }
        }
        public void SwitchOFF() 
        {
            DischargeThread.Abort();
            ChargeThread.Abort();
        }
    }
}