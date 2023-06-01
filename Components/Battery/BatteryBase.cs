namespace Components.Battery
{
    public abstract class BatteryBase
    {
        public abstract int Volume { get; }
        public abstract bool IsCharging { get; }

        public abstract void StartCharging();

        public abstract void StartDischarging();
        public abstract void SwitchOFF();
        
    }
}
