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
    public class CommentConfig:IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
          
            builder.HasOne(c=>c.User).WithMany(c=>c.Comments).HasForeignKey(c=>c.AppUserId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
