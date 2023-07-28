using Module2_Ex5.Models;
using Module2_Ex5.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex5.Services
{
    public class Logger : ILogger
    {
        private readonly IFileService _fileService;

        public Logger(IFileService fileService)
        {
            _fileService = fileService;
        }

        public void Log(string message, LogType type)
        {
            var logMessage = $"{DateTime.Now}: {type}: {message}";
            Console.WriteLine(logMessage);
            _fileService.WriteToFile(logMessage);
        }
    }
}
