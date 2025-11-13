using System.ComponentModel.DataAnnotations;
using NanoidDotNet;

namespace dotnetWeb.Models;

public class Tag
{
    [Key]
    public string TagId { get; set; } = Nanoid.Generate(size: 12);
    public string Name { get; set; } = string.Empty;
    public string? Slug { get; set; }

    public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
}