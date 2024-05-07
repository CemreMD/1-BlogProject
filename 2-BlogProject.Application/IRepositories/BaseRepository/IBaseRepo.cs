using _1_BlogProject.Core.DomailModels.BaseModels;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.IRepositories.BaseRepository
{
    public interface IBaseRepo<T>where T:IBaseEntity 
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>>GetAllAsync(Expression<Func<T, bool>> filter=null);//Boş geçilebilir
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        Task<TResult> GetFilteredModelAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null
            );
        Task<IList<TResult>> GetFilteredListModelAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null
            );
        int Add(T entity );
        int Update(T entity );  
        int Delete(T entity );
    }
}
