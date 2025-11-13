using System.ComponentModel.DataAnnotations;
using NanoidDotNet;

namespace dotnetWeb.Models;

public class Category
{
    [Key]
    public string CategoryId { get; set; } = Nanoid.Generate(size: 12);
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Slug { get; set; }

    public ICollection<Post> Posts { get; set; } = new List<Post>();
}