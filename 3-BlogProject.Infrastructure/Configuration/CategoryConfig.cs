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
    public class CategoryConfig:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(c=>c.Articles).WithOne(c=>c.Category).HasForeignKey(c=>c.CategoryId);
        }
    }
}
