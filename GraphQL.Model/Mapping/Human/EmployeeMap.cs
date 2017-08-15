using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Human;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Human
{
    public sealed class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Map(EntityTypeBuilder<Employee> builder)
        {
            // table
            builder.ToTable("Employee", "HumanResources");

            // keys
            builder.HasKey(t => t.EmployeeID);

            // Properties
            builder.Property(t => t.EmployeeID)
                .HasColumnName("BusinessEntityID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.NationalIDNumber)
                .HasColumnName("NationalIDNumber")
                .HasMaxLength(15)
                .IsRequired();
            builder.Property(t => t.Title)
                .HasColumnName("JobTitle")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.BirthDate)
                .HasColumnName("BirthDate")
                .IsRequired();
            builder.Property(t => t.MaritalStatus)
                .HasColumnName("MaritalStatus")
                .HasMaxLength(1)
                .IsRequired();
            builder.Property(t => t.Gender)
                .HasColumnName("Gender")
                .HasMaxLength(1)
                .IsRequired();
            builder.Property(t => t.HireDate)
                .HasColumnName("HireDate")
                .IsRequired();
            builder.Property(t => t.SalariedFlag)
                .HasColumnName("SalariedFlag")
                .IsRequired();
            builder.Property(t => t.VacationHours)
                .HasColumnName("VacationHours")
                .IsRequired();
            builder.Property(t => t.SickLeaveHours)
                .HasColumnName("SickLeaveHours")
                .IsRequired();
            builder.Property(t => t.CurrentFlag)
                .HasColumnName("CurrentFlag")
                .IsRequired();
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasOne(t => t.Contact)
            //    .WithMany(t => t.Employees)
            //    .HasForeignKey(d => d.ContactID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(t => t.ManagerEmployee)
            //    .WithMany(t => t.ManagerEmployees)
            //    .HasForeignKey(d => d.ManagerID)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
