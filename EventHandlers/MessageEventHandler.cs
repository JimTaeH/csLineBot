using System;
using System.Threading.Tasks;
using Line;
using MyLineBot.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.Json;

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
            var context = new Models.SchoolDBContext();

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
            else if (evt.Message.Text.ToLowerInvariant().Contains("logo"))
            {
                var logoUrl = this.configuration.ResourcesUrl + "/Images/sample_frog.png";

                Console.WriteLine(logoUrl);
                var response = new ImageMessage(logoUrl, logoUrl);

                await lineBot.Reply(evt.ReplyToken, response);
            }
            // add my
            else if (evt.Message.Text.Contains("สวัสดี"))
            {
                var response = new TextMessage("สวัสดีครับจาก NotifySKF");

                await lineBot.Reply(evt.ReplyToken, response);
            }
            else if (evt.Message.Text == "echo echo")
            {
                await lineBot.Reply(evt.ReplyToken, new TextMessage(evt.Message.Text));
            }
            else if (evt.Message.Text.Contains("Data"))
            {
                string fullText = evt.Message.Text;
                string[] queryText = fullText.Split(" ");

                try
                {
                    var uName = context.Students.SingleOrDefault(x => x.Name == $"{queryText[1]}");
                    var uCourse = context.Courses.SingleOrDefault(x => x.CourseId == uName.CourseId);

                    var response = new TextMessage($"Your name in DB: {uName.Name} {uName.FirstName} {uName.LastName}");
                    var response2 = new TextMessage($"Your course is: {uCourse.CourseName}");
                    await lineBot.Reply(evt.ReplyToken, response, response2);
                }
                catch (InvalidOperationException)
                {
                    var response = new TextMessage($"Your query {queryText}");
                    await lineBot.Reply(evt.ReplyToken, response);
                }
            }
            else if (evt.Message.Text.Contains("Course"))
            {
                string fullText = evt.Message.Text;
                string[] queryText = fullText.Split(" ");

                var uName = context.Students.SingleOrDefault(x => x.Name == $"{queryText[1]}");
                var uCourse = context.Courses.SingleOrDefault(x => x.CourseId == uName.CourseId);

                var flexMessage = new flexCourse().course(evt.ReplyToken, uCourse.CourseName);

                string jsonString = JsonSerializer.Serialize(flexMessage);
                Console.WriteLine($"PostedData {jsonString}");

                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://api.line.me/v2/bot/message/reply"))
                {
                    requestMessage.Headers.Add("Authorization", $"Bearer {chAccess}");

                    requestMessage.Content =
                        new StringContent(
                            jsonString,
                            Encoding.UTF8, "application/json");

                    await client.SendAsync(requestMessage);
                }
            }
            else if (evt.Message.Text.Contains("Card"))
            {
                string fullText = evt.Message.Text;
                string[] queryText = fullText.Split(" ");

                var uName = context.Students.SingleOrDefault(x => x.Name == $"{queryText[1]}");
                var uCourse = context.Courses.SingleOrDefault(x => x.CourseId == uName.CourseId);

                var flexMessage = new flexStudentCard().studentCard(evt.ReplyToken, uName.Name, uName.FirstName, uName.LastName);

                string jsonString = JsonSerializer.Serialize(flexMessage);
                Console.WriteLine($"PostedData {jsonString}");

                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://api.line.me/v2/bot/message/reply"))
                {
                    requestMessage.Headers.Add("Authorization", $"Bearer {chAccess}");

                    requestMessage.Content =
                        new StringContent(
                            jsonString,
                            Encoding.UTF8, "application/json");

                    await client.SendAsync(requestMessage);
                }
            }
            else if (evt.Message.Text.Contains("Detail"))
            {
                string fullText = evt.Message.Text;
                string[] queryText = fullText.Split(" ");

                var uCourse = context.Courses.SingleOrDefault(x => x.CourseName.Contains(queryText[1]));

                var flexMessage = new flexCourseDetail().courseDetail(evt.ReplyToken, uCourse.CourseName, uCourse.CourseDesc);

                string jsonString = JsonSerializer.Serialize(flexMessage);
                Console.WriteLine($"PostedData {jsonString}");

                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://api.line.me/v2/bot/message/reply"))
                {
                    requestMessage.Headers.Add("Authorization", $"Bearer {chAccess}");

                    requestMessage.Content =
                        new StringContent(
                            jsonString,
                            Encoding.UTF8, "application/json");

                    await client.SendAsync(requestMessage);
                }
            }
            else if (evt.Message.Text == "Create Me")
            {
                var userId = evt.Source.User.Id;
                var richMenuId = "richmenu-04e992516bfd579a44c8112b4de96d43";

                var std = new Models.Student();
                std.Name = "MungKornSS";
                std.FirstName = "Mung";
                std.LastName = "Korn";
                std.Course = context.Courses.Single(x => x.CourseName == "Entity Framework");
                context.Students.Add(std);
                context.SaveChanges();

                var response = new TextMessage("Created Success");
                await lineBot.Reply(evt.ReplyToken, response);

                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"https://api.line.me/v2/bot/user/{userId}/richmenu/{richMenuId}"))
                {
                    requestMessage.Headers.Add("Authorization", $"Bearer {chAccess}");

                    await client.SendAsync(requestMessage);
                }

            }
            else if (evt.Message.Text == "Delete Me")
            {
                var userId = evt.Source.User.Id;

                var std = context.Students.Single(x => x.Name == "MungKornSS");
                context.Students.Remove(std);
                context.SaveChanges();

                var response = new TextMessage("Deleted Success");
                await lineBot.Reply(evt.ReplyToken, response);

                using (var requestMessage = new HttpRequestMessage(HttpMethod.Delete, $"https://api.line.me/v2/bot/user/{userId}/richmenu"))
                {
                    requestMessage.Headers.Add("Authorization", $"Bearer {chAccess}");

                    await client.SendAsync(requestMessage);
                }
            }
        }
    }
}