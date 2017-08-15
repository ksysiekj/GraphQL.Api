using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Map(EntityTypeBuilder<Customer> builder)
        {
            // table
            builder.ToTable("Customer", "Sales");

            // keys
            builder.HasKey(t => t.CustomerID);

            // Properties
            builder.Property(t => t.CustomerID)
                .HasColumnName("CustomerID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID");

            builder.Property(t => t.AccountNumber)
                .HasColumnName("AccountNumber")
                .ValueGeneratedOnAddOrUpdate()
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(t => t.CustomerType)
                .HasColumnName("CustomerType")
                .HasMaxLength(1)
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.TerritoryID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
