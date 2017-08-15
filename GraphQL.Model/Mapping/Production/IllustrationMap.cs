using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class IllustrationMap : IEntityTypeConfiguration<Illustration>
    {
        public void Map(EntityTypeBuilder<Illustration> builder)
        {
            // table
            builder.ToTable("Illustration", "Production");

            // keys
            builder.HasKey(t => t.IllustrationID);

            // Properties
            builder.Property(t => t.IllustrationID)
                .HasColumnName("IllustrationID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Diagram)
                .HasColumnName("Diagram")
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasMany(t => t.ProductModels)
            //    .WithMany(t => t.Illustrations)
            //    .Map(m =>
            //    {
            //        m.ToTable("ProductModelIllustration", "Production");
            //        m.MapLeftKey("IllustrationID");
            //        m.MapRightKey("ProductModelID");
            //    });
        }
    }
}
