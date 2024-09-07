namespace neighborhoodFlavors.Data;


public class RestaurantService {
    private AppDbContext dbContext;

    public RestaurantService(AppDbContext dbContext) {
        this.dbContext = dbContext;
    }


}