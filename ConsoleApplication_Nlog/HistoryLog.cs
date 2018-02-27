using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Nlog
{
    public class HistoryLog
    {
        static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        private static object obj = new object();


        /// <summary>
        /// 记录发出的价格
        /// </summary>
        /// <param name="text"></param>
        public static void RecordSendPrice(string text)
        {
            log.Trace(text);
        }
        /// <summary>
        /// 记录收到各来源的价格
        /// </summary>
        /// <param name="text"></param>
        public static void RecordReceiveMessage(string text)
        {
            log.Debug(text);
        }
        /// <summary>
        /// 一般进程记录
        /// </summary>
        /// <param name="text"></param>
        public static void InsertHistory(string text)
        {
            log.Info(text);
        }
        /// <summary>
        /// 程序报错记录
        /// </summary>
        /// <param name="text"></param>
        public static void InsertError(string text)
        {
            log.Error(text);
        }
        /// <summary>
        /// 根据是否收市发送Emai
        /// </summary>
        /// <param name="text"></param>
        public static void SentMailByCloseTime(string text)
        {
            if (IsCloseTime())
            {
                log.Error(text);
            }
            else
            {
                //发送Email通知
                log.Warn(text);
            }
        }
        /// <summary>
        /// 发送Email
        /// </summary>
        /// <param name="text"></param>
        public static void SentMail(string text)
        {
            log.Warn(text);
            //lock (obj)
            //{
            //    log.Warn(text);
            //}
        }

        public static void SendMail2(string text)
        {
            log.Fatal(text);
            //lock (obj)
            //{
            //    log.Fatal(text);
            //}
            
        }
        /// <summary>
        /// 判断是否为收市时间
        /// </summary>
        /// <returns></returns>
        public static bool IsCloseTime()
        {
            bool IsClose = false;
            DateTime date = DateTime.Now;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    IsClose = true;
                    break;
                case DayOfWeek.Saturday:
                    {
                        if (date.CompareTo(Convert.ToDateTime("4:00")) == -1)
                        {
                            IsClose = false;
                        }
                        else
                        {
                            IsClose = true;
                        }
                        break;
                    }
                case DayOfWeek.Monday:
                    {
                        if (date.CompareTo(Convert.ToDateTime("4:00")) == -1)
                        {
                            IsClose = true;
                        }
                        else
                        {
                            IsClose = false;
                        }
                        break;
                    }
                default:
                    IsClose = false;
                    break;
            }
            return IsClose;

        }
    }
}
