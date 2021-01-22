using Backend.Services;
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
    public class IdentityController : ControllerBase
    {
        //private IIdentityService _service;

        //public IdentityController(IIdentityService service)
        //{
        //    _service = service;
        //}

        [HttpGet("login")]
        public void Login()
        {

        }
    }
}
