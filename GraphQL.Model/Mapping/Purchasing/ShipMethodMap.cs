using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Purchasing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Purchasing
{
    public sealed class ShipMethodMap : IEntityTypeConfiguration<ShipMethod>
    {
        public void Map(EntityTypeBuilder<ShipMethod> builder)
        {
            // table
            builder.ToTable("ShipMethod", "Purchasing");

            // keys
            builder.HasKey(t => t.ShipMethodID);

            // Properties
            builder.Property(t => t.ShipMethodID)
                .HasColumnName("ShipMethodID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ShipBase)
                .HasColumnName("ShipBase")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.ShipRate)
                .HasColumnName("ShipRate")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
