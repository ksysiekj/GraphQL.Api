using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class LocationMap : IEntityTypeConfiguration<Location>
    {
        public void Map(EntityTypeBuilder<Location> builder)
        {
            // table
            builder.ToTable("Location", "Production");

            // keys
            builder.HasKey(t => t.LocationID);

            // Properties
            builder.Property(t => t.LocationID)
                .HasColumnName("LocationID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.CostRate)
                .HasColumnName("CostRate")
                .HasColumnType("decimal(10,4)")
                .IsRequired();
            builder.Property(t => t.Availability)
                .HasColumnName("Availability")
                .HasColumnType("decimal(8,2)")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
