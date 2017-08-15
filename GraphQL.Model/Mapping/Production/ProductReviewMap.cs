using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductReviewMap : IEntityTypeConfiguration<ProductReview>
    {
        public void Map(EntityTypeBuilder<ProductReview> builder)
        {
            // table
            builder.ToTable("ProductReview", "Production");

            // keys
            builder.HasKey(t => t.ProductReviewID);

            // Properties
            builder.Property(t => t.ProductReviewID)
                .HasColumnName("ProductReviewID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.ReviewerName)
                .HasColumnName("ReviewerName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ReviewDate)
                .HasColumnName("ReviewDate")
                .IsRequired();
            builder.Property(t => t.EmailAddress)
                .HasColumnName("EmailAddress")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.Rating)
                .HasColumnName("Rating")
                .IsRequired();
            builder.Property(t => t.Comments)
                .HasColumnName("Comments")
                .HasMaxLength(3850)
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductReviews)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
