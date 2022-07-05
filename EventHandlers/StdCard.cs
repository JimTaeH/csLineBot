using System.Collections.Generic;
// Example of Flexmessages
namespace MyLineBot.EventHandlers
{
    public class replyCard
    {
        public string replyToken { get; set; }
        public List<flexMsgCard> messages { get; set; }
    }

    public class flexMsgCard
    {
        public string type { get; set; }
        public string altText { get; set; }
        public contentFlexCard contents { get; set; }
    }

    public class contentFlexCard
    {
        public string type { get; set; }
        public string size { get; set; }
        public string direction { get; set; }
        public headerCard header { get; set; }
        public heroCard hero { get; set; }
        public bodyCard body { get; set; }
    }
    public class headerCard
    {
        public string type { get; set; }
        public string layout { get; set; }
        public List<contentHeaderCard> contents { get; set; }
    }
    public class contentHeaderCard
    {
        public string type { get; set; }
        public string text { get; set; }
        public string weight { get; set; }
        public string size { get; set; }
        public string align { get; set; }
        public List<string> contents { get; set; }
    }
    public class heroCard
    {
        public string type { get; set; }
        public string url { get; set; }
        public string size { get; set; }
        public string aspectRatio { get; set; }
        public string aspectMode { get; set; }
    }
    public class bodyCard
    {
        public string type { get; set; }
        public string layout { get; set; }
        public List<contentBodyBoxCard> contents { get; set; }
    }
    public class contentBodyBoxCard
    {
        public string type { get; set; }
        public string layout { get; set; }
        public List<contentInBoxCard> contents { get; set; }
    }
    public class contentInBoxCard
    {
        public string type { get; set; }
        public string text { get; set; }
        public string weight { get; set; }
        public string align { get; set; }
        public List<string> contents { get; set; }
    }
    public class flexStudentCard
    {
        public dynamic studentCard(string rtoken, string stdName, string stdFname, string stdLname)
        {
            var studentCardFlex = new replyCard()
            {
                replyToken = rtoken,
                messages = new List<flexMsgCard>
                    {
                        new flexMsgCard
                        {
                            type = "flex",
                            altText = "Your Student Card",
                            contents = new contentFlexCard
                            {
                                type = "bubble",
                                size = "mega",
                                direction = "ltr",
                                header = new headerCard
                                {
                                    type = "box",
                                    layout = "vertical",
                                    contents = new List<contentHeaderCard>
                                    {
                                        new contentHeaderCard
                                        {
                                            type = "text",
                                            text = stdName,
                                            weight = "bold",
                                            size = "xxl",
                                            align = "center",
                                            contents = new List<string> { }
                                        }
                                    }
                                },
                                hero = new heroCard()
                                {
                                    type = "image",
                                    url = "https://firebasestorage.googleapis.com/v0/b/second-try-cb-pirwud.appspot.com/o/studentBoy.png?alt=media&token=6b180fc4-9aab-4240-956e-2c0409fda65d",
                                    size = "full",
                                    aspectRatio = "3:4",
                                    aspectMode = "fit"
                                },
                                body = new bodyCard()
                                {
                                    type = "box",
                                    layout = "vertical",
                                    contents = new List<contentBodyBoxCard>
                                    {
                                        new contentBodyBoxCard
                                        {
                                            type = "box",
                                            layout = "horizontal",
                                            contents = new List<contentInBoxCard>
                                            {
                                                new contentInBoxCard
                                                {
                                                    type = "text",
                                                    text = stdFname,
                                                    weight = "bold",
                                                    align = "center",
                                                    contents = new List<string> { }
                                                },
                                                new contentInBoxCard
                                                {
                                                    type = "text",
                                                    text = stdLname,
                                                    weight = "bold",
                                                    align = "center",
                                                    contents = new List<string> { }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
            };
            return studentCardFlex;
        }
    }
}
