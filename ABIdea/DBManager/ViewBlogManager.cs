using ABIdea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABIdea.DBManager
{
    public class ViewBlogManager
    {
        ABIDEAEntities dbEntitites;
        HomeManager topList = new HomeManager();


        public ViewBlogManager()
        {
            dbEntitites = new ABIDEAEntities();
        }
        public ABIdea.Models.ViewBlog.BlogList GetBlog(int? Id)
        {

            return topList.GetAllBlogs()
                                .Select(x => new ABIdea.Models.ViewBlog.BlogList()
                                {
                                    BlogCategory = x.Blog_Category.Category_Name,
                                    BlogWriter = x.Blog_Author.Auth_Credentials.F_Name + " " + x.Blog_Author.Auth_Credentials.M_Name + " " + x.Blog_Author.Auth_Credentials.L_Name,
                                    BlogDate = x.BlogDate,
                                    BlogDescription = x.BlogDescription,
                                    BlogPicture = x.BlogPicture,
                                    BlogTitle = x.BlogTitle,
                                    BlogID = x.BlogID
                                }).FirstOrDefault(x => x.BlogID == Id);
        }
    }
}