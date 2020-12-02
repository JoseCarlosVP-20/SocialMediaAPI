using Microsoft.EntityFrameworkCore;

using SocialMedia.Core.Entities;

using System.Reflection;

namespace SocialMedia.Infrastructure.Data
{
    public partial class SocialmediaContext : DbContext
    {
        public SocialmediaContext()
        {
        }

        public SocialmediaContext(DbContextOptions<SocialmediaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Security> Securities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Se referencias las clases de configuracion de cada Entidad de base de datos
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}