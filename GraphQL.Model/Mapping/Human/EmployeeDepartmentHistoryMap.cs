using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Human;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Human
{
    public sealed class EmployeeDepartmentHistoryMap : IEntityTypeConfiguration<EmployeeDepartmentHistory>
    {
        public void Map(EntityTypeBuilder<EmployeeDepartmentHistory> builder)
        {
            // table
            builder.ToTable("EmployeeDepartmentHistory", "HumanResources");

            // keys
            builder.HasKey(t => new { t.EmployeeID, t.DepartmentID, t.ShiftID, t.StartDate });

            // Properties
            builder.Property(t => t.EmployeeID)
                .HasColumnName("EmployeeID")
                .IsRequired();
            builder.Property(t => t.DepartmentID)
                .HasColumnName("DepartmentID")
                .IsRequired();
            builder.Property(t => t.ShiftID)
                .HasColumnName("ShiftID")
                .IsRequired();
            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate");
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Department)
                .WithMany(t => t.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(t => t.Employee)
            //    .WithMany(t => t.EmployeeDepartmentHistories)
            //    .HasForeignKey(d => d.EmployeeID)
            //    .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Shift)
                .WithMany(t => t.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.ShiftID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
