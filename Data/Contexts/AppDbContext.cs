using Microsoft.EntityFrameworkCore;
namespace neighborhoodFlavors.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {

    }
    public DbSet<Comment> Comment { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<Rating> Rating { get; set; }
    public DbSet<Restaurant> Restaurant { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)    {
        modelBuilder.Entity<User>().HasData(RetornaUser());
        modelBuilder.Entity<Comment>().HasData(RetornaComment());
        modelBuilder.Entity<Item>().HasData(RetornaItem());
        modelBuilder.Entity<Rating>().HasData(RetornaRating());
        modelBuilder.Entity<Menu>().HasData(RetornaMenu());
        modelBuilder.Entity<Restaurant>().HasData(RetornaRestaurant());

        base.OnModelCreating(modelBuilder);
    }
    private List<Comment> RetornaComment()
    {
        return new List<Comment>
        {
            new Comment { Id = 1, CommentText = "Comida muito boa!", PublishDate = DateTime.Now },
            new Comment { Id = 2, CommentText = "Atendimento excelente", PublishDate = DateTime.Now},
            new Comment { Id = 3, CommentText = "Pouca variedade de pratos", PublishDate = DateTime.Now},
            new Comment { Id = 4, CommentText = "Recomendo o restaurante", PublishDate = DateTime.Now}
        };
    }

    private List<Item> RetornaItem()
    {
        return new List<Item>
        {
            new Item { Id = 1, ItemName = "Carne bovina" },
            new Item { Id = 2, ItemName = "Carne Suina" },
            new Item { Id = 3, ItemName = "Couve de Flor" },
            new Item { Id = 4, ItemName = "Arroz" }
        };
        }
    private List<Menu> RetornaMenu()
    {
        return new List<Menu>
        {
            new Menu 
            { 
                Id = 1, 
                avgRating = 4.5, 
                Itens = new List<Item>
                {
                    new Item { Id = 1, ItemName = "Carne bovina" },
                    new Item { Id = 3, ItemName = "Couve de Flor" },
                },
                Ratings = new List<Rating>
                {
                    new Rating { Id = 1, Score = 5 },
                    new Rating { Id = 2, Score = 4 }
                },
                Comments = new List<Comment>
                {
                    new Comment { Id = 1, CommentText = "Comida muito boa!", PublishDate = DateTime.Now },
                    new Comment { Id = 3, CommentText = "Pouca variedade de pratos", PublishDate = DateTime.Now }
                    
                }
            },
            new Menu 
            { 
                Id = 2, 
                avgRating = 3.8, 
                Itens = new List<Item>
                {
                    new Item { Id = 2, ItemName = "Carne Suina" },
                    new Item { Id = 4, ItemName = "Arroz" }
                },
                Ratings = new List<Rating>
                {
                    new Rating { Id = 3, Score = 3 }
                },
                Comments = new List<Comment>
                {
                    new Comment { Id = 2, CommentText = "Atendimento excelente", PublishDate = DateTime.Now }
                }
            }
        };
    }


    private List<Rating> RetornaRating()
    {
        return new List<Rating>
        {
            new Rating { Id = 1, Score = 5 },
            new Rating { Id = 2, Score = 4 },
            new Rating { Id = 3, Score = 3 },
            new Rating { Id = 4, Score = 5 }
        };
    }

    private List<Restaurant> RetornaRestaurant()
    {
        return new List<Restaurant>
        {
            new Restaurant 
            { 
                Id = 1, 
                Name = "Cozinharte", 
                Menus = new List<Menu>
                {
                    new Menu { Id = 1, avgRating = 4.5 },  // Menus associados ao restaurante "Cozinharte"
                    new Menu { Id = 3, avgRating = 4.0 }
                }
            },
            new Restaurant 
            { 
                Id = 2, 
                Name = "Suzy", 
                Menus = new List<Menu>
                {
                    new Menu { Id = 2, avgRating = 4.8 },  // Menus associados ao restaurante "Suzy"
                    new Menu { Id = 4, avgRating = 4.3 }
                }
            }
        };
    }

    private List<User> RetornaUser()
    {
        return new List<User>
        {
            new User { Id = 1, Name = "Suzy", Email = "suzy@gmail.com", Password = "senha123" },
            new User { Id = 2, Name = "Cozinharte", Email = "cozinharte@gmail.com", Password = "senha456" },
        };
    }
}