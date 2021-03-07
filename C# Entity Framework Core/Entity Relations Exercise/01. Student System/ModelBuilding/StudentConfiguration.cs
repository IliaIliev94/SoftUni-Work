using P01_StudentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.ModelBuilding
{
    public class StudentConfiguration
        : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100).IsUnicode().IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(10).IsFixedLength().IsRequired(false).IsUnicode(false);
            builder.Property(x => x.Birthday).IsRequired(false);
        }
    }
}
