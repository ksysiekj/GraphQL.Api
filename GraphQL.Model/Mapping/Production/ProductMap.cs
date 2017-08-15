using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Production
{
    public sealed class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Map(EntityTypeBuilder<Product> builder)
        {
            // table
            builder.ToTable("Product", "Production");

            // keys
            builder.HasKey(t => t.ProductID);

            // Properties
            builder.Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.ProductNumber)
                .HasColumnName("ProductNumber")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(t => t.MakeFlag)
                .HasColumnName("MakeFlag")
                .IsRequired();
            builder.Property(t => t.FinishedGoodsFlag)
                .HasColumnName("FinishedGoodsFlag")
                .IsRequired();
            builder.Property(t => t.Color)
                .HasColumnName("Color")
                .HasMaxLength(15)
                ;
            builder.Property(t => t.SafetyStockLevel)
                .HasColumnName("SafetyStockLevel")
                .IsRequired();
            builder.Property(t => t.ReorderPoint)
                .HasColumnName("ReorderPoint")
                .IsRequired();
            builder.Property(t => t.StandardCost)
                .HasColumnName("StandardCost")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.ListPrice)
                .HasColumnName("ListPrice")
                .HasColumnType("decimal(19,4)")
                .IsRequired();
            builder.Property(t => t.Size)
                .HasColumnName("Size")
                .HasMaxLength(5)
                ;
            builder.Property(t => t.SizeUnitMeasureCode)
                .HasColumnName("SizeUnitMeasureCode")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.WeightUnitMeasureCode)
                .HasColumnName("WeightUnitMeasureCode")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.Weight)
                .HasColumnName("Weight")
                .HasColumnType("decimal(8,2)")
                ;
            builder.Property(t => t.DaysToManufacture)
                .HasColumnName("DaysToManufacture")
                .IsRequired();
            builder.Property(t => t.ProductLine)
                .HasColumnName("ProductLine")
                .HasMaxLength(2)
                ;
            builder.Property(t => t.Class)
                .HasColumnName("Class")
                .HasMaxLength(2)
                ;
            builder.Property(t => t.Style)
                .HasColumnName("Style")
                .HasMaxLength(2)
                ;
            builder.Property(t => t.ProductSubcategoryID)
                .HasColumnName("ProductSubcategoryID")
                ;
            builder.Property(t => t.ProductModelID)
                .HasColumnName("ProductModelID")
                ;
            builder.Property(t => t.SellStartDate)
                .HasColumnName("SellStartDate")
                .IsRequired();
            builder.Property(t => t.SellEndDate)
                .HasColumnName("SellEndDate")
                ;
            builder.Property(t => t.DiscontinuedDate)
                .HasColumnName("DiscontinuedDate")
                ;
            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.ProductModel)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductModelID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.ProductSubcategory)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductSubcategoryID)
                .OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(t => t.SizeUnitMeasure)
            //    .WithMany(t => t.SizeProducts)
            //    .HasForeignKey(d => d.SizeUnitMeasureCode)
            //    .OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(t => t.WeightUnitMeasure)
            //    .WithMany(t => t.WeightProducts)
            //    .HasForeignKey(d => d.WeightUnitMeasureCode)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(t => t.ComponentBillOfMaterials)
            //    .WithOne(t => t.ComponentProduct)
            //    .HasForeignKey(d => d.ComponentID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(t => t.AssemblyBillOfMaterials)
            //    .WithOne(t => t.AssemblyProduct)
            //    .HasForeignKey(d => d.ProductAssemblyID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(t => t.ProductPhotos)
            //    .WithMany(t => t.Products)
            //    .Map(m =>
            //    {
            //        m.ToTable("ProductProductPhoto", "Production");
            //        m.MapLeftKey("ProductID");
            //        m.MapRightKey("ProductPhotoID");
            //    });
            //builder.HasMany(t => t.SpecialOffers)
            //    .WithMany(t => t.Products)
            //    .Map(m =>
            //    {
            //        m.ToTable("SpecialOfferProduct", "Sales");
            //        m.MapLeftKey("ProductID");
            //        m.MapRightKey("SpecialOfferID");
            //    });
        }
    }
}
