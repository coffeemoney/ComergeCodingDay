using CodingDay.Data.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDay.Data.Factories
{
    public class ContextFactory : IDesignTimeDbContextFactory<SqlDataContext>
    {
        public SqlDataContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<SqlDataContext>();
            optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            return new SqlDataContext(optionsBuilder.Options);
        }
    }
}
