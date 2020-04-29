using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_2
{
    class ConsoleLogger : ILogger
    {
        void ILogger.Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
