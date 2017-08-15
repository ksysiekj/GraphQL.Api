using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class SalesTaxRateMap : IEntityTypeConfiguration<SalesTaxRate>
    {
        public void Map(EntityTypeBuilder<SalesTaxRate> builder)
        {
            // table
            builder.ToTable("SalesTaxRate", "Sales");

            // keys
            builder.HasKey(t => t.SalesTaxRateID);

            // Properties
            builder.Property(t => t.SalesTaxRateID)
                .HasColumnName("SalesTaxRateID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.StateProvinceID)
                .HasColumnName("StateProvinceID")
                .IsRequired();
            builder.Property(t => t.TaxType)
                .HasColumnName("TaxType")
                .IsRequired();
            builder.Property(t => t.TaxRate)
                .HasColumnName("TaxRate")
                .HasColumnType("decimal(10,4)")
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.StateProvince)
                .WithMany(t => t.SalesTaxRates)
                .HasForeignKey(d => d.StateProvinceID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
