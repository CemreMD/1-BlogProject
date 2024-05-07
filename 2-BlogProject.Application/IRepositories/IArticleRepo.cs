using _1_BlogProject.Core.DomailModels.Models;
using _2_BlogProject.Application.IRepositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.IRepositories
{
    public interface IArticleRepo:IBaseRepo<Article>
    {
    
    }
}
