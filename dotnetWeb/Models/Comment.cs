using System.ComponentModel.DataAnnotations;
using NanoidDotNet;

namespace dotnetWeb.Models;

public class Comment
{
    [Key]
    public string CommentId { get; set; } = Nanoid.Generate(size: 12);
    public string PostId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsApproved { get; set; } = true;

    public Post? Post { get; set; }
}