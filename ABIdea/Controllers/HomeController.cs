using ABIdea.DBManager;
using ABIdea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABIdea.Controllers
{

    public class HomeController : Controller
    {
        public HomeManager topList;
        ABIDEAEntities dbEntitites = new ABIDEAEntities();
        public HomeController()
        {
            topList = new HomeManager();
        }

        public ActionResult Index()
        {
            List<HomeModel.Blogger> TopBloggerList = topList.GetTopBlogger()
                                           .Select(x => new HomeModel.Blogger()
                                           {
                                               topBlogger_Name = x.Auth_Credentials.F_Name + " " + x.Auth_Credentials.M_Name + " " + x.Auth_Credentials.L_Name,
                                               topBlogger_SocialLink = x.Auth_Credentials.FB_SocialLink,
                                               topBlogger_hobbies = x.Auth_Description.Substring(0, 200) + "...",
                                               topBlogger_ImageURL = x.Picture
                                           }).Take(4).ToList();

            List<HomeModel.BlogsCategory> BloggerList = topList.GetAllBlogsCategory()
                                                .Select(x => new HomeModel.BlogsCategory()
                                                {
                                                    BlogCategory = x.Category_Name,
                                                    BlogDescription = x.Catgeory_Description.Substring(0,50),
                                                    BlogTitle = x.Category_Title,
                                                    BlogImage = x.Category_Background
                                                }).Take(6).ToList();

            List<HomeModel.RecentBlogs> BlogList = topList.GetAllBlogs()
                                                    .Select(x => new HomeModel.RecentBlogs()
                                                    {
                                                        BlogCategory = x.Blog_Category.Category_Name,
                                                        BlogWriter = x.Blog_Author.Auth_Credentials.F_Name + " " + x.Blog_Author.Auth_Credentials.M_Name + " " + x.Blog_Author.Auth_Credentials.L_Name,
                                                        BlogDate = x.BlogDate,
                                                        BlogDescription = x.BlogDescription,
                                                        BlogPicture=x.BlogPicture,
                                                        BlogTitle = x.BlogTitle,
                                                        BlogID = x.BlogID

                                                    }).Take(6).ToList();

            HomeModel.GetHomeData HomeData = new HomeModel.GetHomeData();
            HomeData.GetTopBlogger = TopBloggerList;
            HomeData.GetAllBlogsCategory = BloggerList;
            HomeData.GetAllBlogs = BlogList;

            return View(HomeData);
        }

        public void GetResult(int BlogID)
        {
            var id = dbEntitites.Blogs.Find(BlogID).BlogID;
        }

    }
}