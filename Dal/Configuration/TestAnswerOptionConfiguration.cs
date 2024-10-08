﻿using Domain.Entity.Content.Question;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dal.Configuration
{
    public class TestAnswerOptionConfiguration : IEntityTypeConfiguration<TestAnswerOption>
    {
        public void Configure(EntityTypeBuilder<TestAnswerOption> builder)
        {
            builder.ToTable("Test_Answer_Option", "dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
               .ValueGeneratedOnAdd()
               .HasColumnName("Id");
            
            builder.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            
            builder.Property(e => e.OptionText)
                .IsRequired()
                .HasColumnName("Answer_Option")
                .HasMaxLength(500);

            builder
                .HasOne(e => e.TestQuestion)
                .WithMany(e => e.AnswerOptions)
                .HasForeignKey(e => e.TestQuestionId)
                .IsRequired()
                .HasConstraintName("FK_TestQuestionOptionAnswer_TestQuestion_AnswerOptions")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
