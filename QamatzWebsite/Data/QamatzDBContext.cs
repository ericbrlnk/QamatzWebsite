using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.Extensions.Options;
using QamatzWebsite.Models;

namespace QamatzWebsite.Data
{
    public class QamatzDBContext : DbContext
    {
        public QamatzDBContext(DbContextOptions<QamatzDBContext> options) : base(options)
        {
        }

        // Database results
        // Post
        public DbSet<Post>? Post { get; set; }
        
        // Tag
        public DbSet<Tag>? Tag { get; set; }
        
        // PostTag
        public DbSet<PostTag>? PostTag { get; set; }

        // User results
        public DbSet<User>? User { get; set; }
    }
}
