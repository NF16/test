using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? TEST;
            TEST = null;
            if(TEST==null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine(TEST.ToString());
            }

            string LLGUSD = "LLG_USD";
            Console.WriteLine(LLGUSD.Remove(3,1));
            //Console.WriteLine(Math.Round(1m,5));
            //int i = 0;
            //int b = i++;
            //Console.WriteLine(b);

            //Random rd = new Random();
            //int num = rd.Next(0, 10);
            //for(int a=0;a<20;a++)
            //{
            //    Console.WriteLine(rd.Next(1, 5));
            //}
            //string value = " 123 456  789 ";
            //string[] StringArray = value.Trim().Split();
            //Console.WriteLine(StringArray[0]);
            //Console.WriteLine(StringArray[1]);
            //Console.WriteLine(StringArray[2]);

            //InfoStudent student = new InfoStudent();
            //student.StudyBase();
            //student.Work();
            //student.StudySpecial();
            Console.ReadKey();
            //Thread.Sleep(60000);
            //System.Diagnostics.Process.Start(@"C:\JProject\Usage_DLL_PriceForm_SpotTest\Usage_DLL_PriceForm.exe");
        }
    }
    //定义学生接口
    public interface IStudent
    {
        void StudyBase();
    }

    //定义职员接口
    public interface IEmployee
    {
        void Work();
    }

    //定义计算机专业学生接口
    public interface IInfoStudent : IStudent
    {
        void StudySpecial();
    }

    public class InfoStudent : IEmployee, IInfoStudent
    {
        //实现学生接口方法
        public void StudyBase()
        {
            Console.WriteLine("数学、语文和英语必须学好");
        }

        //实现职员接口方法

        public void Work()
        {
            Console.WriteLine("工作必须完成");
        }
        //实现计算机专业学生接口

        public void StudySpecial()
        {
            Console.WriteLine("计算机类的学生除学好基础课外，还要学C#");
        }
    }

}
