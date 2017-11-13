using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABIdea.DBManager
{
    public class BlogManager
    {
        ABIDEAEntities dbEntitites;

        public BlogManager()
        {
            dbEntitites = new ABIDEAEntities();
        }
        public IEnumerable<Blog> GetAllBlogs()
        {
            return dbEntitites.Blogs.ToList();
        }
    }
}