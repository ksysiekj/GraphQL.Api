using GraphQL.Model.Configuration;
using GraphQL.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping
{
    public sealed class DatabaseLogMap : IEntityTypeConfiguration<DatabaseLog>
    {
        public void Map(EntityTypeBuilder<DatabaseLog> builder)
        {
            // table
            builder.ToTable("DatabaseLog", "dbo");

            // keys
            builder.HasKey(t => t.DatabaseLogID);

            // Properties
            builder.Property(t => t.DatabaseLogID)
                .HasColumnName("DatabaseLogID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.PostTime)
                .HasColumnName("PostTime")
                .IsRequired();
            builder.Property(t => t.DatabaseUser)
                .HasColumnName("DatabaseUser")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(t => t.Event)
                .HasColumnName("Event")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(t => t.Schema)
                .HasColumnName("Schema")
                .HasMaxLength(128);

            builder.Property(t => t.Object)
                .HasColumnName("Object")
                .HasMaxLength(128);

            builder.Property(t => t.Tsql)
                .HasColumnName("TSQL")
                .IsRequired();
            builder.Property(t => t.XmlEvent)
                .HasColumnName("XmlEvent")
                .IsRequired();

        }
    }
}
