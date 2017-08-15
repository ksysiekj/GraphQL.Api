using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class WorkOrderMap : IEntityTypeConfiguration<WorkOrder>
    {
        public void Map(EntityTypeBuilder<WorkOrder> builder)
        {
            // table
            builder.ToTable("WorkOrder", "Production");

            // keys
            builder.HasKey(t => t.WorkOrderID);

            // Properties
            builder.Property(t => t.WorkOrderID)
                .HasColumnName("WorkOrderID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            builder.Property(t => t.OrderQty)
                .HasColumnName("OrderQty")
                .IsRequired();
            builder.Property(t => t.StockedQty)
                .HasColumnName("StockedQty")
                .ValueGeneratedOnAddOrUpdate()
                .IsRequired();
            builder.Property(t => t.ScrappedQty)
                .HasColumnName("ScrappedQty")
                .IsRequired();
            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                ;
            builder.Property(t => t.DueDate)
                .HasColumnName("DueDate")
                .IsRequired();
            builder.Property(t => t.ScrapReasonID)
                .HasColumnName("ScrapReasonID")
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.ScrapReason)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ScrapReasonID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
