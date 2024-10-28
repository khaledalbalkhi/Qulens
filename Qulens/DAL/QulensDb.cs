using Microsoft.EntityFrameworkCore;
using Qulens.Models;
namespace Qulens.DAL;

public class QulensDb : DbContext
{
    public QulensDb(DbContextOptions<QulensDb> options) : base(options)
    {
    }
    //public DbSet<User> Users { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Like> Likes { get; set; } 
    public DbSet<Comment> Comments { get; set; } 
     
    public DbSet<Post> Posts { get; set; } 
     
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }

}