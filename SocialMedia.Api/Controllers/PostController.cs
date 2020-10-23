using Microsoft.AspNetCore.Mvc;

using SocialMedia.Infrastructure.Repositories;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPost()
        {
            var post = new PostRepository().GetPosts();
            return Ok(post);
        }
    }
}