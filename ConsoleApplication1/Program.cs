using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryTest();
            Console.ReadKey();
        }

        public static DateTime LastDayOfPrdviousMonth(DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day).AddDays(-1);
        }

        public static void DateTimeTest()
        {
            Console.WriteLine(130/60);
            DateTimeTest td = new ConsoleApplication1.DateTimeTest();
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.AddSeconds(120).ToString());
        }

        public static void DateTimeTest1()
        {
            DateTime dt = DateTime.Now;
            Thread.Sleep(5000);
            Console.WriteLine((DateTime.Now-dt).ToString());
        }

        public static void DateTimeTest3()
        {
            //DateTime dtNow = Convert.ToDateTime("2017-4-13");
            //DateTime dtNow = DateTime.Now;
            //for (int i=0; i<12;i++)
            //{
            //    DateTime dtP = LastDayOfPrdviousMonth(dtNow);
            //    Console.WriteLine(dtP.ToShortDateString());
            //    //==================================
            //    //==================================
            //    //==================================

            //    if (dtP.DayOfWeek == DayOfWeek.Saturday)
            //    {
            //        dtP = dtP.AddDays(-2);
            //    }
            //    else if (dtP.DayOfWeek == DayOfWeek.Sunday)
            //    {
            //        dtP = dtP.AddDays(-3);
            //    }
            //    else if (dtP.DayOfWeek == DayOfWeek.Monday)
            //    {
            //        dtP = dtP.AddDays(-4);
            //    }
            //    else
            //    {
            //        dtP = dtP.AddDays(-1);
            //    }

            //    Console.WriteLine(dtP.ToShortDateString() + "[" + dtP.DayOfWeek.ToString() + "]"+ Convert.ToInt32( (dtNow- dtP).TotalDays));
            //    dtNow=dtNow.AddMonths(1);


            //}
        }

        public static void DictionaryTest()
        {
            Dictionary<int, int> dicTest = new Dictionary<int, int>();
            dicTest.Add(4, 40);
            dicTest.Add(2, 20);
            dicTest.Add(3, 30);
            Console.WriteLine(dicTest.First().Value);
        }

    }

    public class DateTimeTest
    {
        public DateTime dt { get; set; }
    }


   
    [Author("Oscar",version =1.1)]
    class OldClass
    {
        [method: Obsolete("该方法已经过时")]
        public void OldMethod()
        {
            Console.WriteLine("过时的方法！");
        }
    }


    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple =true)]
    public class Author : System.Attribute
    {
        private string name;
        public double version;

        public Author(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }
}
