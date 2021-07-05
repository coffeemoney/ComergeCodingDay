using CodingDay.Entities.News;
using CodingDay.Entities.Teams;
using CodingDay.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDay.Data.DataContexts
{
    public class SqlDataContext : DbContext
    {
        public SqlDataContext(DbContextOptions options) : base(options)
        { }

        public DbSet<News> News { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new[]{
                new User() { Id = 1, FirstName = "firstname demo", LastName = "lastname demo", Email = "demo@comerge.net" }
            });
        }
    }
}
