using System.Collections.Generic;
namespace MyLineBot.EventHandlers
{
    public class replyTrack
    {
        public string replyToken { get; set; }
        public List<object> messages { get; set; }
    }
    public class flexTrackReply
    {
        public dynamic flexTrackMsgReply(string rtoken, string companyName, string jobNo, string mdy1, string statusEmo1, string status1, string time1, string locate1, string mdy2, string statusEmo2, string status2, string time2, string locate2, string mdy3, string statusEmo3, string status3, string time3, string locate3)
        {
            var TrackMsg = new replyTrack()
            {
                replyToken = rtoken,
                messages = new List<object>()
                {
                    new
                    {
                        type = "flex",
                        altText = "Tracking Status",
                        contents = new
                        {
                            type = "bubble",
                            size = "giga",
                            header = new
                            {
                                type = "box",
                                layout = "horizontal",
                                contents = new List<object>()
                                {
                                    new
                                    {
                                        type = "box",
                                        layout = "vertical",
                                        contents = new List<object>()
                                        {
                                            new
                                            {
                                                type = "text",
                                                text = "บริษัท",
                                                color = "#ffffff66",
                                                size = "sm",
                                                flex = 4,
                                                weight = "regular"
                                            },
                                            new
                                            {
                                                type = "text",
                                                text = companyName,
                                                color = "#ffffff",
                                                size = "md",
                                                flex = 4,
                                                weight = "bold"
                                            }
                                        }
                                    },
                                    new
                                    {
                                        type = "box",
                                        layout = "vertical",
                                        contents = new List<object>()
                                        {
                                            new
                                            {
                                                type = "text",
                                                text = "เลขที่",
                                                color = "#ffffff66",
                                                size = "sm",
                                                flex = 4,
                                                weight = "regular"
                                            },
                                            new
                                            {
                                                type = "text",
                                                text = jobNo,
                                                color = "#ffffff",
                                                size = "md",
                                                flex = 4,
                                                weight = "bold"
                                            }
                                        }
                                    }
                                },
                                paddingAll = "20px",
                                backgroundColor = "#0367D3",
                                spacing = "md",
                                paddingTop = "22px"
                            },
                            body = new
                            {
                                type = "box",
                                layout = "vertical",
                                contents = new List<object>()
                                {
                                    new
                                    {
                                        type = "box",
                                        layout = "horizontal",
                                        contents = new List<object>()
                                        {
                                            new
                                            {
                                                type = "text",
                                                text = mdy1,
                                                size = "sm",
                                                gravity = "center",
                                                align = "end"
                                            },
                                            new
                                            {
                                                type = "box",
                                                layout = "vertical",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "filler"
                                                    },
                                                    new
                                                    {
                                                        type = "box",
                                                        layout = "vertical",
                                                        contents = new List<object>()
                                                        {
                                                            new
                                                            {
                                                                type = "text",
                                                                text = statusEmo1
                                                            }
                                                        },
                                                        cornerRadius = "30px",
                                                        height = "20px",
                                                        width = "20px",
                                                        offsetStart = "7px"
                                                    },
                                                    new
                                                    {
                                                        type = "filler"
                                                    }
                                                },
                                                flex = 0,
                                                backgroundColor = "#848484",
                                                width = "30px",
                                                height = "30px",
                                                cornerRadius = "30px"
                                            },
                                            new
                                            {
                                                type = "text",
                                                text = status1,
                                                gravity = "center",
                                                flex = 1,
                                                size = "sm"
                                            }
                                        },
                                        spacing = "lg",
                                        cornerRadius = "30px",
                                        margin = "xl"
                                    },
                                    new
                                    {
                                        type = "box",
                                        layout = "horizontal",
                                        contents = new List<object>()
                                        {
                                            new
                                            {
                                                type = "box",
                                                layout = "baseline",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "text",
                                                        text = time1,
                                                        size = "xs",
                                                        color = "#8c8c8c",
                                                        align = "end"
                                                    }
                                                },
                                                flex = 2
                                            },
                                            new
                                            {
                                                type = "box",
                                                layout = "vertical",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "box",
                                                        layout = "horizontal",
                                                        contents = new List<object>()
                                                        {
                                                            new
                                                            {
                                                                type = "filler"
                                                            },
                                                            new
                                                            {
                                                                type = "box",
                                                                layout = "vertical",
                                                                contents = new List<object>()
                                                                {
                                                                    new
                                                                    {
                                                                        type = "filler"
                                                                    }
                                                                },
                                                                width = "2px",
                                                                backgroundColor = "#B7B7B7"
                                                            },
                                                            new
                                                            {
                                                                type = "filler"
                                                            }
                                                        },
                                                        flex = 1
                                                    }
                                                },
                                                width = "30px"
                                            },
                                            new
                                            {
                                                type = "text",
                                                text = locate1,
                                                gravity = "top",
                                                flex = 2,
                                                size = "xs",
                                                color = "#8c8c8c"
                                            }
                                        },
                                        spacing = "lg",
                                        height = "40px"
                                    },
                                    new
                                    {
                                        type = "box",
                                        layout = "horizontal",
                                        contents = new List<object>()
                                        {
                                            new
                                            {
                                                type = "text",
                                                text = mdy2,
                                                size = "sm",
                                                gravity = "center",
                                                align = "end"
                                            },
                                            new
                                            {
                                                type = "box",
                                                layout = "vertical",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "filler"
                                                    },
                                                    new
                                                    {
                                                        type = "box",
                                                        layout = "vertical",
                                                        contents = new List<object>()
                                                        {
                                                            new
                                                            {
                                                                type = "text",
                                                                text = statusEmo2
                                                            }
                                                        },
                                                        cornerRadius = "30px",
                                                        height = "20px",
                                                        width = "20px",
                                                        offsetStart = "7px"
                                                    },
                                                    new
                                                    {
                                                        type = "filler"
                                                    }
                                                },
                                                flex = 0,
                                                backgroundColor = "#A9D0F5",
                                                width = "30px",
                                                height = "30px",
                                                cornerRadius = "30px"
                                            },
                                            new
                                            {
                                                type = "text",
                                                text = status2,
                                                gravity = "center",
                                                flex = 1,
                                                size = "sm"
                                            }
                                        },
                                        spacing = "lg",
                                        cornerRadius = "30px",
                                        margin = "none"
                                    },
                                    new
                                    {
                                        type = "box",
                                        layout = "horizontal",
                                        contents = new List<object>()
                                        {
                                            new
                                            {
                                                type = "box",
                                                layout = "baseline",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "text",
                                                        text = time2,
                                                        size = "xs",
                                                        color = "#8c8c8c",
                                                        align = "end"
                                                    }
                                                },
                                                flex = 2
                                            },
                                            new
                                            {
                                                type = "box",
                                                layout = "vertical",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "box",
                                                        layout = "horizontal",
                                                        contents = new List<object>()
                                                        {
                                                            new
                                                            {
                                                                type = "filler"
                                                            },
                                                            new
                                                            {
                                                                type = "box",
                                                                layout = "vertical",
                                                                contents = new List<object>()
                                                                {
                                                                    new
                                                                    {
                                                                        type = "filler"
                                                                    }
                                                                },
                                                                width = "2px",
                                                                backgroundColor = "#B7B7B7"
                                                            },
                                                            new
                                                            {
                                                                type = "filler"
                                                            }
                                                        },
                                                        flex = 1
                                                    }
                                                },
                                                width = "30px"
                                            },
                                            new
                                            {
                                                type = "text",
                                                text = locate2,
                                                gravity = "top",
                                                flex = 2,
                                                size = "xs",
                                                color = "#8c8c8c"
                                            }
                                        },
                                        spacing = "lg",
                                        height = "40px"
                                    },
                                    new
                                    {
                                        type = "box",
                                        layout = "horizontal",
                                        contents = new List<object>()
                                        {
                                            new
                                            {
                                                type = "text",
                                                text = mdy3,
                                                size = "sm",
                                                gravity = "center",
                                                align = "end"
                                            },
                                            new
                                            {
                                                type = "box",
                                                layout = "vertical",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "filler"
                                                    },
                                                    new
                                                    {
                                                        type = "box",
                                                        layout = "vertical",
                                                        contents = new List<object>()
                                                        {
                                                            new
                                                            {
                                                                type = "text",
                                                                text = statusEmo3
                                                            }
                                                        },
                                                        cornerRadius = "30px",
                                                        height = "20px",
                                                        width = "20px",
                                                        offsetStart = "7px"
                                                    },
                                                    new
                                                    {
                                                        type = "filler"
                                                    }
                                                },
                                                flex = 0,
                                                backgroundColor = "#CEF6CE",
                                                width = "30px",
                                                height = "30px",
                                                cornerRadius = "30px"
                                            },
                                            new
                                            {
                                                type = "text",
                                                text = status3,
                                                gravity = "center",
                                                flex = 1,
                                                size = "sm"
                                            }
                                        },
                                        spacing = "lg",
                                        cornerRadius = "30px",
                                        margin = "none"
                                    },
                                    new
                                    {
                                        type = "box",
                                        layout = "horizontal",
                                        contents = new List<object>()
                                        {
                                            new
                                            {
                                                type = "box",
                                                layout = "baseline",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "text",
                                                        text = time3,
                                                        size = "xs",
                                                        color = "#8c8c8c",
                                                        align = "end"
                                                    }
                                                },
                                                flex = 2
                                            },
                                            new
                                            {
                                                type = "box",
                                                layout = "vertical",
                                                contents = new List<object>()
                                                {
                                                    new
                                                    {
                                                        type = "box",
                                                        layout = "horizontal",
                                                        contents = new List<object>()
                                                        {
                                                            new
                                                            {
                                                                type = "filler"
                                                            },
                                                            new
                                                            {
                                                                type = "box",
                                                                layout = "vertical",
                                                                contents = new List<object>()
                                                                {
                                                                    new
                                                                    {
                                                                        type = "filler"
                                                                    }
                                                                },
                                                                width = "2px"
                                                            },
                                                            new
                                                            {
                                                                type = "filler"
                                                            }
                                                        },
                                                        flex = 1
                                                    }
                                                },
                                                width = "30px"
                                            },
                                            new
                                            {
                                                type = "text",
                                                text = locate3,
                                                gravity = "top",
                                                flex = 2,
                                                size = "xs",
                                                color = "#8c8c8c"
                                            }
                                        },
                                        spacing = "lg",
                                        height = "20px"
                                    }
                                }
                            }
                        }
                    }
                }
            };
            return TrackMsg;
        }
    }
}

//    public class flexTrack 
//    {
//        public dynamic flexTrackMsg(string rpToken, string companyName, string jobNo, string mdy1, string statusEmo1, string status1, string time1, string locate1, string mdy2, string statusEmo2, string status2, string time2, string locate2, string mdy3, string statusEmo3, string status3, string time3, string locate3) 
//        {
//            var TrackMsg = new
//            {
//                replyToken = $"{rpToken}",
//                messages = new List<object>()
//                {
//                    new
//                    {
//                        type = "flex",
//                        altText = "Tracking Status",
//                        contents = new
//                        {
//                            type = "bubble",
//                            size = "giga",
//                            header = new
//                            {
//                                type = "box",
//                                layout = "horizontal",
//                                contents = new List<object>()
//                                {
//                                    new
//                                    {
//                                        type = "box",
//                                        layout = "vertical",
//                                        contents = new List<object>()
//                                        {
//                                            new
//                                            {
//                                                type = "text",
//                                                text = "บริษัท",
//                                                color = "#ffffff66",
//                                                size = "sm",
//                                                flex = 4,
//                                                weight = "regular"
//                                            },
//                                            new
//                                            {
//                                                type = "text",
//                                                text = companyName,
//                                                color = "#ffffff",
//                                                size = "md",
//                                                flex = 4,
//                                                weight = "bold"
//                                            }
//                                        }
//                                    },
//                                    new
//                                    {
//                                        type = "box",
//                                        layout = "vertical",
//                                        contents = new List<object>()
//                                        {
//                                            new
//                                            {
//                                                type = "text",
//                                                text = "เลขที่",
//                                                color = "#ffffff66",
//                                                size = "sm",
//                                                flex = 4,
//                                                weight = "regular"
//                                            },
//                                            new
//                                            {
//                                                type = "text",
//                                                text = jobNo,
//                                                color = "#ffffff",
//                                                size = "md",
//                                                flex = 4,
//                                                weight = "bold"
//                                            }
//                                        }
//                                    }
//                                },
//                                paddingAll = "20px",
//                                backgroundColor = "#0367D3",
//                                spacing = "md",
//                                paddingTop = "22px"
//                            },
//                            body = new
//                            {
//                                type = "box",
//                                layout = "vertical",
//                                contents = new List<object>()
//                                {
//                                    new
//                                    {
//                                        type = "box",
//                                        layout = "horizontal",
//                                        contents = new List<object>()
//                                        {
//                                            new
//                                            {
//                                                type = "text",
//                                                text = mdy1,
//                                                size = "sm",
//                                                gravity = "center",
//                                                align = "end"
//                                            },
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "vertical",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "filler"
//                                                    },
//                                                    new
//                                                    {
//                                                        type = "box",
//                                                        layout = "vertical",
//                                                        contents = new List<object>()
//                                                        {
//                                                            new
//                                                            {
//                                                                type = "text",
//                                                                text = statusEmo1
//                                                            }
//                                                        },
//                                                        cornerRadius = "30px",
//                                                        height = "20px",
//                                                        width = "20px",
//                                                        offsetStart = "7px"
//                                                    },
//                                                    new
//                                                    {
//                                                        type = "filler"
//                                                    }
//                                                },
//                                                flex = 0,
//                                                backgroundColor = "#848484",
//                                                width = "30px",
//                                                height = "30px",
//                                                cornerRadius = "30px"
//                                            },
//                                            new
//                                            {
//                                                type = "text",
//                                                text = status1,
//                                                gravity = "center",
//                                                flex = 1,
//                                                size = "sm"
//                                            }
//                                        },
//                                        spacing = "lg",
//                                        cornerRadius = "30px",
//                                        margin = "xl"
//                                    },
//                                    new
//                                    {
//                                        type = "box",
//                                        layout = "horizontal",
//                                        contents = new List<object>()
//                                        {
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "baseline",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "text",
//                                                        text = time1,
//                                                        size = "xs",
//                                                        color = "#8c8c8c",
//                                                        align = "end"
//                                                    }
//                                                },
//                                                flex = 2
//                                            },
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "vertical",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "box",
//                                                        layout = "horizontal",
//                                                        contents = new List<object>()
//                                                        {
//                                                            new
//                                                            {
//                                                                type = "filler"
//                                                            },
//                                                            new
//                                                            {
//                                                                type = "box",
//                                                                layout = "vertical",
//                                                                contents = new List<object>()
//                                                                {
//                                                                    new
//                                                                    {
//                                                                        type = "filler"
//                                                                    }
//                                                                },
//                                                                width = "2px",
//                                                                backgroundColor = "#B7B7B7"
//                                                            },
//                                                            new
//                                                            {
//                                                                type = "filler"
//                                                            }
//                                                        },
//                                                        flex = 1
//                                                    }
//                                                },
//                                                width = "30px"
//                                            },
//                                            new
//                                            {
//                                                type = "text",
//                                                text = locate1,
//                                                gravity = "top",
//                                                flex = 2,
//                                                size = "xs",
//                                                color = "#8c8c8c"
//                                            }
//                                        },
//                                        spacing = "lg",
//                                        height = "40px"
//                                    },
//                                    new
//                                    {
//                                        type = "box",
//                                        layout = "horizontal",
//                                        contents = new List<object>()
//                                        {
//                                            new
//                                            {
//                                                type = "text",
//                                                text = mdy2,
//                                                size = "sm",
//                                                gravity = "center",
//                                                align = "end"
//                                            },
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "vertical",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "filler"
//                                                    },
//                                                    new
//                                                    {
//                                                        type = "box",
//                                                        layout = "vertical",
//                                                        contents = new List<object>()
//                                                        {
//                                                            new
//                                                            {
//                                                                type = "text",
//                                                                text = statusEmo2
//                                                            }
//                                                        },
//                                                        cornerRadius = "30px",
//                                                        height = "20px",
//                                                        width = "20px",
//                                                        offsetStart = "7px"
//                                                    },
//                                                    new
//                                                    {
//                                                        type = "filler"
//                                                    }
//                                                },
//                                                flex = 0,
//                                                backgroundColor = "#A9D0F5",
//                                                width = "30px",
//                                                height = "30px",
//                                                cornerRadius = "30px"
//                                            },
//                                            new
//                                            {
//                                                type = "text",
//                                                text = status2,
//                                                gravity = "center",
//                                                flex = 1,
//                                                size = "sm"
//                                            }
//                                        },
//                                        spacing = "lg",
//                                        cornerRadius = "30px",
//                                        margin = "none"
//                                    },
//                                    new
//                                    {
//                                        type = "box",
//                                        layout = "horizontal",
//                                        contents = new List<object>()
//                                        {
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "baseline",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "text",
//                                                        text = time2,
//                                                        size = "xs",
//                                                        color = "#8c8c8c",
//                                                        align = "end"
//                                                    }
//                                                },
//                                                flex = 2
//                                            },
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "vertical",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "box",
//                                                        layout = "horizontal",
//                                                        contents = new List<object>()
//                                                        {
//                                                            new
//                                                            {
//                                                                type = "filler"
//                                                            },
//                                                            new
//                                                            {
//                                                                type = "box",
//                                                                layout = "vertical",
//                                                                contents = new List<object>()
//                                                                {
//                                                                    new
//                                                                    {
//                                                                        type = "filler"
//                                                                    }
//                                                                },
//                                                                width = "2px",
//                                                                backgroundColor = "#B7B7B7"
//                                                            },
//                                                            new
//                                                            {
//                                                                type = "filler"
//                                                            }
//                                                        },
//                                                        flex = 1
//                                                    }
//                                                },
//                                                width = "30px"
//                                            },
//                                            new
//                                            {
//                                                type = "text",
//                                                text = locate2,
//                                                gravity = "top",
//                                                flex = 2,
//                                                size = "xs",
//                                                color = "#8c8c8c"
//                                            }
//                                        },
//                                        spacing = "lg",
//                                        height = "40px"
//                                    },
//                                    new
//                                    {
//                                        type = "box",
//                                        layout = "horizontal",
//                                        contents = new List<object>()
//                                        {
//                                            new
//                                            {
//                                                type = "text",
//                                                text = mdy3,
//                                                size = "sm",
//                                                gravity = "center",
//                                                align = "end"
//                                            },
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "vertical",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "filler"
//                                                    },
//                                                    new
//                                                    {
//                                                        type = "box",
//                                                        layout = "vertical",
//                                                        contents = new List<object>()
//                                                        {
//                                                            new
//                                                            {
//                                                                type = "text",
//                                                                text = statusEmo3
//                                                            }
//                                                        },
//                                                        cornerRadius = "30px",
//                                                        height = "20px",
//                                                        width = "20px",
//                                                        offsetStart = "7px"
//                                                    },
//                                                    new
//                                                    {
//                                                        type = "filler"
//                                                    }
//                                                },
//                                                flex = 0,
//                                                backgroundColor = "#CEF6CE",
//                                                width = "30px",
//                                                height = "30px",
//                                                cornerRadius = "30px"
//                                            },
//                                            new
//                                            {
//                                                type = "text",
//                                                text = status3,
//                                                gravity = "center",
//                                                flex = 1,
//                                                size = "sm"
//                                            }
//                                        },
//                                        spacing = "lg",
//                                        cornerRadius = "30px",
//                                        margin = "none"
//                                    },
//                                    new
//                                    {
//                                        type = "box",
//                                        layout = "horizontal",
//                                        contents = new List<object>()
//                                        {
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "baseline",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "text",
//                                                        text = time3,
//                                                        size = "xs",
//                                                        color = "#8c8c8c",
//                                                        align = "end"
//                                                    }
//                                                },
//                                                flex = 2
//                                            },
//                                            new
//                                            {
//                                                type = "box",
//                                                layout = "vertical",
//                                                contents = new List<object>()
//                                                {
//                                                    new
//                                                    {
//                                                        type = "box",
//                                                        layout = "horizontal",
//                                                        contents = new List<object>()
//                                                        {
//                                                            new
//                                                            {
//                                                                type = "filler"
//                                                            },
//                                                            new
//                                                            {
//                                                                type = "box",
//                                                                layout = "vertical",
//                                                                contents = new List<object>()
//                                                                {
//                                                                    new
//                                                                    {
//                                                                        type = "filler"
//                                                                    }
//                                                                },
//                                                                width = "2px"
//                                                            },
//                                                            new
//                                                            {
//                                                                type = "filler"
//                                                            }
//                                                        },
//                                                        flex = 1
//                                                    }
//                                                },
//                                                width = "30px"
//                                            },
//                                            new
//                                            {
//                                                type = "text",
//                                                text = locate3,
//                                                gravity = "top",
//                                                flex = 2,
//                                                size = "xs",
//                                                color = "#8c8c8c"
//                                            }
//                                        },
//                                        spacing = "lg",
//                                        height = "20px"
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            };
//            return TrackMsg;
//        }
//    }
//}


//using System.Collections.Generic;
//namespace MyLineBot.EventHandlers
//{
//    public class replyTracking
//    {
//        public string replyToken { get; set; }
//        public List<flexMsgTrack> messages { get; set; }
//    }
//    public class flexMsgTrack 
//    {
//        public string type { get; set; }
//        public string altText { get; set; }
//        public contentFlexTrack contents { get; set; }
//    }
//    public class contentFlexTrack 
//    {
//        public string type { get; set; }
//        public string size { get; set; }
//        public headerTrack header { get; set; }
//        public bodyTrack body { get; set; }
//    }
//    public class headerTrack 
//    {
//        public string type { get; set; }
//        public string layout { get; set; }
//        public List<contentHeaderTrack1> contents { get; set; }
//        public string paddingAll { get; set; }
//        public string backgroundColor { get; set; }
//        public string spacing { get; set; }
//        public string paddingTop { get; set; }
//    }
//    public class contentHeaderTrack1 
//    {
//        public string type { get; set; }
//        public string layout { get; set; }
//        public List<contentOfcontentHeaderTrack> contents { get; set; }
//    }
//    public class contentOfcontentHeaderTrack 
//    {
//        public string type { get; set; }
//        public string text { get; set; }
//        public string color { get; set; }
//        public string size { get; set; }
//        public int flex { get; set; }
//        public string weight { get; set; }
//    }
//    public class bodyTrack 
//    {
//        public string type { get; set; }
//        public string layout { get; set; }
//        public List<contentBodyBoxTrack> contents { get; set; }
//    }
//    public class contentBodyBoxTrack 
//    {
//        public string type { get; set; }
//        public string layout { get; set; }
//        public List<contentOfcontentBodyBoxTrack> contents { get; set; }
//    }
//    public class contentOfcontentBodyBoxTrack 
//    {
//        public string type { get; set; }
//        public string text { get; set; }
//        public string size { get; set; }
//        public string gravity { get; set; }
//        public string align { get; set; }
//        public string layout { get; set; }
//        public List<contentInBodyBoxTrack> contents { get; set; }
//    }
//    public class contentInBodyBoxTrack 
//    {
//        public string type { get; set; }
//        public string layout { get; set; }
//    }
//}
