using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            // var connectionString = "Server=localhost;Port=3306;Database=dbApi;Uid=root;Pwd=admin";
            // optionsBuilder.UseMySql(connectionString); 
            var connectionString = "Server=.\\SQLEXPRESS2019;Initial Catalog=dbapi;MultipleActiveResultSets=true;User ID=sa;Password=pwd!0407@";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);

        }
    }
}
