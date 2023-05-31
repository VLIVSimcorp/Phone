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
        /*public delegate int BateryVolumeDelegate(int volume);
        public static event BateryVolumeDelegate SendBatteryVolumeEvent;*/
        private static int Volume = 100;
        Thread DischargeThread = new Thread(Discharge);
        Thread ChargeThread = new Thread(Charge);
        private static object locker = new object();
        private static bool _isCharging = false;
        public bool IsCharging => _isCharging;
        public Battery()
        {
            DischargeThread.Start();
            ChargeThread.Start();
        }
        public int GetBatteryVolume()
        {
            return Volume;
        }
        public void StartCharging()
        {
            _isCharging = true;
        }
        public void StopCharging() 
        {
            _isCharging = false;
        }
        static void Charge() 
        {
            while (true)
            {
                if (_isCharging)
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
                if (!_isCharging)
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