using GraphQL.Model.Configuration;
using GraphQL.Model.Entities.Human;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.Model.Mapping.Human
{
    public sealed class JobCandidateMap : IEntityTypeConfiguration<JobCandidate>
    {
        public void Map(EntityTypeBuilder<JobCandidate> builder)
        {
            // table
            builder.ToTable("JobCandidate", "HumanResources");

            // keys
            builder.HasKey(t => t.JobCandidateID);

            // Properties
            builder.Property(t => t.JobCandidateID)
                .HasColumnName("JobCandidateID")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(t => t.EmployeeID)
                .HasColumnName("BusinessEntityID")
                ;
            builder.Property(t => t.Resume)
                .HasColumnName("Resume")
                .HasColumnType("xml")
                ;
            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.JobCandidates)
                .HasForeignKey(d => d.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
