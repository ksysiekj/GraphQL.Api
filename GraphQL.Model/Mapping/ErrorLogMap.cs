using GraphQL.Model.Configuration;
using GraphQL.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping
{
    public sealed class ErrorLogMap : IEntityTypeConfiguration<ErrorLog>
    {
        public void Map(EntityTypeBuilder<ErrorLog> builder)
        {
            // table
            builder.ToTable("ErrorLog", "dbo");

            // keys
            builder.HasKey(t => t.ErrorLogID);

            // Properties
            builder.Property(t => t.ErrorLogID)
                .HasColumnName("ErrorLogID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.ErrorTime)
                .HasColumnName("ErrorTime")
                .IsRequired();
            builder.Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(t => t.ErrorNumber)
                .HasColumnName("ErrorNumber")
                .IsRequired();
            builder.Property(t => t.ErrorSeverity)
                .HasColumnName("ErrorSeverity");

            builder.Property(t => t.ErrorState)
                .HasColumnName("ErrorState")
                ;
            builder.Property(t => t.ErrorProcedure)
                .HasColumnName("ErrorProcedure")
                .HasMaxLength(126)
                ;
            builder.Property(t => t.ErrorLine)
                .HasColumnName("ErrorLine")
                ;
            builder.Property(t => t.ErrorMessage)
                .HasColumnName("ErrorMessage")
                .HasMaxLength(4000)
                .IsRequired();
        }
    }
}
