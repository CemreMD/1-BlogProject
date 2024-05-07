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
    public class CommentRepo : BaseRepo<Comment>, ICommentRepo
    {
        private readonly AppContext _appDbContext;
        public CommentRepo(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public async Task<IEnumerable<Comment>> GetAllByArticleId(string id)
        {
            return await _appDbContext.Comment.GetAllByArticleIdAsync(id);
        }
    }
}
