namespace neighborhoodFlavors.Data;

public class Rating
{
    public int Id { get; set; }
    public int Score { get; set; }
    public int MenuId { get; set; }
    public int UserId { get; set; }
    public User ? User { get; set; }
}