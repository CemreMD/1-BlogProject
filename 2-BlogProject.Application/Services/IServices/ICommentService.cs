using _2_BlogProject.Application.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Services.IServices
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentDTO>> GetCommentsByArticle(string articleId);
        int CreateComment(CommentDTO commentDTO);
    }
}
