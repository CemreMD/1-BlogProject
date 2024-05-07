using _2_BlogProject.Application.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Services.IServices
{
    public interface ICategoryService
    {
        Task<CategoryDTO> GetCategoryByIdAsync(string categoryId);
        Task<IEnumerable<CategoryDTO>> GetAllCategoryAsync();
        int CreateCategory(CategoryDTO categoryDTO);
        int UpdateCategory(CategoryDTO categoryDTO);
        Task<int> DeleteCategory(string categoryId);
    }
}
