using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Person
{
    public sealed class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Map(EntityTypeBuilder<Address> builder)
        {
            // table
            builder.ToTable("Address", "Person");

            // keys
            builder.HasKey(t => t.AddressID);

            // Properties
            builder.Property(t => t.AddressID)
                .HasColumnName("AddressID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(t => t.AddressLine1)
                .HasColumnName("AddressLine1")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(t => t.AddressLine2)
                .HasColumnName("AddressLine2")
                .HasMaxLength(60)
                .IsRequired(false);

            builder.Property(t => t.City)
                .HasColumnName("City")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(t => t.StateProvinceID)
                .HasColumnName("StateProvinceID")
                .IsRequired();

            builder.Property(t => t.PostalCode)
                .HasColumnName("PostalCode")
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();

            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasMany(t => t.Employees)
            //    .WithMany(t => t.Address)
            //    .Map(m =>
            //    {
            //        m.ToTable("EmployeeAddress", "HumanResources");
            //        m.MapLeftKey("AddressID");
            //        m.MapRightKey("EmployeeID");
            //    });

            //builder.HasMany(q => q.BillToSalesOrderHeaders)
            //    ;

            builder.HasOne(t => t.StateProvince)
                .WithMany(t => t.Address)
                .HasForeignKey(d => d.StateProvinceID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
