using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using SocialMedia.Api.Responses;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityService _securityService;
        private readonly IMapper _mapper;

        public SecurityController(ISecurityService securityService, IMapper mapper)
        {
            _securityService = securityService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(SecurityDTO securityDto)
        {
            var security = _mapper.Map<Security>(securityDto);

            await _securityService.RegisterUser(security);
            var response = new ApiResponse<SecurityDTO>(securityDto);
            return Ok(response);
        }
    }
}