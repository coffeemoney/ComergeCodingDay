using CodingDay.Entities.News;
using CodingDay.Entities.Teams;
using CodingDay.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace CodingDay.Data.DataContexts
{
    public class SqlDataContext : DbContext
    {
        public SqlDataContext(DbContextOptions options) : base(options)
        { }

        public DbSet<News> News { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);

            modelBuilder.Entity<UserTeam>()
                .HasKey(x => new { x.UserId, x.TeamId });

            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new[]{
                new User() { Id = 1, FirstName = "firstname demo", LastName = "lastname demo", Email = "demo@comerge.net" }
            });

            modelBuilder.Entity<Team>().HasData(new[]{
                new Team() { Id = 1,  Name = "Coding Day Team", Description = "Coding Day Team" }
            });

            modelBuilder.Entity<UserTeam>().HasData(new[]{
                new UserTeam() { TeamId = 1, UserId = 1 }
            });

        }
    }
}
