using _2_BlogProject.Application.IRepositories;
using _2_BlogProject.Application.Utilities.IUnitOfWorks;
using _3_BlogProject.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BlogProject.Infrastructure.Utilities.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context, IAppUserRepo appUserRepo, IArticleRepo articleRepo, ICategoryRepo categoryRepo, ICommentRepo commentRepo)
        {
            _context = context;
            AppUserRepo = appUserRepo;
            ArticleRepo = articleRepo;
            CategoryRepo = categoryRepo;
            CommentRepo = commentRepo;
        }

        public IAppUserRepo AppUserRepo { get; }
        public IArticleRepo ArticleRepo { get; }
        public ICategoryRepo CategoryRepo { get; }
        public ICommentRepo CommentRepo { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync()
        {
           return _context.SaveChangesAsync();
        }
    }
}
