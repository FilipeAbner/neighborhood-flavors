namespace neighborhoodFlavors.Data;


public class MenuService {
    private AppDbContext dbContext;

    public MenuService(AppDbContext dbContext) {
        this.dbContext = dbContext;
    }


}