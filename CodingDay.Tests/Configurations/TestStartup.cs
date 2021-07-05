using CodingDay.Data.DataContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodingDay.Tests.Configurations
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) : base(configuration) { }

        protected override void SetupDataContext(IServiceCollection services)
        {
            services.AddDbContext<SqlDataContext>(opt =>
            {
                opt.UseSqlite("Data Source=testing.db",
                    m => m.MigrationsAssembly("CodingDay.Data"));
            }, ServiceLifetime.Scoped);
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Migrate if not latest
            using (var serviceScope = app.ApplicationServices
            .GetRequiredService<IServiceScopeFactory>()
            .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<SqlDataContext>())
                {
                    context.Database.Migrate();
                }
            }

            base.Configure(app, env);
        }
    }
}
