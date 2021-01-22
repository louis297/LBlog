using Backend.Services.BlogServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogService _service;

        public BlogController(IBlogService service)
        {
            _service = service;
        }

        [HttpGet("BlogTypes")]
        [Authorize("read:all_blogs")]
        public IActionResult GetBlogTypes()
        {
            return Ok(_service.GetBlogTypes());
        }

        [HttpGet]
        [Authorize("read:all_blogs")]
        public IActionResult GetBlogList()
        {
            return Ok("hello");
        }

        [HttpPost]
        [Authorize("add:blog")]
        public IActionResult AddBlog()
        {
            throw new NotImplementedException();
        }
    }
}
