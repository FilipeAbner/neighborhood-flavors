namespace neighborhoodFlavors.Data;


public class ItemService {
    private AppDbContext dbContext;

    public ItemService(AppDbContext dbContext) {
        this.dbContext = dbContext;
    }


}