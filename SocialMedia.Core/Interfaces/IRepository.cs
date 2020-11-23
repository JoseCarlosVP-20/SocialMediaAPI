﻿using SocialMedia.Core.Entities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        Task<T> GetById(int id);

        Task Add(T entities);

        void Update(T entities);

        Task Delete(int id);
    }
}