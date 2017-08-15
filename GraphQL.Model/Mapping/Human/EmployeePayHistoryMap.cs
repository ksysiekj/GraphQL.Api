using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Human;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Human
{
    public sealed class EmployeePayHistoryMap : IEntityTypeConfiguration<EmployeePayHistory>
    {
        public void Map(EntityTypeBuilder<EmployeePayHistory> builder)
        {
            // table
            builder.ToTable("EmployeePayHistory", "HumanResources");

            // keys
            builder.HasKey(t => new { t.EmployeeID, t.RateChangeDate });

            // Properties
            builder.Property(t => t.EmployeeID)
                .HasColumnName("EmployeeID")
                .IsRequired();
            builder.Property(t => t.RateChangeDate)
                .HasColumnName("RateChangeDate")
            .IsRequired();
            builder.Property(t => t.Rate)
                .HasColumnName("Rate")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.PayFrequency)
                .HasColumnName("PayFrequency")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasOne(t => t.Employee)
            //    .WithMany(t => t.EmployeePayHistories)
            //    .HasForeignKey(d => d.EmployeeID)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
