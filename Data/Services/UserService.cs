namespace neighborhoodFlavors.Data;


public class UserService {
    private AppDbContext dbContext;

    public UserService(AppDbContext dbContext) {
        this.dbContext = dbContext;
    }


}