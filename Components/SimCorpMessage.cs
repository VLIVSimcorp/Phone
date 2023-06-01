using System;

namespace Components
{
    public class SimCorpMessage
    {   
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; set; }
        public SimCorpMessage(string user, string text) 
        {
            User = user;
            Text = text;
            ReceivingTime = DateTime.Now;
        }
        public override string ToString() 
        {
            return $"{User}: {Text}";
        }
    }
}
