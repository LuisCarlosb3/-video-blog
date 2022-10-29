using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using workspace.Models;

namespace workspace.Context
{
  public class DatabaseContext : DbContext
  {
    public DbSet<Videos> Videos { get; set; }
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Videos>()
          .Property(video => video.CreatedAt)
          .HasDefaultValueSql("CURRENT_TIMESTAMP");
      modelBuilder.Entity<Videos>()
        .Property(video => video.UpdatedAt)
        .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
  }
}