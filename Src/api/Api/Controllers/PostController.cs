using System;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostBusiness _postBusiness;

        public PostController(IPostBusiness postBusiness)
        {
            _postBusiness = postBusiness;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Post post)
        {
            try
            {
                await _postBusiness.CreatePost(post);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _postBusiness.GetAll());
        }
    }
}