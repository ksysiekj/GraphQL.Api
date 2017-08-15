using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Person
{
    public sealed class AddressTypeMap : IEntityTypeConfiguration<AddressType>
    {
        public void Map(EntityTypeBuilder<AddressType> builder)
        {
            // table
            builder.ToTable("AddressType", "Person");

            // keys
            builder.HasKey(t => t.AddressTypeID);

            // Properties
            builder.Property(t => t.AddressTypeID)
                .HasColumnName("AddressTypeID")
                .ValueGeneratedOnAdd()
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
        }
    }
}
