using Microsoft.Build.Graph;
using Microsoft.EntityFrameworkCore;
using RESTGIYDIRME.Models.EntityData;
using System.Reflection;

namespace RESTGIYDIRME.Models
{
    public class RestartDbContext : DbContext
    {
        //public RestartDbContext(DbContextOptions<RestartDbContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-BL47J3BB\\SQLEXPRESS;Database=RestartDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<IndexInfo> IndexInfos { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<PortfolioSlider> PortfolioSliders { get; set; }
    }
}
