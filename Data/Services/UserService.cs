using Microsoft.EntityFrameworkCore;
namespace neighborhoodFlavors.Data;

public class UserService
{
    private AppDbContext dbContext;

    public UserService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<User>> GetUsersAsync()
    {
        return await dbContext.User.ToListAsync();
    }

    public async Task<User> AddUserAsync(User user)
    {
        try
        {
            dbContext.User.Add(user);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return user;
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        try
        {
            var UserExist = dbContext.User.FirstOrDefault(u => u.Id == user.Id);
            if (UserExist != null)
            {
                dbContext.User.Update(user);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return user;
    }

    public async Task DeleteUserAsync(User user)
    {
        try
        {
            dbContext.User.Remove(user);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<User?> GetUserByEmailAndPassword(String email, String password)
    {
        return await dbContext.User
            .Where(u => u.Email == email && u.Password == password)
            .FirstOrDefaultAsync();
    }
}
