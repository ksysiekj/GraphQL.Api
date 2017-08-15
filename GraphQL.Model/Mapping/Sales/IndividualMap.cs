using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class IndividualMap : IEntityTypeConfiguration<Individual>
    {
        public void Map(EntityTypeBuilder<Individual> builder)
        {
            // table
            builder.ToTable("Individual", "Sales");

            // keys
            builder.HasKey(t => t.CustomerID);

            // Properties
            builder.Property(t => t.CustomerID)
                .HasColumnName("CustomerID")
                .IsRequired();
            builder.Property(t => t.ContactID)
                .HasColumnName("ContactID")
                .IsRequired();
            builder.Property(t => t.Demographics)
                .HasColumnName("Demographics")
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Contact)
                .WithMany(t => t.Individuals)
                .HasForeignKey(d => d.ContactID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Customer)
                .WithMany(t => t.Individuals)
                .HasForeignKey(d => d.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
