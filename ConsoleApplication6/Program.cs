using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public delegate void GreetingDelegate(string name);

    public class GreetingManager
    {
        //在GreetingManager类的内部声明delegate1变量
        public GreetingDelegate delegate1;
        public event GreetingDelegate MakeGreet;
        public void GreetPeople(string name)
        {
            MakeGreet?.Invoke(name);
        }
    }
    public class Program
    {
        

        static void Main(string[] args)
        {
            //GreetingDelegate delegate1;
            //delegate1 = EnglishGreeting; // 先给委托类型的变量赋值
            //delegate1 += ChineseGreeting;   // 给此委托变量再绑定一个方法

            //// 将先后调用 EnglishGreeting 与 ChineseGreeting 方法
            //delegate1.Invoke("Jimmy Zhang");

            GreetingManager gm = new GreetingManager();
            //gm.MakeGreet += EnglishGreeting;
            //gm.MakeGreet += ChineseGreeting;

            //gm.delegate1 = EnglishGreeting;
            //gm.delegate1 += ChineseGreeting;
            //gm.delegate1 = EnglishGreeting;
            //gm.delegate1.Invoke("大傻叉");
            gm.GreetPeople("Jimmy Zhang");      //注意，这次不需要再传递 delegate1变量
            Console.ReadKey();
        }

        public void GreetPeople(string name)
        {
            // 做某些额外的事情，比如初始化之类，此处略
            EnglishGreeting(name);
        }
        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        public static void   ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }

        public enum Language
        {
            English, Chinese
        }

        public void GreetPeople(string name, Language lang)
        {
            //做某些额外的事情，比如初始化之类，此处略
            switch (lang)
            {
                case Language.English:
                    EnglishGreeting(name);
                    break;
                case Language.Chinese:
                    ChineseGreeting(name);
                    break;
            }
        }

        public static void    GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }
    }
}
