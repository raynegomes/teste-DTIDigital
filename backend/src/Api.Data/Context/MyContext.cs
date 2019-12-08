using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
  public class MyContext : DbContext
  {
    public DbSet<ProductEntity> Products { get; set; }
    public MyContext(DbContextOptions<MyContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<ProductEntity>(new ProductMap().Configure);
    }
  }
}
