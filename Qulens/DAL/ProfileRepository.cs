using Microsoft.EntityFrameworkCore;
using Qulens.Models;

namespace Qulens.DAL;

public class ProfileRepository : IProfileRepository
{
    private readonly QulensDb _db;

    public ProfileRepository(QulensDb context)
    {
        _db = context;
    }

    public async Task<IEnumerable<Profile>> GetAll()
    {
        return await _db.Profiles.ToListAsync();
    }

    // public async Task<Profile?> GetById(int id)
}