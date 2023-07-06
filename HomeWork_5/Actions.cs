using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    internal class Actions
    {
        private readonly Logger _logger;
        public Actions(Logger logger)
        {
            _logger = logger;
        }

        public Result CalltInfo()
        {
            _logger.Log(LogType.Info, $"Start method: {nameof(CalltInfo)}");
            return new Result { Status = true };
        }
        public Result CallWarning()
        {
            _logger.Log(LogType.Warning, $"Skipped logick in method: {nameof(CallWarning)}");
            return new Result { Status = true };
        }
        public Result CallError()
        {
            return new Result { Status = false, Error = "I broke a logic" };
        }
    }
}
