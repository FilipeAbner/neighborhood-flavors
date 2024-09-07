class Menu
{
    public int Id { get; set; }
    public List<Item> Itens { get; set; }
    public List<Rating> Ratings { get; set; }
    public List<Comment> Comments { get; set; }
    public Double avgRating {get; set;}
}