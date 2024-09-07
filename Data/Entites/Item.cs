namespace neighborhoodFlavors.Data;

public class Item
{
    public int Id { get; set; }
    public String ItemName { get; set; }

    public List<ItemMenu> ItemMenus { get; set; }
}