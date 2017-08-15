using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class WorkOrderRoutingMap : IEntityTypeConfiguration<WorkOrderRouting>
    {
        public void Map(EntityTypeBuilder<WorkOrderRouting> builder)
        {
            // table
            builder.ToTable("WorkOrderRouting", "Production");

            // keys
            builder.HasKey(t => new { t.WorkOrderID, t.ProductID, t.OperationSequence });

            // Properties
            builder.Property(t => t.WorkOrderID)
                .HasColumnName("WorkOrderID")
                .IsRequired();
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.OperationSequence)
                .HasColumnName("OperationSequence")
                .IsRequired();
            builder.Property(t => t.LocationID)
                .HasColumnName("LocationID")
                .IsRequired();
            builder.Property(t => t.ScheduledStartDate)
                .HasColumnName("ScheduledStartDate")
                .IsRequired();
            builder.Property(t => t.ScheduledEndDate)
                .HasColumnName("ScheduledEndDate")
                .IsRequired();
            builder.Property(t => t.ActualStartDate)
                .HasColumnName("ActualStartDate")
                ;
            builder.Property(t => t.ActualEndDate)
                .HasColumnName("ActualEndDate")
                ;
            builder.Property(t => t.ActualResourceHrs)
                .HasColumnName("ActualResourceHrs")
                .HasColumnType("decimal(9,4)")
                ;
            builder.Property(t => t.PlannedCost)
                .HasColumnName("PlannedCost")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.ActualCost)
                .HasColumnName("ActualCost")
                .HasColumnType("decimal(19,4)")
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Location)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.LocationID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.WorkOrderID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
