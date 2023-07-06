using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HomeWork_5
{
    public enum LogType
    {
        Info,
        Warning,
        Error
    }
    public class Logger
    {
        private static readonly Logger logger = new();
        private Logger()
        { 
            Result = new StringBuilder();
        }

        public static Logger LoggerObj
        {
            get
            {
                return logger;
            }
        }
        private StringBuilder Result { get; set; }
        public void Log(LogType logType, string message)
        {
            string log = $"{DateTime.Now}: {logType}: {message}";
            Result.AppendLine(log);
        }
        public string GetMessage()
        {
            return Result.ToString();
        }
    }
}
