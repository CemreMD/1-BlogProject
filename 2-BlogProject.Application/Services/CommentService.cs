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
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public int CreateComment(CommentDTO commentDTO)
        {
            var comment = mapper.Map<Comment>(commentDTO);
            return unitOfWork.CommentRepo.Add(comment);
        }

        public Task<IEnumerable<CommentDTO>> GetCommentsByArticle(string articleId)
        {
            throw new NotImplementedException();
        }
    }
}
