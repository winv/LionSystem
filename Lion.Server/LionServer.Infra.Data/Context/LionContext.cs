using LionServer.Domain.Models;
using LionServer.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace LionServer.Infra.Data.Context
{
    public class LionContext : DbContext
    {
        private readonly IHostingEnvironment _env;

        public LionContext(IHostingEnvironment env)
        {
            _env = env;
        }

        public LionContext(DbContextOptions<LionContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                //.SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            //optionsBuilder.UseSqlServer(File.ReadAllText(config.GetConnectionString("DefaultConnection")));
        }
    }
}