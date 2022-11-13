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

        public DbSet<SliderEntity> Sliders { get; set; }
        public DbSet<IndexInfoEntity> IndexInfos { get; set; }
        public DbSet<PortfolioEntity> Portfolios { get; set; }
        public DbSet<TeamEntity> Teams { get; set; }
        public DbSet<AboutEntity> Abouts { get; set; }
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ReferanceEntity> Referances { get; set; }
        public DbSet<PortfolioSliderEntity> PortfolioSliders { get; set; }
    }
}
