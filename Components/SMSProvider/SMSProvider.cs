using Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Provider
{
    public class SMSProvider
    {
        public delegate void SMSRecievedDelegate(SimCorpMessage message);
        private delegate string FormatDelegate(string text);
        private FormatDelegate Formatter = new FormatDelegate(StartWithTimeFormat);
        public delegate void MessageFormatDelegate(MessageFormat messageFormat);
        public event SMSRecievedDelegate SMSReceived;
        public event MessageFormatDelegate SetMessageFormatEvent;
        private readonly IOutput _output;
        public List<SimCorpMessage> MessagesCach = new List<SimCorpMessage>();
        public SMSProvider(IOutput output)
        {
            _output = output;
            SMSReceived += OnSMSReceived;
            SetMessageFormatEvent += OnSetMessageFormat;
        }
        private void OnSMSReceived(SimCorpMessage message)
        {
            MessagesCach.Add(message);
            if (Formatter != null)
            {
                _output.WriteLine(Formatter($"{message}{Environment.NewLine}"));
                return;
            }
            _output.WriteLine(message.ToString());
        }
        private void OnSetMessageFormat(MessageFormat messageFormat)
        {
            switch (messageFormat)
            {
                case MessageFormat.StartWithTime:
                    Formatter = new FormatDelegate(StartWithTimeFormat);
                    break;
                case MessageFormat.EndWithTime:
                    Formatter = new FormatDelegate(EndWithTimeFormat);
                    break;
                case MessageFormat.Uppercase:
                    Formatter = new FormatDelegate(UppercaseFormat);
                    break;
                case MessageFormat.Lowercase:
                    Formatter = new FormatDelegate(LowercaseFormat);
                    break;
                default:
                    Formatter = new FormatDelegate(NoneFormat);
                    break;
            }
        }
        private static string StartWithTimeFormat(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }
        private static string EndWithTimeFormat(string message)
        {
            return $"{message} [{DateTime.Now}]";
        }
        private static string UppercaseFormat(string message)
        {
            return $"{message.ToUpper()}";
        }
        private static string LowercaseFormat(string message)
        {
            return $"{message.ToLower()}";
        }
        private static string NoneFormat(string message)
        {
            return message;
        }
        public void SendMessage(SimCorpMessage message)
        {
            SMSReceived(message);
        }
        public void SetMessageFormat(MessageFormat messageFormat)
        {
            SetMessageFormatEvent(messageFormat);
        }
    }
}
