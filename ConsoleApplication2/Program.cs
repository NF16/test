using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string haha = "1.2346";
            string xixi = "1.2346";
            decimal dhaha = decimal.Parse(haha);
            decimal dxixi = decimal.Parse(xixi);
            if(dhaha==dxixi)
            {
                Console.WriteLine("不得不服");
            }
            Dictionary<string, int> dir = new Dictionary<string, int>();
            dir.Add("1", 1);
            dir.Add("3",3);
            dir.Add("2", 2);

            Dictionary<string,加法类 > PriceReceive = new Dictionary<string,加法类>();
            PriceReceive.Add("RETUR", new 加法类());
            PriceReceive.Add("SAXO", new 加法类());
            PriceReceive.Add("SP", new 加法类());
            Dictionary<string, 加法类> PriceReceive1 = new Dictionary<string, 加法类>();
            PriceReceive1.Add("SAXO", new 加法类());
            PriceReceive1.Add("RETUR", new 加法类());
            PriceReceive1.Add("SP", new 加法类());

            //Hashtable PriceReceive2 = new Hashtable();
            //PriceReceive2 = PriceReceive;
            
            foreach (string item in PriceReceive.Keys)
            {
                Console.WriteLine(item);
            }
            PriceReceive = new Dictionary<string, 加法类>();
            foreach (string item in PriceReceive1.Keys)
            {
                PriceReceive.Add(item, PriceReceive1[item]);
            }

            foreach (string item in PriceReceive.Keys)
            {
                Console.WriteLine(item);
            }




            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");


            string t1 = string.Empty;
            if(t1=="")
            {
                Console.WriteLine("123");
            }
            Console.WriteLine(t1.Length);
            加法类 te = new 加法类();
            te.name = "123";
            加法类 se = te;
            te.name = "345";
            Console.WriteLine(se.name);
            
            decimal f = 20;
            decimal t = Convert.ToDecimal(f / 100);
            Console.WriteLine(t);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            string AddProductList = "AUDUSD_";
            List<string> lstTradeProduct = new List<string>(AddProductList.Split('_'));
            for (int i = 0; i < lstTradeProduct.Count; i++)
            {
                Console.WriteLine(lstTradeProduct[i]+"___");
            }

            if (DateTime.Now.Hour == 15)
            {
                Console.WriteLine("你想不到吧");
            }
            string test = "/fefg123";
            Console.WriteLine(test.ToUpper());
            //Console.WriteLine("===== 同步调用 SyncInvokeTest =====");
            //AddHandler handler = new AddHandler(加法类.Add);
            //int result = handler(1, 2);
            //Console.WriteLine("继续做别的事情。。。");
            //Console.WriteLine(result);
            //Console.ReadKey();

            //Console.WriteLine("===== 异步调用 AsyncInvokeTest =====");
            //AddHandler handler = new AddHandler(加法类.Add);
            ////IAsyncResult: 异步操作接口(interface)
            ////BeginInvoke: 委托(delegate)的一个异步方法的开始
            //IAsyncResult result = handler.BeginInvoke(1, 2, null, null);
            //Console.WriteLine("继续做别的事情。。。");
            ////异步操作返回
            //Console.WriteLine(handler.EndInvoke(result));
            //Console.ReadKey();

            Console.WriteLine("===== 异步回调 AsyncInvokeTest =====");
            AddHandler handler = new AddHandler(加法类.Add);
            //异步操作接口(注意BeginInvoke方法的不同！)
            IAsyncResult result = handler.BeginInvoke(1, 2, ar => handler.EndInvoke(ar), "AsycState:OK");
            Console.WriteLine("继续做别的事情。。。");
            Console.ReadKey();
        }

        static void 回调函数(IAsyncResult result)
        {
            //result 是“加法类.Add()方法”的返回值
            //AsyncResult 是IAsyncResult接口的一个实现类，空间：System.Runtime.Remoting.Messaging
            //AsyncDelegate 属性可以强制转换为用户定义的委托的实际类。
            AddHandler handler = (AddHandler)((AsyncResult)result).AsyncDelegate;
            handler.EndInvoke(result);
            Console.WriteLine(result.AsyncState);

        }
    }

    public delegate void AddHandler(int a, int b);
    public class 加法类
    {
        public string name = "";
        public static void Add(int a, int b)
        {
            Console.WriteLine("开始计算：" + a + "+" + b);
            Thread.Sleep(3000); //模拟该方法运行三秒
            Console.WriteLine("计算完成！");
            //return a + b;
        }
    }
}
