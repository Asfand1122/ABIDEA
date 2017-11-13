using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABIdea.Models
{
    public class ViewBlog
    {
        public class BlogList
        {
            public string BlogCategory { get; set; }
            public string BlogTitle { get; set; }
            public string BlogDescription { get; set; }
            public string BlogWriter { get; set; }
            public string BlogPicture { get; set; }

            [DataType(DataType.Date)]
            public DateTime BlogDate { get; set; }
            public int? BlogID { get; set; }
        }
        public class GetHomeData
        {
            public List<BlogList> GetBlog { get; set; }
        }
    }
}