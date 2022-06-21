using System;
using System.Threading.Tasks;
using Line;
using MyLineBot.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace MyLineBot.EventHandlers
{
    public class PostbackEventHandler : ILineEventHandler
    {
        private readonly MyLineBotConfiguration configuration;
        private static readonly HttpClient client = new HttpClient();
        private string chAccess = "YuiRCG1kEfW7kLxKszY+wDfcnvOjA8tVKDp1UjK/vW+qic1MXFLTiWecx4BE2c9w9lOqLvXD9C4rIvi7kWQzdRlOJEcrydOnnqpwi/aNJvNUVBmif4tSr0dzAlaLuACOmK8lLJmOWWaEK6WCeCdfUgdB04t89/1O/w1cDnyilFU=";

        public LineEventType EventType
            => LineEventType.Postback;

        public PostbackEventHandler(MyLineBotConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task Handle(ILineBot lineBot, ILineEvent evt) 
        {
            var context = new Models.SchoolDBContext();

            // The Webhook URL verification uses these invalid token.
            if (evt.ReplyToken == "00000000000000000000000000000000" || evt.ReplyToken == "ffffffffffffffffffffffffffffffff")
                return;

            if (evt.EventType == LineEventType.Postback)
            {
                var pbData = evt.Postback.Data;
                var response = new TextMessage($"Postback Data is {pbData}");
                await lineBot.Reply(evt.ReplyToken, response);
            }
        }
    }
}
