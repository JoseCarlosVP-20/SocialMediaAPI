using Microsoft.EntityFrameworkCore;

using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;

using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class SecurityRepository : BaseRepository<Security>, ISecurityRepository
    {
        public SecurityRepository(SocialmediaContext context) : base(context)
        {
        }

        public async Task<Security> GetLoginbyCredentials(UserLogin userLogin)
        {
            return await _entities.FirstOrDefaultAsync(u => u.User == userLogin.User);
        }
    }
}