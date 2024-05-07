using _1_BlogProject.Core.DomailModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BlogProject.Infrastructure.Configuration
{
    internal class UserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasMany(u => u.articles).WithOne(u => u.user).HasForeignKey(a => a.AppUserId);
            builder.HasMany(u=>u.Comments).WithOne(u => u.User).HasForeignKey(c=>c.AppUserId);
        }
    }
}
