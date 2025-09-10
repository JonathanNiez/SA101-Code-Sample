using Microsoft.EntityFrameworkCore;

namespace SA101;
public class AddDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(DbConnectionHelper.GetConnectionString());
    }
}
