using Module2_Ex5.Exceptions;
using Module2_Ex5.Models;
using Module2_Ex5.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex5
{
    public class Actions
    {
        private readonly ILogger _logger;

        public Actions(ILogger logger)
        {
            _logger = logger;
        }

        public void Method1()
        {
            _logger.Log($"Start method: {nameof(Method1)}", LogType.Info);
        }

        public void Method2()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public void Method3()
        {
            throw new Exception("I broke a logic");
        }
    }
}
