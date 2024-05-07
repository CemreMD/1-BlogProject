using _1_BlogProject.Core.DomailModels.Enums;
using _1_BlogProject.Core.DomailModels.Models;
using _2_BlogProject.Application.DTO_s;
using _2_BlogProject.Application.Services.IServices;
using _2_BlogProject.Application.Utilities.IUnitOfWorks;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public int CreateArticle(ArticleDTO articleDTO)
        {
            var article=_mapper.Map<Article>(articleDTO);
            return _unitOfWork.ArticleRepo.Add(article); 
        }

        public async Task< int> DeleteArticle(string articleId)
        {
            var article= await _unitOfWork.ArticleRepo.GetByIdAsync(articleId);
            if (article != null)
            {
                article.DeletedDate= DateTime.Now;
                article.Status = Status.Deleted;
                return _unitOfWork.ArticleRepo.Delete(article);
            }
            return 0;
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllArticlesAsync()
        {
            var articles=await _unitOfWork.ArticleRepo.GetAllAsync(x=>x.Status!=Status.Deleted);
            return _mapper.Map<IEnumerable<ArticleDTO>>(articles);
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllArticlesByCategoryIdAsync(string categoryId)
        {
            var article=await _unitOfWork.ArticleRepo.GetAllAsync(x=>x.CategoryId==categoryId);
            return _mapper.Map<IEnumerable<ArticleDTO>>(article);
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllArticlesByUserIdAsync(string userId)
        {
            var articles = await _unitOfWork.ArticleRepo.GetAllAsync(x => x.AppUserId == userId);
            return _mapper.Map<IEnumerable<ArticleDTO>>(articles);
        }

        public async Task<ArticleDTO> GetArticleByIdAsync(string articleId)
        {
            var article=await _unitOfWork.ArticleRepo.GetByIdAsync(articleId);
            return _mapper.Map<ArticleDTO>(article);
        }

        public int UpdateArticle(ArticleDTO articleDTO)
        {
            var article=_mapper.Map<Article>articleDTO
        }
    }
}
