using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();


            var connectionString = "workstation id=funciona.mssql.somee.com;packet size=4096;user id=eddianvasquez_SQLLogin_1;pwd=s3odkbyaki;data source=funciona.mssql.somee.com;persist security info=False;initial catalog=funciona;TrustServerCertificate=True";

            optionsBuilder.UseSqlServer(connectionString);

            return new Contexto(optionsBuilder.Options);
        }
    }
}