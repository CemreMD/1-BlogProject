using _2_BlogProject.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Utilities.IUnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
        IAppUserRepo AppUserRepo { get; }
        IArticleRepo ArticleRepo { get; }
        ICategoryRepo CategoryRepo { get; }
        ICommentRepo CommentRepo { get; }
        Task<int>SaveAsync();
    }
}
