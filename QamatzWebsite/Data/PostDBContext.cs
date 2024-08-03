using Microsoft.EntityFrameworkCore;
using QamatzWebsite.Models;

namespace QamatzWebsite.Data
{
    public class PostDBContext : DbContext
    {

        public PostDBContext(DbContextOptions<PostDBContext> options) : base(options)
        {
        }

        // Database results
        // Post
        public DbSet<Post>? Post { get; set; }

        // Tag
        public DbSet<Tag>? Tag { get; set; }

        // PostTag
        public DbSet<PostTag>? PostTag { get; set; }
    }
}
