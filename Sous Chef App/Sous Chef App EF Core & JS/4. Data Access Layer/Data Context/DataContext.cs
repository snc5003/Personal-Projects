using Microsoft.EntityFrameworkCore;
using Sous_Chef_App.Models;

namespace Sous_Chef_App.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base (options) {}

    // Identify the SQL tables to be created
    public DbSet<Users> Users {get; set;}
    public DbSet<MealPlans> MealPlans {get; set;}
    public DbSet<Recipes> Recipes {get; set;}
    public DbSet<GroceryItems> GroceryItems {get; set;}

    // Make the SQL database case-sensitive
    protected override void OnModelCreating (ModelBuilder modelBulder)
    {
        modelBulder.UseCollation("SQL_Latin1_General_CP1_CS_AS");
    }
}