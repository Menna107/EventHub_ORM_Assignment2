using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORM_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Assignment2.Configurations
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BadgeNumber)
                .IsRequired();
            builder.HasIndex(b => b.BadgeNumber)
                .IsUnique();
            builder.Property(b => b.IssueDate).IsRequired();
            builder.Property(b => b.Tier).IsRequired();

            builder.HasOne(b => b.Attendee)
                .WithOne()
                .HasForeignKey<Badge>(b => b.AttendeeId)
                .IsRequired();
        }
    }
}
