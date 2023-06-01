using Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Components.Provider
{
    public class SMSProvider
    {
        public delegate void SMSRecievedDelegate(SimCorpMessage message);
        public delegate void UpdateUsersDelegate(List<SimCorpMessage> messages);
        public event UpdateUsersDelegate UpdateUsersEvent;
        private delegate string FormatDelegate(string text);
        private FormatDelegate Formatter = new FormatDelegate(StartWithTimeFormat);
        public delegate void MessageFormatDelegate(MessageFormat messageFormat);
        public static event SMSRecievedDelegate SMSReceived;
        public event MessageFormatDelegate SetMessageFormatEvent;
        private readonly IOutput _output;
        public List<SimCorpMessage> MessagesCach = new List<SimCorpMessage>();
        private static List<string> Users = new List<string> { "User 1", "User 2", "User 3", "User 4" };
        Thread MessageGeneratorThread = new Thread(GenerateMessageWithThread);
        public bool IsStoped => _isStoped;
        public static bool _isStoped = true;
        public SMSProvider(IOutput output, bool withThread)
        {
            _output = output;
            SMSReceived += OnSMSReceived;
            SetMessageFormatEvent += OnSetMessageFormat;
            if (withThread)
            {
                MessageGeneratorThread = new Thread(GenerateMessageWithThread);
            }
            else
            {
                GenerateMessageWithTask();
            }
            MessageGeneratorThread.Start();
        }
        public List<string> GetFormatedMessages(List<SimCorpMessage> messages) 
        {
            List<string> formatedMessages = new List<string>();
            foreach (var message in messages) 
            {
                if (Formatter != null)
                {
                    formatedMessages.Add(Formatter($" {message}"));
                }
                else 
                {
                    formatedMessages.Add(message.ToString());
                }
            }
            return formatedMessages;
        }
        public void Start() 
        {
            _isStoped = false;
        }
        public void Stop()
        {
            _isStoped = true;
        }
        private void GenerateMessageWithTask() 
        {
            Task.Run(async() => 
            {
                while (true)
                {
                    if (!_isStoped)
                    {
                        SendMessage(new SimCorpMessage(Users[new Random().Next(0, Users.Count())], "Message"));
                        await Task.Delay(1000);
                    }
                }
            });
        }
        static void GenerateMessageWithThread()
        {
            while(true)
            {
                if (!_isStoped)
                {
                    SendMessage(new SimCorpMessage(Users[new Random().Next(0, Users.Count() - 1)], "Message"));
                    Thread.Sleep(1000);
                }
            }
        }
        private void OnSMSReceived(SimCorpMessage message)
        {
            MessagesCach.Add(message);
            UpdateUsersEvent(MessagesCach);
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
        public static void SendMessage(SimCorpMessage message)
        {
            SMSReceived(message);
        }
        public void SetMessageFormat(MessageFormat messageFormat)
        {
            SetMessageFormatEvent(messageFormat);
        }
    }
}
