using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class CultureMap : IEntityTypeConfiguration<Culture>
    {
        public void Map(EntityTypeBuilder<Culture> builder)
        {
            // table
            builder.ToTable("Culture", "Production");

            // keys
            builder.HasKey(t => t.CultureID);

            // Properties
            builder.Property(t => t.CultureID)
                .HasColumnName("CultureID")
                .HasMaxLength(6)
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
