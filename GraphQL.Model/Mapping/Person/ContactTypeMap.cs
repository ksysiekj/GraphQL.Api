using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Person
{
    public sealed class ContactTypeMap : IEntityTypeConfiguration<ContactType>
    {
        public void Map(EntityTypeBuilder<ContactType> builder)
        {
            // table
            builder.ToTable("ContactType", "Person");

            // keys
            builder.HasKey(t => t.ContactTypeID);

            // Properties
            builder.Property(t => t.ContactTypeID)
                .HasColumnName("ContactTypeID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
