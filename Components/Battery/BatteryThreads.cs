using System.Threading;

namespace Components.Battery
{
    public class BatteryThreads : BatteryBase
    {
        private static int _volume = 100;
        public override int Volume => _volume;
        Thread DischargeThread = new Thread(Discharge);
        Thread ChargeThread = new Thread(Charge);
        private static object locker = new object();
        private static bool _isCharging = false;
        public override bool IsCharging => _isCharging;
        public BatteryThreads()
        {
            DischargeThread.Start();
            ChargeThread.Start();
        }
        public override void StartCharging()
        {
            _isCharging = true;
        }
        public override void StartDischarging() 
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
                        if (_volume < 100)
                        {
                            _volume += 1;
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
                        if (_volume > 0)
                        {
                            _volume -= 1;
                            Thread.Sleep(3000);
                        }
                    }
                }
            }
        }
        public override void SwitchOFF() 
        {
            DischargeThread.Abort();
            ChargeThread.Abort();
        }
    }
}