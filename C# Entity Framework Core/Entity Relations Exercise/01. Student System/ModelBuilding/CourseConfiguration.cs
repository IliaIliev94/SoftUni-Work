using P01_StudentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.ModelBuilding
{
    public class CourseConfiguration
        : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(80).IsRequired();
            builder.Property(p => p.Description).IsRequired(false);
        }
    }
}
