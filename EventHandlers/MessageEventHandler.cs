using System;
using System.Threading.Tasks;
using Line;
using MyLineBot.ConfigurationLINE;
using System.Linq;
using System.Net.Http;
using System.Text;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.Json;
using System.Collections.Generic;
using MyLineBot.Common;

namespace MyLineBot.EventHandlers
{
    public class MessageEventHandler : ILineEventHandler
    {
        private readonly MyLineBotConfiguration configuration;
        private static readonly HttpClient client = new HttpClient();
        private string chAccess = "YuiRCG1kEfW7kLxKszY+wDfcnvOjA8tVKDp1UjK/vW+qic1MXFLTiWecx4BE2c9w9lOqLvXD9C4rIvi7kWQzdRlOJEcrydOnnqpwi/aNJvNUVBmif4tSr0dzAlaLuACOmK8lLJmOWWaEK6WCeCdfUgdB04t89/1O/w1cDnyilFU=";

        public LineEventType EventType
            => LineEventType.Message;

        public MessageEventHandler(MyLineBotConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Handle(ILineBot lineBot, ILineEvent evt)
        {
            //var context = new Models.SchoolDBContext();
            //var contextLogin = new Models.LineUserDBContext();
            //var ctx00008 = new Models._00008Context();
            //var ctxSIMAT = new CenterDB.SIMATCOMMONContext();
            var simatDB = new DatabaseManager().Common();

            // The Webhook URL verification uses these invalid token.
            if (evt.ReplyToken == "00000000000000000000000000000000" || evt.ReplyToken == "ffffffffffffffffffffffffffffffff")
                return;

            if (evt.Message.MessageType == MessageType.Sticker)
            {
                return;
            }

            else if (evt.Message.Text.ToLowerInvariant().Contains("user"))
            {
                var userName = evt.Source.User.Id;
                try
                {
                    var user = await lineBot.GetProfile(evt.Source.User);
                    userName = $"{user.DisplayName} ({user.UserId})";
                }
                catch (LineBotException)
                {
                }

                var response = new TextMessage($"You are: {userName}");

                await lineBot.Reply(evt.ReplyToken, response);
            }
            //else if (evt.Message.Text.ToLowerInvariant().Contains("logo"))
            //{
            //    var logoUrl = this.configuration.ResourcesUrl + "/Images/sample_frog.png";

            //    Console.WriteLine(logoUrl);
            //    var response = new ImageMessage(logoUrl, logoUrl);

            //    await lineBot.Reply(evt.ReplyToken, response);
            //}
            // add my
            else if (evt.Message.Text == "ติดตามสถานะพัสดุ") 
            {
                var userId = evt.Source.User.Id;
                try
                {
                    var user = await lineBot.GetProfile(evt.Source.User);
                    userId = user.UserId;
                }
                catch (LineBotException)
                {
                }

                var userLINE = simatDB.LineRegisters.Single(x => x.UserId == userId);
                string userDB = userLINE.Dbcode;
                var customer = simatDB.Customers.Single(x => x.CustomerId == userDB);
                var db = new DatabaseManager().Prototype(userDB);

                string rtoken = evt.ReplyToken;
                string companyName = $"{customer.CustomerName}";
                string jobNo = "0123456789";
                string mdy1 = "2022-06-29";
                string statusEmo1 = "📦";
                string status1 = "รับฝาก";
                string time1 = "10:11:59";
                string locate1 = "ลาดกระบัง";
                string mdy2 = "2022-06-29";
                string statusEmo2 = "🚚";
                string status2 = "อยู่ระหว่างจัดส่ง";
                string time2 = "14:01:22";
                string locate2 = "ห้วยขวาง";
                string mdy3 = "2022-06-29";
                string statusEmo3 = "✔️";
                string status3 = "จัดส่งสำเร็จ";
                string time3 = "14:20:01";
                string locate3 = "ห้วยขวาง";

                try 
                {
                    var jobs = db.Tjobs.Where(x => x.Bpcode == userLINE.Bpcode).ToList();
                    jobNo = jobs[0].Jobno;
                }
                catch (InvalidOperationException) 
                {
                    var response = new TextMessage("ไม่พบข้อมูล");
                    await lineBot.Reply(evt.ReplyToken, response);
                }

                var flexMessage = new flexTrackReply().flexTrackMsgReply(rtoken, companyName, jobNo, mdy1, statusEmo1, status1, time1, locate1, mdy2, statusEmo2, status2, time2, locate2, mdy3, statusEmo3, status3, time3, locate3);

                string jsonString = JsonSerializer.Serialize(flexMessage);
                Console.WriteLine($"PostedData {jsonString}");

                var requestMsg = new SendRequest().replyMsg(jsonString, chAccess);
                await client.SendAsync(requestMsg);

                var msglogs = new Data.LineMsgLog();
                msglogs.SentTime = DateTime.Now;
                msglogs.ReplyToken = rtoken;
                msglogs.ToUser = userId;
                msglogs.PostedData = jsonString;
                db.LineMsgLogs.Add(msglogs);
                db.SaveChanges();
            }
            else if (evt.Message.Text == "Track txt")
            {
                var response = new TextMessage("บริษัท A หมายเลขใบงาน 012345678 ขณะนี้สถานะของพัสดุคือ เข้าระบบ เมื่อวันที่ 06/27/2022 เวลา 10:00 น.");
                await lineBot.Reply(evt.ReplyToken, response);
            }
            //else if (evt.Message.Text == "Track Push")
            //{
            //    var userId = new List<string>();
            //    userId.Add(simatDB.LineRegisters.Single(x => x.Value1 == "CompanyA").UserId);

            //    string companyName = "Sample Co., Ltd.";
            //    string jobNo = "0123456789";
            //    string mdy1 = "2022-06-29";
            //    string statusEmo1 = "📦";
            //    string status1 = "รับฝาก";
            //    string time1 = "10:11:59";
            //    string locate1 = "ลาดกระบัง";
            //    string mdy2 = "2022-06-29";
            //    string statusEmo2 = "🚚";
            //    string status2 = "อยู่ระหว่างจัดส่ง";
            //    string time2 = "14:01:22";
            //    string locate2 = "ห้วยขวาง";
            //    string mdy3 = "2022-06-29";
            //    string statusEmo3 = "✔️";
            //    string status3 = "จัดส่งสำเร็จ";
            //    string time3 = "14:20:01";
            //    string locate3 = "ห้วยขวาง";

            //    var flexMessage = new flexTrackPush().flexTrackMsgPush(userId, companyName, jobNo, mdy1, statusEmo1, status1, time1, locate1, mdy2, statusEmo2, status2, time2, locate2, mdy3, statusEmo3, status3, time3, locate3);

            //    string jsonString = JsonSerializer.Serialize(flexMessage);
            //    Console.WriteLine($"PostedData {jsonString}");

            //    var requestMsg = new SendRequest().pushMsg(jsonString, chAccess);
            //    await client.SendAsync(requestMsg);
            //}
            else if (evt.Message.Text == "LINK MENU")
            {
                var userId = evt.Source.User.Id;
                var richMenuId = "richmenu-04e992516bfd579a44c8112b4de96d43";

                var response = new TextMessage("Menu Changed");
                await lineBot.Reply(evt.ReplyToken, response);

                var requestMsg = new SendRequest().linkRMOneUser(userId, richMenuId, chAccess);
                await client.SendAsync(requestMsg);
            }
            else if (evt.Message.Text == "UNLINK MENU")
            {
                var userId = evt.Source.User.Id;

                var response = new TextMessage("Menu Changed");
                await lineBot.Reply(evt.ReplyToken, response);

                var requestMsg = new SendRequest().unlinkRMOneUser(userId, chAccess);
                await client.SendAsync(requestMsg);
            }
        }
    }
}