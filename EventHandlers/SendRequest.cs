using System.Net.Http;
using System.Text;

namespace MyLineBot.EventHandlers
{
    public class SendRequest
    {
        public dynamic replyMsg(string jsStr, string channelAccess) 
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://api.line.me/v2/bot/message/reply");
            requestMessage.Headers.Add("Authorization", $"Bearer {channelAccess}");

            requestMessage.Content =
                new StringContent(
                    jsStr,
                    Encoding.UTF8, "application/json");

            return requestMessage;
        }
    }
}
