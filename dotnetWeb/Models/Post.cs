using System.ComponentModel.DataAnnotations;
using NanoidDotNet;

namespace dotnetWeb.Models;

public class Post
{
    [Key]
    public string PostId { get; set; } = Nanoid.Generate(size: 12);

    public string AuthorId { get; set; } = string.Empty;
    public string CategoryId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Slug { get; set; }
    public string? Content { get; set; }
    public string? ThumbnailUrl { get; set; }
    public DateTime PublishedDate { get; set; } = DateTime.Now;
    public bool IsFeatured { get; set; } = false;
    public int ViewCount { get; set; } = 0;

    public Author? Author { get; set; }
    public Category? Category { get; set; }
    public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<PostImage> Images { get; set; } = new List<PostImage>();
}