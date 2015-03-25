using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo
{
    public class LoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
