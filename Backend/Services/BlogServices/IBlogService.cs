using Backend.Models.BlogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.BlogServices
{
    public interface IBlogService
    {
        public IEnumerable<BlogType> GetBlogTypes();
        public Blog AddBlog(Blog blog);
        public Blog ModifyBlog(Blog blog);
        public Blog DeleteBlog(Blog blog);
        public Blog GetBlogById(int blogID);
        public IEnumerable<Blog> GetBlogByRange(int startID = 1, int amount = 10, bool active = true);
        public IEnumerable<Blog> GetBlogByTimeRange(DateTime startTime, DateTime endTime, bool active = true);
        //public IEnumerable<Blog> GetBlogByAuthor(LBlogUser author);
        //public IEnumerable<Blog> GetBlogByAuthorAndRange(LBlogUser author, int startID = 1, int endID = -1);
        //public IEnumerable<Blog> GetBlogByAuthorAndTimeRange(LBlogUser author);
    }
}
