using System;

namespace Components.CallPROVIDER
{
    public class Call : IComparable
    {
        public Contact Contact;
        public DateTime DateTime;
        public CallDirection CallDirection;

        public int CompareTo(object obj)
        {
            if (obj is Call call)
            {
                if (DateTime == call.DateTime)
                    return 0;
                return DateTime < call.DateTime ? 1 : -1;
            }
            throw new ArgumentException("Incorrect parameter type");
        }
    }
}
