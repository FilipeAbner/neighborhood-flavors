using Microsoft.EntityFrameworkCore;
namespace neighborhoodFlavors.Data;

public class RestaurantService
{
    private AppDbContext dbContext;

    public RestaurantService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Restaurant>> GetAllRestaurantsAsync()
    {
        return await dbContext.Restaurant
        .Include(r => r.Menus)
            .ThenInclude(m => m.ItemMenus)
                .ThenInclude(im => im.Item)
        .Include(r => r.Menus)
            .ThenInclude(m => m.Ratings)
        .Include(r => r.Menus)
            .ThenInclude(m => m.Comments)
        .ToListAsync();
    }

    public async Task<Restaurant> AddRestaurantAsync(Restaurant restaurant)
    {
        try
        {
            dbContext.Restaurant.Add(restaurant);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return restaurant;
    }

    public async Task<Restaurant> UpdateRestaurantAsync(Restaurant restaurant)
    {
        try
        {
            var RestaurantExist = dbContext.Restaurant.FirstOrDefault(r => r.Id == restaurant.Id);
            if (RestaurantExist != null)
            {
                dbContext.Restaurant.Update(restaurant);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return restaurant;
    }

    public async Task DeleteRestaurantAsync(Restaurant restaurant)
    {
        try
        {
            dbContext.Restaurant.Remove(restaurant);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<Restaurant?> GetRestaurantByUserIdAsync(int userId)
    {
        return await dbContext.Restaurant
            .Where(r => r.UserId == userId)
            .FirstOrDefaultAsync();
    }
}