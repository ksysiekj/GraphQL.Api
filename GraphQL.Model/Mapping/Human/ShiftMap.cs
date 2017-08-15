using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Human;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Human
{
    public sealed class ShiftMap : IEntityTypeConfiguration<Shift>
    {
        public void Map(EntityTypeBuilder<Shift> builder)
        {
            // table
            builder.ToTable("Shift", "HumanResources");

            // keys
            builder.HasKey(t => t.ShiftID);

            // Properties
            builder.Property(t => t.ShiftID)
                .HasColumnName("ShiftID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.StartTime)
                .HasColumnName("StartTime")
                .IsRequired();
            builder.Property(t => t.EndTime)
                .HasColumnName("EndTime")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
        }
    }
}
