using Microsoft.EntityFrameworkCore;
namespace neighborhoodFlavors.Data;

public class AppDbContext: DbContext
{
    public DbSet<Comment> Comment { get; set; }
}