using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebProject.WebProject.DataAccess;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer("Server=tcp:suad.database.windows.net,1433;Initial Catalog=EcommerceWeb;Persist Security Info=False;User ID=Suad;Password=s12345678!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
