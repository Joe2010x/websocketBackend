using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;

namespace WSserver.Models;

public class PostDbContext : DbContext
{
    public PostDbContext (DbContextOptions<PostDbContext> options) : base(options)  {
        this.EnsureSeedDate();
    }
    public DbSet <Post> Posts {get; set;} 
    public DbSet <Author> Authors {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("NorkPosts");
    }

}