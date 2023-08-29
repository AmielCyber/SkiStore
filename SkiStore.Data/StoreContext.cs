using Microsoft.EntityFrameworkCore;
using SkiStore.Core.Entities;

namespace SkiStore.Data;

public class StoreContext: DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}