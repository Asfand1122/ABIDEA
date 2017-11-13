using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABIdea.DBManager
{
    public class HomeManager
    {
        ABIDEAEntities dbEntitites;

        public HomeManager()
        {
            dbEntitites = new ABIDEAEntities();
        }

        public IEnumerable<Blog_Author> GetTopBlogger()
        {
            return dbEntitites.Blog_Author.ToList();
        }
        public IEnumerable<Blog_Category> GetAllBlogsCategory()
        {
            return dbEntitites.Blog_Category.ToList();
        }
        public IEnumerable<Blog> GetAllBlogs()
        {
            return dbEntitites.Blogs.ToList();
        }
    }
}