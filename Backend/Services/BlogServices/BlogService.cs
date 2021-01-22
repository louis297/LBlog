using Backend.Models;
using Backend.Models.BlogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        private LBlogDbContext _context;
        public BlogService(LBlogDbContext context)
        {
            _context = context;
        }
        public Blog AddBlog(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return blog;
        }

        public Blog DeleteBlog(Blog blog)
        {
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return blog;
        }

        public Blog GetBlogById(int blogID)
        {
            //IQueryable<Blog> blogs = GetAllBlogs();
            Blog blog = _context.Blogs
                .Where(b => b.BlogID == blogID)
                .FirstOrDefault();
            return blog;
        }

        public IEnumerable<Blog> GetBlogByRange(int startID = 1, int amount = 10, bool active = true)
        {
            IEnumerable<Blog> blogs = _context.Blogs
                .Where(b => b.BlogID > startID)
                .Where(b => b.Active == active)
                .OrderBy(b => b.BlogID)
                .Take(amount);

            return blogs;
        }

        public IEnumerable<Blog> GetBlogByTimeRange(DateTime startTime, DateTime endTime, bool active = true)
        {
            throw new NotImplementedException();
        }

        public Blog ModifyBlog(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return blog;
        }

        private IQueryable<Blog> GetAllBlogs()
        {
            //if (author == null)
            //{
                return _context.Blogs;
            //}
            //else
            //{
            //    return _context.Blogs.Where(b => b.Author == author);
            //}
        }

        private bool CheckUser(Blog blog)
        {
            // Check if logged in

            // Check if current user is the author

            // Check if current user has authorisation

            return true;
        }

        public IEnumerable<BlogType> GetBlogTypes()
        {
            return _context.BlogTypes.ToList();
        }
    }
}
