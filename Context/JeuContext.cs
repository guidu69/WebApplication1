using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

public class JeuContext : DbContext
{
    public DbSet<Jeu> jeux { get; set; }
    public JeuContext(DbContextOptions options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=databaseGUI2;Initial Catalog=master;Integrated Security=True");
            //optionsBuilder.LogTo(Console.WriteLine);
        }
    }

    private static DbContextOptions GetOptions(DbContextOptions options)
    {
        return options;
    }
}