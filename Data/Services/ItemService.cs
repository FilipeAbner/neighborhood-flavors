namespace neighborhoodFlavors.Data;


public class ItemService {
    private AppDbContext dbContext;

    public ItemService(AppDbContext dbContext) {
        this.dbContext = dbContext;
    }
    
    public async Task<List<Item>> GetItemsAsync()
    {
        return await dbContext.Item.ToListAsync();
    }

    public async Task<Item> AddItemAsync(Item item)
    {
        try
        {
            dbContext.Item.Add(item);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return item;
    }

    public async Task<Item> UpdateItemAsync(Item item) {
        try
        {
            var ItemExist = dbContext.Item.FirstOrDefault(i => i.Id == item.Id);
            if(ItemExist != null) {
                dbContext.Item.Update(item);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return item;
    }

    public async Task DeleteItemAsync(Item item)
    {
        try
        {
            dbContext.Item.Remove(item);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }


}