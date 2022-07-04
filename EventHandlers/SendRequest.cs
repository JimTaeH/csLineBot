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
        public dynamic pushMsg(string jsStr, string channelAccess)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://api.line.me/v2/bot/message/multicast");
            requestMessage.Headers.Add("Authorization", $"Bearer {channelAccess}");

            requestMessage.Content =
                new StringContent(
                    jsStr,
                    Encoding.UTF8, "application/json");

            return requestMessage;
        }
        public dynamic linkRMOneUser(string userId, string richMenuId, string channelAccess) 
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"https://api.line.me/v2/bot/user/{userId}/richmenu/{richMenuId}");
            requestMessage.Headers.Add("Authorization", $"Bearer {channelAccess}");

            return requestMessage;
        }
        public dynamic unlinkRMOneUser(string userId, string channelAccess) 
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Delete, $"https://api.line.me/v2/bot/user/{userId}/richmenu");
            requestMessage.Headers.Add("Authorization", $"Bearer {channelAccess}");

            return requestMessage;
        }
    }
}
