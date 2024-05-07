using _1_BlogProject.Core.DomailModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BlogProject.Core.DomailModels.Models
{
    public class Article:BaseEntity,IBaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string CategoryId { get; set; }
        public string  AppUserId { get; set; }
        public virtual AppUser user { get; set; }
        public virtual Category  Category{ get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
