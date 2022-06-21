using System.Collections.Generic;

namespace MyLineBot.EventHandlers
{
    public class replyCourse
    {
        public string replyToken { get; set; }
        public List<flexMsgCourse> messages { get; set; }
    }

    public class flexMsgCourse
    {
        public string type { get; set; }
        public string altText { get; set; }
        public contentFlexCourse contents { get; set; }
    }

    public class contentFlexCourse
    {
        public string type { get; set; }
        public string size { get; set; }
        public string direction { get; set; }
        public headerCourse header { get; set; }
    }
    public class headerCourse
    {
        public string type { get; set; }
        public string layout { get; set; }
        public List<contentHeaderCourse> contents { get; set; }
    }
    public class contentHeaderCourse
    {
        public string type { get; set; }
        public string text { get; set; }
        public string weight { get; set; }
        public string size { get; set; }
        public string align { get; set; }
        public List<string> contents { get; set; }
    }
    public class flexCourse
    {
        public dynamic course(string rtoken, string courseName)
        {
            var courseFlexMsg = new replyCourse()
            {
                replyToken = rtoken,
                messages = new List<flexMsgCourse>
                    {
                        new flexMsgCourse
                        {
                            type = "flex",
                            altText = "Your Course",
                            contents = new contentFlexCourse
                            {
                                type = "bubble",
                                size = "giga",
                                direction = "ltr",
                                header = new headerCourse
                                {
                                    type = "box",
                                    layout = "vertical",
                                    contents = new List<contentHeaderCourse>
                                    {
                                        new contentHeaderCourse
                                        {
                                            type = "text",
                                            text = courseName,
                                            weight = "bold",
                                            size = "xxl",
                                            align = "center",
                                            contents = new List<string> { }
                                        }
                                    }
                                }
                            }
                        }
                    }
            };
            return courseFlexMsg;
        }
    }
}
