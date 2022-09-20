using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryRoutes.Domain.DeliveryRoutes.Infrastructure.EntityConfiguration;
using DeliveryRoutes.Domain.DeliveryRoutes.Model;

namespace DeliveryRoutes.Domain.DeliveryRoutes.Infrastructure.EntityConfiguration
{
    public class DeliveryRoutesTypeConfiguration : IEntityTypeConfiguration<DeliveryRoutesEntity>
    {
        public void Configure(EntityTypeBuilder<DeliveryRoutesEntity> builder)
        {
            builder.ToTable("diaroe").HasKey(re => new { re.CompanyCode, re.DeliveryRoutesCode });

            builder.Property(re => re.CompanyCode).HasColumnName("empcod").HasColumnType("smallint");
            builder.Property(re => re.DeliveryRoutesCode).HasColumnName("roecod").HasColumnType("smallint");
            builder.Property(re => re.UfRouteOrigin).HasColumnName("roeuforigem").HasColumnType("char(4)");
            builder.Property(re => re.CityOrigin).HasColumnName("roecidadeorigem").HasColumnType("char(35)");
            builder.Property(re => re.UfDestinationRoute).HasColumnName("roeufdest").HasColumnType("char(4)");
            builder.Property(re => re.CityDestination).HasColumnName("roecidadedest").HasColumnType("char(35)");
        }
    }
}