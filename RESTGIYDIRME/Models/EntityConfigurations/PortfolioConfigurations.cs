using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RESTGIYDIRME.Models.EntityData;

namespace RESTGIYDIRME.Models.EntityConfigurations
{
    public class PortfolioConfigurations : IEntityTypeConfiguration<Portfolio>
    {
        public void Configure(EntityTypeBuilder<Portfolio> builder)
        {
            builder.Property(x => x.GalleryImage)
                .IsRequired(true);

            builder.Property(x => x.Title)
                .IsRequired(true);

            builder.Property(x => x.Description)
                .IsRequired(false);

            builder.Property(x => x.Category)
                .IsRequired(false);

            builder.Property(x => x.Date)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.Client)
                .IsRequired(false);

            builder.Property(x => x.Place)
                .IsRequired(false);

            builder.Property(x => x.Rating)
                .HasDefaultValue(0);
        }
    }
}
