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
    public class AppUserRepo : BaseRepo<AppUser>, IAppUserRepo
        
    {
        private readonly AppDbContext _context;

        public AppUserRepo(AppDbContext context) :base(context)
        {
            _context = context;
        }

        public async Task<AppUser> GetUserByEmailAsync(string userEmail)
        {
           return await _context.Users.FirstOrDefaultAsync(u=>u.Email== userEmail);
        }

        public async Task<AppUser> GetUserByNameAsync(string userName)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
        }
    }
}
