namespace neighborhoodFlavors.Data;

 public class Menu
{
    public int Id { get; set; }
    public List<ItemMenu> ItemMenus { get; set; } = [];
    public List<Rating> Ratings { get; set; } = [];
    public List<Comment> Comments { get; set; } = [];
    public Double avgRating {get; set;} = 0;
    public int RestaurantId {get; set;}
}