namespace neighborhoodFlavors.Data;
public class Restaurant
{
    public int Id { get; set; }
    public String? Name { get; set; }
    public List<Menu> Menus { get; set; } = new List<Menu>();
    public int UserId { get; set; }
}