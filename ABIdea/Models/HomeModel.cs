using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABIdea.Models
{
    public class HomeModel
    {
        //Top Blogger Variable
        public class Blogger
        {
            //Get Top Bloggers
            public string topBlogger_ImageURL { get; set; }
            public string topBlogger_Name { get; set; }
            public string topBlogger_hobbies { get; set; }
            public string topBlogger_SocialLink { get; set; }
        }

        public class BlogsCategory
        {
            //Get All Blogs Category
            public string BlogCategory { get; set; }
            public string BlogTitle { get; set; }
            public string BlogDescription { get; set; }
            public string BlogImage { get; set; }
        }
        public class RecentBlogs
        {
            //Get All Recent Blogs
            public string BlogTitle { get; set; }
            public string BlogCategory { get; set; }
            public string BlogDescription { get; set; }
            public string BlogWriter { get; set; }
            public string BlogPicture { get; set; }

            [DataType(DataType.Date)]
            public DateTime BlogDate { get; set; }
            public int BlogID { get; set; }
        }
        public class GetHomeData
        {
            public List<Blogger> GetTopBlogger { get; set; }
            public List<BlogsCategory> GetAllBlogsCategory { get; set; }
            public List<RecentBlogs> GetAllBlogs { get; set; }

        }



    }
}