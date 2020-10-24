using Microsoft.AspNetCore.Mvc;

using SocialMedia.Core.Interfaces;

using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            var post = await _postRepository.GetPosts();
            return Ok(post);
        }
    }
}