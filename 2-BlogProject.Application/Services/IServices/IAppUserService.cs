using _2_BlogProject.Application.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Services.IServices
{
    public interface IAppUserService
    {
        Task<AppUserDTO> GetUserByIdAsync(string userId);
        Task<IEnumerable<AppUserDTO>> GetUserAsync();

        int CreateUserAsync(AppUserDTO user);

        int UpdateUserAsync(AppUserDTO user);
        Task<int> DeleteUserAsync(string userId);
    }
}
