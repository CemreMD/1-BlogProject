using _2_BlogProject.Application.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Services.IServices
{
    public interface IArticleService
    {
        Task<ArticleDTO> GetArticleByIdAsync(string articleId);
        Task<IEnumerable<ArticleDTO>> GetAllArticlesAsync();
        Task<IEnumerable<ArticleDTO>> GetAllArticlesByUserIdAsync(string userId);
        Task<IEnumerable<ArticleDTO>> GetAllArticlesByCategoryIdAsync(string categoryId);

        int CreateArticle(ArticleDTO articleDTO);
        int UpdateArticle(ArticleDTO articleDTO);
        Task<int> DeleteArticle(string articleId);
    }
}
