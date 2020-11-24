using System;

namespace SocialMedia.Core.QueryFilters
{
    public class PostQueryFilters
    {
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
    }
}