using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    internal class Run
    {
        private static readonly Logger Logger = Logger.LoggerObj;
        private readonly Actions _actions = new Actions(Logger);
        private readonly Random _random = new Random(); 

        public void Start()
        {
            for(int i = 0; i <= 100; i++)
            {
                int randoNumber = _random.Next(1, 4);
                Result result = randoNumber switch
                {
                    1 => _actions.CalltInfo(),
                    2 => _actions.CallWarning(),
                    3 => _actions.CallError(),
                    _ => throw new InvalidOperationException("Invalid random number"),
                };
                if (!result.Status)
                {
                    Logger.Log(LogType.Error, $"Action failed by a reason: {result.Error}");
                }
            }
            string loggerReport = Logger.GetMessage();
            File.WriteAllText("log.txt", loggerReport);
        }
    }
}
