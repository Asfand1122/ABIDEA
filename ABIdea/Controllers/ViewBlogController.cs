using ABIdea.DBManager;
using ABIdea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABIdea.Controllers
{
    public class ViewBlogController : Controller
    {
        // GET: ViewBlog
        public ViewBlogManager ShowBlogs;
        public ViewBlogController()
        {
            ShowBlogs = new ViewBlogManager();
        }
        // GET: Blog
        public ActionResult Index(int? BlogId)
        {
            var BlogList = ShowBlogs.GetBlog(BlogId);
            return View(ShowBlogs.GetBlog(BlogId));
        }

        public ActionResult ViewBlogPost(int? BlogId)
        {
            return View();
        }
    }
}