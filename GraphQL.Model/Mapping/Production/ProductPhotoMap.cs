using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductPhotoMap : IEntityTypeConfiguration<ProductPhoto>
    {
        public void Map(EntityTypeBuilder<ProductPhoto> builder)
        {
            // table
            builder.ToTable("ProductPhoto", "Production");

            // keys
            builder.HasKey(t => t.ProductPhotoID);

            // Properties
            builder.Property(t => t.ProductPhotoID)
                .HasColumnName("ProductPhotoID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.ThumbNailPhoto)
                .HasColumnName("ThumbNailPhoto")
                ;
            builder.Property(t => t.ThumbnailPhotoFileName)
            .HasColumnName("ThumbnailPhotoFileName")
            .HasMaxLength(50)
            ;
            builder.Property(t => t.LargePhoto)
                .HasColumnName("LargePhoto")
                ;
            builder.Property(t => t.LargePhotoFileName)
                .HasColumnName("LargePhotoFileName")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
