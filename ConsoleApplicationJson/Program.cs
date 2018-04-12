using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApplicationJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string var = " [{\"Name\":\"HKGHKD\",\"Bid\":12378.8,\"Ask\":12384.8,\"Time\":\"2018 - 03 - 08 15:36:48:0080\"},{\"Name\":\"LLGUSD\",\"Bid\":1328.11,\"Ask\":1328.61,\"Time\":\"2018 - 03 - 08 15:36:48:0080\"}]";

            JArray obj = JsonConvert.DeserializeObject<JArray>(var);
            for (int i = 0; i < obj.Count; i++)
            {
                //if(obj[i].Contains("Name1"))
                //{
                //    Console.WriteLine("Name");
                //}
                if (obj[i]["N123"]==null)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    Console.WriteLine(obj[i]["N123"].ToString());
                }
            }
            //decimal a = Convert.ToDecimal("-123");
            //Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}

        //HttpWebRequest request = (HttpWebRequest)result.AsyncState;
        //HttpWebResponse response = (HttpWebResponse)(request.EndGetResponse(result));
        //stream = response.GetResponseStream();
        //StreamReader reader = new StreamReader(stream, false);
        //string apiText = reader.ReadToEnd();
        //JObject jsonObj = null;
        //        try
        //        {
        //            jsonObj = JObject.Parse(apiText);
        //            if (jsonObj.Count == 1 || (int)(jsonObj["status"]) != 0) this.isError = true;
        //            else
        //            {
        //                string provinceName = (string)jsonObj["result"]["address_component"]["province"];
        //                string cityName = this.cityName_s = (string)jsonObj["result"]["address_component"]["city"];
        //                string districtName = (string)jsonObj["result"]["address_component"]["district"];
        //                string street = (string)jsonObj["result"]["address_component"]["street"];
        //                /*下面是解析JArray的部分*/
        //                JArray jlist = JArray.Parse(jsonObj["result"]["pois"].ToString()); //将pois部分视为一个JObject，JArray解析这个JObject的字符串
        //                LocationItem locationitem = null;      //存储附近的某个地点的信息
        //                locations = new List<LocationItem>();  //附近位置的列表
        //                for(int i = 0; i<jlist.Count ; ++i)  //遍历JArray
        //                {
        //                    locationitem = new LocationItem();
        //                JObject tempo = JObject.Parse(jlist[i].ToString());
        //                locationitem.id = tempo["id"].ToString();
        //                locationitem.title = tempo["title"].ToString();
        //                locationitem._distance = tempo["_distance"].ToString();
        //                locationitem.address = tempo["address"].ToString();
        //                locationitem.category = tempo["category"].ToString();
        //                locationitem.location.lat = tempo["location"]["lat"].ToString();
        //                locationitem.location.lng = tempo["location"]["lng"].ToString();
        //                locations.Add(locationitem);
        //                }
        //        }
        //        }
        //        catch (Exception)
        //        {
        //            isError = true;
        //        }
        //        }
        //    }
