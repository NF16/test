using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject jb = new JObject();
            JArray ja = new JArray();
            JObject item = new JObject();
            item.Add("NAME","EURUSD");
            item.Add("BID", "1.23456");
            item.Add("ASK", "1.23456");
            ja.Add(item);
            ja.Add(item);
            //jb.Add("ProductList", ja);
            Console.WriteLine(JsonConvert.SerializeObject(ja));
            JArray ja1 = JArray.Parse(JsonConvert.SerializeObject(ja));
            Console.WriteLine(ja1[0]["NAME"].ToString());
            //Dictionary<int, Test> dic = new Dictionary<int, Test>();
            //dic.Add(1, new Test(1));
            //dic.Add(2, new Test(2));
            //Test item = dic[1];
            //Console.WriteLine(item.i);
            //item = new Test(3);
            //Console.WriteLine(item.i);
            //Console.WriteLine(dic[1].i);

            //if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour <= 15)//5点到7点,不活跃时段
            //{
            //    Console.WriteLine("test");
            //}
                Console.ReadKey();



        }
    }

    public class Test
    {
        public int i;
        public Test(int  i)
        {
            this.i = i;
        }
    }
}
