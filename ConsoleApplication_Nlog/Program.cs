using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Nlog
{
    class Program
    {
        static void Main(string[] args)
        {
            HistoryLog.SentMail("1");

            HistoryLog.SendMail2("2");
            HistoryLog.SentMail("1");
            HistoryLog.SendMail2("2");
            Console.ReadKey();
        }
    }
}
