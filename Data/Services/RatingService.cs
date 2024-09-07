namespace neighborhoodFlavors.Data;


public class RatingService {
    private AppDbContext dbContext;

    public RatingService(AppDbContext dbContext) {
        this.dbContext = dbContext;
    }

    public async Task<List<Rating>> GetRatingsAsync()
    {
        return await dbContext.Rating.ToListAsync();
    }

    public async Task<Rating> AddRatingAsync(Rating rating)
    {
        try
        {
            dbContext.Rating.Add(rating);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return rating;
    }

    public async Task<Rating> UpdateRatingAsync(Rating rating) {
        try
        {
            var RatingExist = dbContext.Rating.FirstOrDefault(r => r.Id == rating.Id);
            if(RatingExist != null) {
                dbContext.Rating.Update(rating);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return rating;
    }

    public async Task DeleteRatingAsync(Rating rating)
    {
        try
        {
            dbContext.Rating.Remove(rating);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

}