using dotnetWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetWeb.Data;

public class BlogyContext : DbContext
{
    public BlogyContext(DbContextOptions<BlogyContext> options) : base(options) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<PostImage> PostImages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Bảng trung gian PostTags (khóa chính kép)
        modelBuilder.Entity<PostTag>()
            .HasKey(pt => new { pt.PostId, pt.TagId });

        // Cấu hình khóa chính string tự sinh (không tự động tăng)
        modelBuilder.Entity<Post>().Property(p => p.PostId).ValueGeneratedNever();
        modelBuilder.Entity<Author>().Property(a => a.AuthorId).ValueGeneratedNever();
        modelBuilder.Entity<Category>().Property(c => c.CategoryId).ValueGeneratedNever();
        modelBuilder.Entity<Tag>().Property(t => t.TagId).ValueGeneratedNever();
        modelBuilder.Entity<Comment>().Property(c => c.CommentId).ValueGeneratedNever();
        modelBuilder.Entity<PostImage>().Property(i => i.ImageId).ValueGeneratedNever();
    }
}