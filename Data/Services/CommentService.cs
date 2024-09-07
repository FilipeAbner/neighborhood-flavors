namespace neighborhoodFlavors.Data;

class CommentService
{
    private AppDbContext dbContext;

    public CommentService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}