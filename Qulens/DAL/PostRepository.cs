using Microsoft.EntityFrameworkCore;
using Qulens.Models;

namespace Qulens.DAL;

public class PostRepository : IPostRepository
{
    private readonly QulensDb _db;

    public PostRepository(QulensDb db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Post>> GetAll()
    {
        return await _db.Posts.ToListAsync();
    }
    public async Task<Post?> GetById(int id)
    {
        return await _db.Posts.FindAsync(id);
    }
    public async Task Create(Post post)
    {
        _db.Posts.Add(post);
        await _db.SaveChangesAsync();
    }
}