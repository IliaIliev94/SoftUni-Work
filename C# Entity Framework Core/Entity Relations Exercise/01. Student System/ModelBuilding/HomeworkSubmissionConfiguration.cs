using P01_StudentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.ModelBuilding
{
    public class HomeworkSubmissionConfiguration
        : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.HasKey(p => p.HomeworkId);
            builder.Property(p => p.Content).IsRequired(false).IsUnicode(false).IsRequired();
            builder
                .Property(p => p.ContentType)
                .HasConversion(
                v => v.ToString(),
                v => (HomeworkNames)Enum.Parse(typeof(HomeworkNames), v))
                .IsRequired();
        }
    }
}
