using Microsoft.EntityFrameworkCore;
namespace neighborhoodFlavors.Data;

public class CommentService
{
    private AppDbContext dbContext;

    public CommentService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Comment>> GetCommentsAsync()
    {
        return await dbContext.Comment.ToListAsync();
    }

    public async Task<Comment> AddCommentAsync(Comment comment)
    {
        try
        {
            dbContext.Comment.Add(comment);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return comment;
    }

    public async Task<Comment> UpdateCommentAsync(Comment comment) {
        try
        {
            var commentExist = dbContext.Comment.FirstOrDefault(c => c.Id == comment.Id);
            if(commentExist != null) {
                dbContext.Comment.Update(comment);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return comment;
    }

    public async Task DeleteCommentAsync(Comment comment)
    {
        try
        {
            dbContext.Comment.Remove(comment);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }   


}