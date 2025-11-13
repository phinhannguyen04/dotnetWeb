using System.ComponentModel.DataAnnotations;
using NanoidDotNet;

namespace dotnetWeb.Models;


public class Author
{
    [Key]
    public string AuthorId { get; set; } = Nanoid.Generate(size: 12);
    public string Name { get; set; } = string.Empty;
    public string? Bio { get; set; }
    public string? AvatarUrl { get; set; }
    public string? Email { get; set; }

    public ICollection<Post> Posts { get; set; } = new List<Post>();
}