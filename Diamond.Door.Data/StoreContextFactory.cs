using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Diamond.Door.Data;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();
         
         optionsBuilder.UseSqlite(
        "Data Source=../Registrar.sqlite",
        b => b.MigrationsAssembly("Diamond.Door.Api"));

        return new StoreContext(optionsBuilder.Options);
    }
}
