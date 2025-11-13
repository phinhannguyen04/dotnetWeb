namespace dotnetWeb.Models;

public class PostTag
{
    public string PostId { get; set; } = string.Empty;
    public Post? Post { get; set; }

    public string TagId { get; set; } = string.Empty;
    public Tag? Tag { get; set; }
}