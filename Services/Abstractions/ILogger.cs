using Module2_Ex5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex5.Services.Abstractions
{
    public interface ILogger
    {
        void Log(string message, LogType type);
    }
}
