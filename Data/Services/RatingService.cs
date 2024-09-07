namespace neighborhoodFlavors.Data;


public class RatingService {
    private AppDbContext dbContext;

    public RatingService(AppDbContext dbContext) {
        this.dbContext = dbContext;
    }


}