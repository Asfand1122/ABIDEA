using ABIdea.DBManager;
using ABIdea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABIdea.Controllers
{
    public class AllBlogController : Controller
    {
        public AllBlogManager topList = new AllBlogManager();
        // GET: AllBlog
        public ActionResult Index()
        {
            
        List<AllBlogModel.BlogList> BlogList = topList.GetAllBlogs()
                                                    .Select(x => new AllBlogModel.BlogList()
                                                    {
                                                        BlogCategory = x.Blog_Category.Category_Name,
                                                        BlogWriter = x.Blog_Author.Auth_Credentials.F_Name + " " + x.Blog_Author.Auth_Credentials.M_Name + " " + x.Blog_Author.Auth_Credentials.L_Name,
                                                        BlogDate = x.BlogDate,
                                                        BlogDescription = x.BlogDescription,
                                                        BlogPicture = x.BlogPicture,
                                                        BlogTitle = x.BlogTitle,
                                                        BlogID = x.BlogID

                                                    }).ToList();
            return View(BlogList);
        }
    }
}
