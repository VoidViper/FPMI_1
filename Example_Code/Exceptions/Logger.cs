using System;
using System.IO;

namespace Exceptions
{
    class Logger
    {
        public static void WriteToLog (string logEntry)
        {
            using (StreamWriter myWriter = new StreamWriter("calculator.log", true))
            {
                myWriter.WriteLine(logEntry);
            }
        }
    }
}
