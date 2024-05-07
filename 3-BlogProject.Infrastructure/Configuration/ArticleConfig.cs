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
    public class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasMany(a => a.Comments).WithOne(c => c.Article).HasForeignKey(c => c.ArticleId);
        }
    }
}
