using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RESTGIYDIRME.Models.EntityData;

namespace RESTGIYDIRME.Models.EntityConfigurations
{
    public class PortfolioSliderConfigurations : IEntityTypeConfiguration<PortfolioSlider>
    {
        public void Configure(EntityTypeBuilder<PortfolioSlider> builder)
        {
            builder
                .HasOne(x => x.Portfolio)
                .WithMany(x => x.PortfolioSliders)
                .HasForeignKey(x => x.PortId);
        }
    }
}
