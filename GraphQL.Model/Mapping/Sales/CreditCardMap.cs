using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class CreditCardMap : IEntityTypeConfiguration<CreditCard>
    {
        public void Map(EntityTypeBuilder<CreditCard> builder)
        {
            // table
            builder.ToTable("CreditCard", "Sales");

            // keys
            builder.HasKey(t => t.CreditCardID);

            // Properties
            builder.Property(t => t.CreditCardID)
                .HasColumnName("CreditCardID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.CardType)
                .HasColumnName("CardType")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.CardNumber)
                .HasColumnName("CardNumber")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(t => t.ExpMonth)
                .HasColumnName("ExpMonth")
                .IsRequired();
            builder.Property(t => t.ExpYear)
                .HasColumnName("ExpYear")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
