using Microsoft.EntityFrameworkCore;
using Qulens.Models;
namespace Qulens.DAL;

public interface IProfileRepository
{
    Task<IEnumerable<Profile>> GetAll();
    // Task<Profile?> GetById(int id);
    // Task Create(Profile profile);
    // Task Update(Profile profile);
    // Task<bool> Delete(int id);
}
