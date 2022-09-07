using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;
public class StoreContext : DbContext
{
    //constructor
    public StoreContext(DbContextOptions options) : base(options)
    {
        
    }
    // products is the name of the table in the database
    public DbSet<Product> Products { get; set; }
}