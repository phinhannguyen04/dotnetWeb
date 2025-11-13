using System.ComponentModel.DataAnnotations;
using NanoidDotNet;

namespace dotnetWeb.Models;

public class PostImage
{
    [Key]
    public string ImageId { get; set; } = Nanoid.Generate(size: 12);
    public string PostId { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string? Caption { get; set; }
    public bool IsMain { get; set; } = false;
    public int SortOrder { get; set; } = 0;

    public Post? Post { get; set; }
}