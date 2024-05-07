using _1_BlogProject.Core.DomailModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BlogProject.Core.DomailModels.Models
{
    public class Comment:BaseEntity,IBaseEntity //Generic bir yapı kurduğumuz için IbaseEntity üzerinden yapacağız
    {
        public string Content { get; set; }
        public string AppUserId { get; set; }
        public string ArticleId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual Article Article { get; set; }
    }
}
