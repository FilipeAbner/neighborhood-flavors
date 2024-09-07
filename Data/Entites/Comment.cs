namespace neighborhoodFlavors.Data;

public class Comment
{
    public int Id { get; set; }
    public String CommentText { get; set; }
    public DateTime PublishDate { get; set; }
    public int MenuId { get; set; }
    public int UserId { get; set; }
}