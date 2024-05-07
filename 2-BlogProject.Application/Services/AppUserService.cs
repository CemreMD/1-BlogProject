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
    public class AppUserService : IAppUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppUserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public int CreateUserAsync(AppUserDTO user)
        {
            var appUser = _mapper.Map<AppUser>(user);
            return _unitOfWork.AppUserRepo.Add(appUser);

        }

        public async Task<int> DeleteUserAsync(string userId)
        {
            var appUser=await _unitOfWork.AppUserRepo.GetByIdAsync(userId);
            return _unitOfWork.AppUserRepo.Delete(appUser);
        }

        public async Task<IEnumerable<AppUserDTO>> GetUserAsync()
        {
            var appUsers=await _unitOfWork.AppUserRepo.GetAllAsync();
            return _mapper.Map<AppUserDTO>(appUsers);
        }

        public Task<AppUserDTO> GetUserByIdAsync(string userId)
        {
            var AppUser = await _unitOfWork.AppUserRepo.GetByIdAsync(userId);
            return _mapper.Map<AppUserDTO>(AppUser);
        }

        public Task<int> UpdateUserAsync(AppUserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
