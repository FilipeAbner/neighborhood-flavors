namespace neighborhoodFlavors.Data;

public class ItemMenu {
    public int Id { get; set; } 
    public int ItemId { get; set; }
    public Item ? Item { get; set; }
    public int MenuId { get; set; }
    public Menu ? Menu { get; set; }
}