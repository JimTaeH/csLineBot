using System.Collections.Generic;

namespace MyLineBot.EventHandlers
{
    public class replyCourseD
    {
        public string replyToken { get; set; }
        public List<flexMsgCourseD> messages { get; set; }
    }

    public class flexMsgCourseD
    {
        public string type { get; set; }
        public string altText { get; set; }
        public contentFlexCourseD contents { get; set; }
    }

    public class contentFlexCourseD
    {
        public string type { get; set; }
        public string size { get; set; }
        public string direction { get; set; }
        public headerCourseD header { get; set; }
        public heroCourseD hero { get; set; }
        public bodyCourseD body { get; set; }
    }
    public class headerCourseD
    {
        public string type { get; set; }
        public string layout { get; set; }
        public List<contentHeaderCourseD> contents { get; set; }
    }
    public class contentHeaderCourseD
    {
        public string type { get; set; }
        public string text { get; set; }
        public string weight { get; set; }
        public string size { get; set; }
        public string align { get; set; }
        public List<string> contents { get; set; }
    }
    public class heroCourseD
    {
        public string type { get; set; }
        public string url { get; set; }
        public string size { get; set; }
        public string aspectRatio { get; set; }
        public string aspectMode { get; set; }
    }
    public class bodyCourseD
    {
        public string type { get; set; }
        public string layout { get; set; }
        public List<contentInBoxCourseD> contents { get; set; }
    }
    public class contentInBoxCourseD
    {
        public string type { get; set; }
        public string text { get; set; }
        public string align { get; set; }
        public bool wrap { get; set; }
        public List<string> contents { get; set; }
    }
    public class flexCourseDetail
    {
        public dynamic courseDetail(string rtoken, string courseName, string courseDesc)
        {
            var courseDetailFlex = new replyCourseD()
            {
                replyToken = rtoken,
                messages = new List<flexMsgCourseD>
                    {
                        new flexMsgCourseD
                        {
                            type = "flex",
                            altText = "Course Detail",
                            contents = new contentFlexCourseD
                            {
                                type = "bubble",
                                size = "giga",
                                direction = "ltr",
                                header = new headerCourseD
                                {
                                    type = "box",
                                    layout = "vertical",
                                    contents = new List<contentHeaderCourseD>
                                    {
                                        new contentHeaderCourseD
                                        {
                                            type = "text",
                                            text = courseName,
                                            weight = "bold",
                                            size = "xxl",
                                            align = "center",
                                            contents = new List<string> { }
                                        }
                                    }
                                },
                                hero = new heroCourseD()
                                {
                                    type = "image",
                                    url = "https://firebasestorage.googleapis.com/v0/b/second-try-cb-pirwud.appspot.com/o/ClusterCompute.png?alt=media&token=2fbe5dbc-4804-490b-86fe-2f180709e1ee",
                                    size = "full",
                                    aspectRatio = "1.51:1",
                                    aspectMode = "fit"
                                },
                                body = new bodyCourseD()
                                {
                                    type = "box",
                                    layout = "vertical",
                                    contents = new List<contentInBoxCourseD>
                                    {
                                        new contentInBoxCourseD
                                        {
                                            type = "text",
                                            text = courseDesc,
                                            align = "center",
                                            wrap = true,
                                            contents = new List<string> { }
                                        }
                                    }
                                }
                            }
                        }
                    }
            };
            return courseDetailFlex;
        }
    }
}
