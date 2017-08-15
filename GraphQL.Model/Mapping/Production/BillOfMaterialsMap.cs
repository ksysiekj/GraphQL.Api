using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class BillOfMaterialsMap : IEntityTypeConfiguration<BillOfMaterials>
    {
        public void Map(EntityTypeBuilder<BillOfMaterials> builder)
        {
            // table
            builder.ToTable("BillOfMaterials", "Production");

            // keys
            builder.HasKey(t => t.BillOfMaterialsID);

            // Properties
            builder.Property(t => t.BillOfMaterialsID)
                .HasColumnName("BillOfMaterialsID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(t => t.ProductAssemblyID)
                .HasColumnName("ProductAssemblyID")
                ;

            builder.Property(t => t.ComponentID)
                .HasColumnName("ComponentID")
                .IsRequired();
            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                ;
            builder.Property(t => t.UnitMeasureCode)
                .HasColumnName("UnitMeasureCode")
                .HasMaxLength(3)
                .IsRequired();
            builder.Property(t => t.BOMLevel)
                .HasColumnName("BOMLevel")
                .IsRequired();
            builder.Property(t => t.PerAssemblyQty)
                .HasColumnName("PerAssemblyQty")
            .HasColumnType("decimal(5,2)")
             .IsRequired();

            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            //builder.HasOne(t => t.ComponentProduct)
            //    .WithMany(t => t.ComponentBillOfMaterials)
            //    .HasForeignKey(d => d.ComponentID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(t => t.AssemblyProduct)
            //    .WithMany(t => t.AssemblyBillOfMaterials)
            //    .HasForeignKey(d => d.ProductAssemblyID)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.UnitMeasure)
                .WithMany(t => t.BillOfMaterials)
                .HasForeignKey(d => d.UnitMeasureCode)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
