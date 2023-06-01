using System.Threading.Tasks;

namespace Components.Battery
{
    public class BatteryTasks : BatteryBase
    {
        private static int _volume = 100;
        public override int Volume => _volume;
        private static bool _isCharging = false;
        public override bool IsCharging => _isCharging;
        Task ChargingTask = new Task(async () =>
        {
            while (true)
            {
                if (_isCharging)
                {

                    if (_volume < 100)
                    {
                         _volume += 1;
                         await Task.Delay(3000);
                    }
                }
            }
        });
        Task DischargingTask = new Task(async () =>
        {
            while (true)
            {
                if (!_isCharging)
                {

                    if (_volume > 0)
                    {
                        _volume -= 1;
                        await Task.Delay(3000);
                    }
                }
            }
        });
        public BatteryTasks() 
        {
            ChargingTask.Start();
            DischargingTask.Start();
        }
        public override void StartCharging()
        {
            _isCharging = true;
        }

        public override void StartDischarging()
        {
            _isCharging = false;
        }

        public override void SwitchOFF()
        {
            ChargingTask.Dispose();
            DischargingTask.Dispose();
        }
    }
}
