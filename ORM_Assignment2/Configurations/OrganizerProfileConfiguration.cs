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
    internal class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(op => op.Id);
            builder.Property(op => op.Bio).HasMaxLength(500);
            builder.Property(op => op.Website).HasMaxLength(200);
            builder.Property(op => op.Logo).HasMaxLength(200);

            builder.HasOne(op => op.Organizer)
                .WithOne(o => o.OrganizerProfile)
                .HasForeignKey<OrganizerProfile>(op => op.OrganizerId);
        }
    }
}
