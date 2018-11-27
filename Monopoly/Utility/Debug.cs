using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Utility
{
    enum Severity
    {
        Info, Warn, Error, Fatal
    }

    class Debug
    {
        public static Severity logLevel = Severity.Warn;
        public static void Print(Severity severity, string message)
        {
            if (severity > logLevel)
            {
                Console.WriteLine("[" + System.DateTime.Now + "] [" + severity.ToString() + "] " + message);
            }
        }
    }
}
