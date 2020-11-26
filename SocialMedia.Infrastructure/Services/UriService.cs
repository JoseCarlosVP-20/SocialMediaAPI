using SocialMedia.Core.QueryFilters;
using SocialMedia.Infrastructure.Interfaces;

using System;

namespace SocialMedia.Infrastructure.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetPostpaginationUri(PostQueryFilters filters, string actionUri)
        {
            string baseUrl = $"{_baseUri}{actionUri}";
            return new Uri(baseUrl);
        }
    }
}