using SocialMedia.Core.Entities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task Add(T entities);

        Task Update(T entities);

        Task Delete(int id);
    }
}