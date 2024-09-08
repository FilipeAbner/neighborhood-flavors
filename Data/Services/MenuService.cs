using Microsoft.EntityFrameworkCore;
namespace neighborhoodFlavors.Data;

public class MenuService
{
    private AppDbContext dbContext;

    public MenuService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Menu>> GetAllMenusAsync()
    {
        return await dbContext.Menu
            .Include(m => m.ItemMenus)     
                .ThenInclude(im => im.Item)
            .Include(m => m.Ratings)
            .Include(m => m.Comments)  
            .ToListAsync();
    }

    public async Task<List<Menu>> GetMenusByRestaurantIdAsync(int restaurantId)
    {
        return await dbContext.Menu
            .Where(m => m.RestaurantId == restaurantId)
            .Include(m => m.ItemMenus)     
                .ThenInclude(im => im.Item)
            .Include(m => m.Ratings)
            .Include(m => m.Comments)  
            .ToListAsync();
    }

    public async Task<Menu> AddMenuAsync(Menu menu)
    {
        try
        {
            dbContext.Menu.Add(menu);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return menu;
    }

    public async Task<Menu> UpdateMenuAsync(Menu menu)
    {
        try
        {
            var MenuExist = dbContext.Menu.FirstOrDefault(m => m.Id == menu.Id);
            if (MenuExist != null)
            {
                dbContext.Menu.Update(menu);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return menu;
    }

    public async Task DeleteMenuAsync(Menu menu)
    {
        try
        {
            dbContext.Menu.Remove(menu);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

}