using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class DocumentMap : IEntityTypeConfiguration<Document>
    {
        public void Map(EntityTypeBuilder<Document> builder)
        {
            // table
            builder.ToTable("Document", "Production");

            // keys
            builder.HasKey(t => t.DocumentID);

            // Properties
            builder.Property(t => t.DocumentID)
                .HasColumnName("DocumentID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.FileName)
                .HasColumnName("FileName")
                .HasMaxLength(400)
                .IsRequired();
            builder.Property(t => t.FileExtension)
                .HasColumnName("FileExtension")
                .HasMaxLength(8)
                .IsRequired();
            builder.Property(t => t.Revision)
                .HasColumnName("Revision")
                .HasMaxLength(5)
                .IsRequired();
            builder.Property(t => t.ChangeNumber)
                .HasColumnName("ChangeNumber")
                .IsRequired();
            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            builder.Property(t => t.DocumentSummary)
                .HasColumnName("DocumentSummary")
                ;
            builder.Property(t => t.DocumentMember)
                .HasColumnName("Document")
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasMany(t => t.Products)
            //    .WithMany(t => t.Documents)
            //    .Map(m =>
            //    {
            //        m.ToTable("ProductDocument", "Production");
            //        m.MapLeftKey("DocumentID");
            //        m.MapRightKey("ProductID");
            //    });
        }
    }
}
