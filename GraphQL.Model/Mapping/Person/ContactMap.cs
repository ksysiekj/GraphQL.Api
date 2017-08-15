using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Person
{
    public sealed class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Map(EntityTypeBuilder<Contact> builder)
        {
            // table
            builder.ToTable("Contact", "Person");

            // keys
            builder.HasKey(t => t.ContactID);

            // Properties
            builder.Property(t => t.ContactID)
                .HasColumnName("ContactID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.NameStyle)
                .HasColumnName("NameStyle")
                .IsRequired();
            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasMaxLength(8)
                ;
            builder.Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.MiddleName)
                .HasColumnName("MiddleName")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.Suffix)
                .HasColumnName("Suffix")
                .HasMaxLength(10)
                ;
            builder.Property(t => t.EmailAddress)
                .HasColumnName("EmailAddress")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.EmailPromotion)
                .HasColumnName("EmailPromotion")
                .IsRequired();
            builder.Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasMaxLength(25)
                ;
            builder.Property(t => t.PasswordHash)
                .HasColumnName("PasswordHash")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(t => t.PasswordSalt)
                .HasColumnName("PasswordSalt")
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(t => t.AdditionalContactInfo)
                .HasColumnName("AdditionalContactInfo")
                ;
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasMany(t => t.CreditCards)
            //    .WithMany(t => t.Contacts)
            //    .Map(m =>
            //    {
            //        m.ToTable("ContactCreditCard", "Sales");
            //        m.MapLeftKey("ContactID");
            //        m.MapRightKey("CreditCardID");
            //    });
        }
    }
}
