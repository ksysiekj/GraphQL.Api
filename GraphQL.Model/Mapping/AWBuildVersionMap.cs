using GraphQL.Model.Configuration;
using GraphQL.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping
{
    public sealed class AWBuildVersionMap : IEntityTypeConfiguration<AWBuildVersion>
    {
        public void Map(EntityTypeBuilder<AWBuildVersion> builder)
        {
            // table
            builder.ToTable("AWBuildVersion", "dbo");

            // keys
            builder.HasKey(t => t.SystemInformationID);

            // Properties
            builder.Property(t => t.SystemInformationID)
                .HasColumnName("SystemInformationID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(t => t.DatabaseVersion)
                .HasColumnName("Database Version")
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(t => t.VersionDate)
                .HasColumnName("VersionDate")
                .IsRequired();

            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
