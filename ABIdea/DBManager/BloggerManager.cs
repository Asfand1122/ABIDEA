using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABIdea.DBManager
{
    public class BloggerManager
    {
        ABIDEAEntities dbEntitites;

        public BloggerManager()
        {
            dbEntitites = new ABIDEAEntities();
        }

        public IEnumerable<Blog_Author> GetTopBlogger()
        {
            return dbEntitites.Blog_Author.ToList();
        }
    }
}