using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
namespace MonitorLockMutex
{
    class Program
    {
        #region variable 
        Thread thread1 = null;
        Thread thread2 = null;
        Mutex mutex = null;
        static Stopwatch sw = new Stopwatch();
        #endregion
        static void Main(string[] args)
        {
           
            sw.Start();
            Program p = new Program();
            p.RunThread();
            Console.ReadLine();
        }
        public Program()
        {
            mutex = new Mutex();
            thread1 = new Thread(new ThreadStart(thread1Func));
            //thread2 = new Thread(new ThreadStart(thread2Func));
        }
        public void RunThread()
        {
            thread1.Start();
            //thread2.Start();
        }
        private void thread1Func()
        {
            for (int count = 0; count < 10; count++)
            {
                mutex.WaitOne();
                TestFunc("[1] have run " + count.ToString() + " times",100,true);
                
                Thread.Sleep(30);
                mutex.ReleaseMutex();
                TestFunc("[2] have run " + count.ToString() + " times", 10, true);
            }
        }
        private void thread2Func()
        {
            for (int count = 0; count < 10; count++)
            {
                mutex.WaitOne();
                TestFunc("                                                                     [2] have run " + count.ToString() + " times",50,true);
                
                Thread.Sleep(100);
                mutex.ReleaseMutex();
            }
            sw.Stop();
            Console.WriteLine("Stopwatch总共花费{0}ms.", sw.Elapsed.TotalMilliseconds);
        }
        private void TestFunc(string str,int sle,bool isbreak)
        {
            //lock (this)
            //{
            //    Console.WriteLine("{0} {1}", str, System.DateTime.Now.Millisecond.ToString());
            //    Thread.Sleep(50);
            //}
            //Monitor.Enter(this);
            //Console.WriteLine("{0} {1}", str, System.DateTime.Now.Millisecond.ToString());
            //Thread.Sleep(50);
            //Monitor.Exit(this);

            Console.WriteLine("{0} {1}", str, System.DateTime.Now.Millisecond.ToString());
            Thread.Sleep(sle);
            if(isbreak)
            {
                return;
            }
            TestFunc("[3] have run times", 50,true);
        }
    }
}