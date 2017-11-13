using ABIdea.DBManager;
using ABIdea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABIdea.Controllers
{
    public class BloggerController : Controller
    {
        public BloggerManager topList;

        public BloggerController()
        {
            topList = new BloggerManager();
        }
        // GET: Blogger
        public ActionResult Index()
        {
            List<BloggerModel.Blogger> TopBloggerList = topList.GetTopBlogger()
                                           .Select(x => new BloggerModel.Blogger()
                                           {
                                               topBlogger_Name = x.Auth_Credentials.F_Name + " " + x.Auth_Credentials.M_Name + " " + x.Auth_Credentials.L_Name,
                                               topBlogger_SocialLink = x.Auth_Credentials.FB_SocialLink,
                                               topBlogger_hobbies = x.Auth_Description.Substring(0,200) + "...",
                                               topBlogger_ImageURL = x.Picture
                                           }).ToList();
            return View(TopBloggerList);
        }
    }
}