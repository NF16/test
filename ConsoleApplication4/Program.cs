using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[] { "宝马", "奔驰", "奥迪", "东风", "劳斯莱斯" };
            decimal[] Prices = new decimal[] { 1, 2, 3.3M, 4.3M, 5.3M };
            Queue<decimal> quePrice = new Queue<decimal>();
            foreach (decimal price in Prices)
            {
                quePrice.Enqueue(price);
                Console.WriteLine("入队列-{0}", price);
            }
            Console.WriteLine("入队列-{0}", quePrice.Max());
            Func<decimal, decimal> ffe = s => s*2 ;
            Console.WriteLine("入队列-{0}", quePrice.Average<decimal>(ffe));
            //Console.WriteLine("开始入队列");
            //Queue<string> que = new Queue<string>();
            //foreach (string str in cars)
            //{
            //    que.Enqueue(str);
            //    Console.WriteLine("入队列-{0}", str);
            //}
            //Console.WriteLine();
            ////打印队列  
            //PrintQueue(que);
            //Console.WriteLine();
            //Console.WriteLine("开始出队列");
            //while (que.Count > 0)
            //{
            //    string str = que.Dequeue();
            //    Console.WriteLine("出队列-{0}", str);
            //}

            Console.WriteLine(Math.Pow(10, 0));

            SendMailUse();
            Console.ReadKey();
        }

        private static void PrintQueue(Queue<string> list)
        {
            Console.WriteLine("开始打印队列");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
        }


        private bool send(string emil, byte[] pdf)
        {
            string from = "gs.register@gs-markets.com.au"; //发件人  
            string to = emil;//收件人  

            string theme = "[珠海慧宇网络科技有限公司] 的工资单来了,亲~";//主题

            MailMessage messge = new MailMessage(from, to);  // 消息实例

            messge.Body = string.Format("工资单");

            messge.Subject = theme;

            messge.IsBodyHtml = true;
            messge.Priority = MailPriority.Normal;// 优先级别

            //messge.Attachments.Add(new Attachment(file));  

            SmtpClient client = new SmtpClient(); //Smtp协议  
            client.Host = "smtp.gmail.com"; //发送人的Smtp主机名称或IP地址，实例为163邮箱的Smtp地址  
            client.Port = 587;//587
            client.EnableSsl = true;
            string sendEmail = "gs.register@gs-markets.com.au";
            client.Credentials = new NetworkCredential(sendEmail, "dk123456");//验证发件人的身份凭据  

            MemoryStream ms = new MemoryStream(pdf);
            Attachment PDF = new Attachment(ms, "工资单.pdf", null);
            //
            messge.Attachments.Add(PDF);

            client.Send(messge);     //發送郵件。
            return true;
        }


        public static void SendMailUse()
        {
            string host = "smtp.126.com";// 邮件服务器smtp.163.com表示网易邮箱服务器    
            string userName = "vkfeng16@126.com";// 发送端账号   
            string password = "nf123456";// 发送端密码(这个客户端重置后的密码)




            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式    
            client.Host = host;//邮件服务器
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(userName, password);//用户名、密码

            //////////////////////////////////////
            string strfrom = userName;
            string strto = "ttfeng0758@qq.com";
            //string strcc = "2605625733@qq.com";//抄送


            string subject = "这是测试邮件标题5";//邮件的主题             
            string body = "测试邮件内容5";//发送的邮件正文  

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new MailAddress(strfrom, "xyf");
            msg.To.Add(strto);
            //msg.CC.Add(strcc);

            msg.Subject = subject;//邮件标题   
            msg.Body = body;//邮件内容   
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码   
            msg.IsBodyHtml = true;//是否是HTML邮件   
            msg.Priority = MailPriority.High;//邮件优先级   


            try
            {
                client.Send(msg);
                Console.WriteLine("发送成功");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                Console.WriteLine(ex.Message, "发送邮件出错");
            }
        }
    }
}
