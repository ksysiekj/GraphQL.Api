using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Human;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Human
{
    public sealed class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Map(EntityTypeBuilder<Department> builder)
        {
            // table
            builder.ToTable("Department", "HumanResources");

            // keys
            builder.HasKey(t => t.DepartmentID);

            // Properties
            builder.Property(t => t.DepartmentID)
                .HasColumnName("DepartmentID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.GroupName)
                .HasColumnName("GroupName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
