using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ScrapReasonMap : IEntityTypeConfiguration<ScrapReason>
    {
        public void Map(EntityTypeBuilder<ScrapReason> builder)
        {
            // table
            builder.ToTable("ScrapReason", "Production");

            // keys
            builder.HasKey(t => t.ScrapReasonID);

            // Properties
            builder.Property(t => t.ScrapReasonID)
                .HasColumnName("ScrapReasonID")
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
