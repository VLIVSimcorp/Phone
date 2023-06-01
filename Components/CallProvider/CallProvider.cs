using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.CallPROVIDER
{
    public class CallProvider
    {
        public Dictionary<string, (List<Call>, List<Call>)> callCach = new Dictionary<string, (List<Call>, List<Call>)>();
        public bool IsStoped => _isStoped;
        public static bool _isStoped = false;
        private static List<string> Users = new List<string> { "User 1", "User 2", "User 3", "User 4" };
        public CallProvider()
        {
            GenerateCalls();
        }
        public void Start()
        {
            _isStoped = false;
        }
        public void Stop()
        {
            _isStoped = true;
        }
        private void AddCall(Call newCall)
        {
            if (!callCach.ContainsKey(newCall.Contact.Name))
                callCach.Add(newCall.Contact.Name, (new List<Call>(), new List<Call>()));
            if (newCall.CallDirection == CallDirection.Incoming)
            {
                callCach[newCall.Contact.Name].Item1.Add(newCall);
                callCach[newCall.Contact.Name].Item1.Sort();
            }
            else
            {
                callCach[newCall.Contact.Name].Item2.Add(newCall);
                callCach[newCall.Contact.Name].Item2.Sort();
            }
        }
        private void GenerateCalls()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    if (!_isStoped)
                    {
                        var newCall = new Call()
                        {
                            Contact = new Contact() { Name = Users[new Random().Next(0, Users.Count())], PhoneNumber = RandomNumber() },
                            DateTime = DateTime.Now,
                            CallDirection = RandomCallDirection()
                        };
                        AddCall(newCall);
                        await Task.Delay(1000);
                    }
                }
            });
        }
        private string RandomNumber()
        {
            var random = new Random();
            string number = string.Empty;
            for (int i = 0; i < 10; i++)
                number = String.Concat(number, random.Next(10).ToString());
            return number;
        }
        private CallDirection RandomCallDirection() 
        {
            Array values = Enum.GetValues(typeof(CallDirection));
            Random random = new Random();
            return (CallDirection)values.GetValue(random.Next(values.Length));
        }

    }
}
