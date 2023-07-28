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
    public class App
    {
        private readonly ILogger _logger;
        private readonly Actions _actions;
        private readonly Random _random;

        public App(ILogger logger, Actions actions)
        {
            _logger = logger;
            _actions = actions;
            _random = new Random();
        }

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int actionNumber = _random.Next(1, 4);

                    switch (actionNumber)
                    {
                        case 1:
                            _actions.Method1();
                            break;
                        case 2:
                            _actions.Method2();
                            break;
                        case 3:
                            _actions.Method3();
                            break;
                    }
                }
                catch (BusinessException ex)
                {
                    _logger.Log($"Action got this custom Exception: {ex.Message}", LogType.Warning);
                }
                catch (Exception ex)
                {
                    _logger.Log($"Action failed by reason: {ex.ToString()}", LogType.Error);
                }
            }
        }
    }
}
