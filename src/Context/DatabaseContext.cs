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
    public DbSet<Category> Category { get; set; }
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Videos>()
          .Property(video => video.CreatedAt)
          .HasDefaultValueSql("CURRENT_TIMESTAMP");
      modelBuilder.Entity<Category>()
          .Property(category => category.CreatedAt)
          .HasDefaultValueSql("CURRENT_TIMESTAMP");
      modelBuilder.Entity<Videos>()
        .Property(video => video.UpdatedAt)
        .HasDefaultValueSql("CURRENT_TIMESTAMP");


      modelBuilder.Entity<Videos>()
        .HasOne(video => video.Category)
        .WithMany(category => category.Videos)
        .HasForeignKey(video => video.CategoryId)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}