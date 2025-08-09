using EmployeeCustomProperties.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Repository.EntitiesConfiguration
{
    public class CustomPropertyTypeConfiguration : IEntityTypeConfiguration<CustomProperty>
    {
        public void Configure(EntityTypeBuilder<CustomProperty> builder)
        {
            builder.ToTable("CustomProperties");
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Type);
            builder.Property(c => c.IsRequired);
            builder.Property(c => c.PropertyName);
            builder.Property(c => c.Value);
            builder.HasOne(c => c.Employee)
                .WithMany(e => e.CustomProperties)
                .HasForeignKey(c => c.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(c => c.CustomPropertyDropdowns)
                .WithOne(d => d.CustomProperty)
                .HasForeignKey(c => c.CustomPropertyId)
                .OnDelete(DeleteBehavior.Cascade);  

        }
    }
}
