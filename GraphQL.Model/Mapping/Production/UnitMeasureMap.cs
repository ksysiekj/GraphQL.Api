using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class UnitMeasureMap : IEntityTypeConfiguration<UnitMeasure>
    {
        public void Map(EntityTypeBuilder<UnitMeasure> builder)
        {
            // table
            builder.ToTable("UnitMeasure", "Production");

            // keys
            builder.HasKey(t => t.UnitMeasureCode);

            // Properties
            builder.Property(t => t.UnitMeasureCode)
                .HasColumnName("UnitMeasureCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            //builder.HasMany(q => q.SizeProducts).WithOne(q => q.SizeUnitMeasure);
        }
    }
}
