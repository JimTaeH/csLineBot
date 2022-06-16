using System;
using System.Threading.Tasks;
using Line;
using MyLineBot.Configuration;

namespace MyLineBot.EventHandlers
{
    public class MessageEventHandler : ILineEventHandler
    {
        private readonly MyLineBotConfiguration configuration;

        public LineEventType EventType
            => LineEventType.Message;

        public MessageEventHandler(MyLineBotConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Handle(ILineBot lineBot, ILineEvent evt)
        {
            if (string.IsNullOrEmpty(evt.Message.Text))
                return;

            // The Webhook URL verification uses these invalid token.
            if (evt.ReplyToken == "00000000000000000000000000000000" || evt.ReplyToken == "ffffffffffffffffffffffffffffffff")
                return;

            if (evt.Message.Text.ToLowerInvariant().Contains("ping"))
            {
                var response = new TextMessage($"pong pong pong");

                await lineBot.Reply(evt.ReplyToken, response);
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
            else if (evt.Message.Text.ToLowerInvariant().Contains("logo"))
            {
                var logoUrl = this.configuration.ResourcesUrl + "/Images/sample_frog.png";

                Console.WriteLine(logoUrl);
                var response = new ImageMessage(logoUrl, logoUrl);

                await lineBot.Reply(evt.ReplyToken, response);
            }
        }
    }
}