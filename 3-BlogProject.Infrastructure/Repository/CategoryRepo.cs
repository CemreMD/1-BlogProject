using _1_BlogProject.Core.DomailModels.Models;
using _2_BlogProject.Application.IRepositories;
using _3_BlogProject.Infrastructure.Context;
using _3_BlogProject.Infrastructure.Repository.BaseRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BlogProject.Infrastructure.Repository
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext context) : base(context)
        {

        }
    }
}
