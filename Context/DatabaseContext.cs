using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using workspace.Models;

namespace workspace.Context
{
  public class DatabaseContext : DbContext
  {
    public DbSet<Videos> Videos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Videos>()
          .Property(video => video.CreatedAt)
          .HasDefaultValueSql("getdate()");
      modelBuilder.Entity<Videos>().Property(video => video.UpdatedAt)
        .ValueGeneratedOnAddOrUpdate()
        .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
    }
  }
}