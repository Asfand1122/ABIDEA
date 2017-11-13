using ABIdea.DBManager;
using ABIdea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABIdea.Controllers
{
    public class BlogCategoryController : Controller
    {
        public BlogManager ShowBlogs;
        public BlogCategoryController()
        {
            ShowBlogs = new BlogManager();
        }
        // GET: Blog
        public ActionResult Index()
        {
            var BlogList = ShowBlogs.GetAllBlogs()
                                    .Select(x => new BlogModel.BlogList()
                                    {
                                        BlogCategory = x.Blog_Category.Category_Name,
                                        BlogDescription = x.Blog_Category.Catgeory_Description,
                                        BlogTitle = x.Blog_Category.Category_Title,
                                        BlogPicture = x.Blog_Category.Category_Background
                                    }).ToList();
            return View(BlogList);
        }
    }
}