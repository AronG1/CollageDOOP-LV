using System;
using System.Collections.Generic;
using System.Text;

namespace LV_6
{
    enum MessageType
    {
        INFO = 1, // 1
        WARNING = 2, // 10
        ERROR = 4, //100
        ALL = 7 //111
    }
    abstract class AbstractLogger
    {
        protected MessageType messageTypeHandling;
        protected AbstractLogger nextLogger;
        public AbstractLogger(MessageType messageType)
        {
            this.messageTypeHandling = messageType;
        }
        public void SetNextLogger(AbstractLogger logger)
        {
            this.nextLogger = logger;
        }
        public void Log(string message, MessageType type)
        {
            if ((type & this.messageTypeHandling) != 0)
            {
                this.WriteMessage(message, type);
            }
            if (this.nextLogger != null)
            {
                this.nextLogger.Log(message, type);
            }
        }
        protected abstract void WriteMessage(string message, MessageType type);
    }
    class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(MessageType messageType) : base(messageType) { }
        protected override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(type + ": " + DateTime.Now);
            Console.WriteLine(new string('=', message.Length));
            Console.WriteLine(message);
            Console.WriteLine(new string('=', message.Length) + "\n");
        }
    }
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            //implementation missing!
        }
    }
    abstract class StringChecker
    {
        private StringChecker next;
        public void SetNext(StringChecker next)
        {
            this.next = next;
        }
        public bool Check(string stringToCheck)
        {
            bool result = this.PerformCheck(stringToCheck);
            if (this.next != null && result == true)
            {
                return this.next.Check(stringToCheck);
            }
            return result;
        }
        protected abstract bool PerformCheck(string stringToCheck);
    }

}
