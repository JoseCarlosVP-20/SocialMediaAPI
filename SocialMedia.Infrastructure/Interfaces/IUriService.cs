using SocialMedia.Core.QueryFilters;

using System;

namespace SocialMedia.Infrastructure.Interfaces
{
    public interface IUriService
    {
        Uri GetPostpaginationUri(PostQueryFilters filters, string actionUri);
    }
}