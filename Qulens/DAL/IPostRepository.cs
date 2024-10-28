using Microsoft.EntityFrameworkCore;
using Qulens.Models;

namespace Qulens.DAL;

public interface IPostRepository
{
    Task<IEnumerable<Post>> GetAll();
     Task<Post?> GetById(int id);
     Task Create(Post post);
    // Task Update(Post post);
    // Task<bool> Delete(int id);    
}