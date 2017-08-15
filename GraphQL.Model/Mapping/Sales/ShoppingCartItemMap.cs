using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Sales
{
    public sealed class ShoppingCartItemMap : IEntityTypeConfiguration<ShoppingCartItem>
    {
        public void Map(EntityTypeBuilder<ShoppingCartItem> builder)
        {
            // table
            builder.ToTable("ShoppingCartItem", "Sales");

            // keys
            builder.HasKey(t => t.ShoppingCartItemID);

            // Properties
            builder.Property(t => t.ShoppingCartItemID)
                .HasColumnName("ShoppingCartItemID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.ShoppingCartID)
                .HasColumnName("ShoppingCartID")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.DateCreated)
                .HasColumnName("DateCreated")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ShoppingCartItems)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
