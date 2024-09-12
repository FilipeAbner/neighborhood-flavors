namespace neighborhoodFlavors.Data;

public class Menu
{
    public int Id { get; set; }
    public List<ItemMenu> ItemMenus { get; set; } = new List<ItemMenu>();
    public List<Rating> Ratings { get; set; } = new List<Rating>();
    public List<Comment> Comments { get; set; } = new List<Comment>();
    public Double avgRating {get; set;} = 0;
    public int RestaurantId {get; set;}
}