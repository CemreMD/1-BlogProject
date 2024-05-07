using _1_BlogProject.Core.DomailModels.Enums;
using _1_BlogProject.Core.DomailModels.Models;
using _2_BlogProject.Application.DTO_s;
using _2_BlogProject.Application.IRepositories;
using _2_BlogProject.Application.Services.IServices;
using _2_BlogProject.Application.Utilities.ILogging;
using _2_BlogProject.Application.Utilities.IUnitOfWorks;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly ILogging _logging;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateCategory(CategoryDTO categoryDTO)
        {
           var cat =_mapper.Map<Category>(categoryDTO);
            return _unitOfWork.CategoryRepo.Add(cat);
        }

        public async Task<int> DeleteCategory(string categoryId)
        {
            var cat=await _unitOfWork.CategoryRepo.GetByIdAsync(categoryId);
            cat.DeletedDate = DateTime.Now;
            cat.Status=Status.Deleted;
            //_logging.LogError("Delete işlemi yapıldı");
            return _unitOfWork.CategoryRepo.Delete(cat);
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoryAsync()
        {
            var cats = await _unitOfWork.CategoryRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(cats);
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(string categoryId)
        {
            var cat = await _unitOfWork.CategoryRepo.GetByIdAsync(categoryId);
            return _mapper.Map<CategoryDTO>(cat);
        }

        public int UpdateCategory(CategoryDTO categoryDTO)
        {
            var cat=_mapper.Map<Category>(categoryDTO);
            cat.UpdatedDate= DateTime.Now;
            cat.Status = Status.Updated;
            return _unitOfWork.CategoryRepo.Update(cat);
        }
    }
}
