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

}