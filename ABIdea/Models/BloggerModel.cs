using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABIdea.Models
{
    public class BloggerModel
    {
        public class Blogger
        {
            //Get Top Bloggers
            public string topBlogger_ImageURL { get; set; }
            public string topBlogger_Name { get; set; }
            public string topBlogger_hobbies { get; set; }
            public string topBlogger_SocialLink { get; set; }
        }

        public class GetHomeData
        {
            public List<Blogger> GetTopBlogger { get; set; }
        }
    }
}