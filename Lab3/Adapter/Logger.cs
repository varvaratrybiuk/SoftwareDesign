using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Logger
    {
        public void Log()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Warn()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
