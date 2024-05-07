using _1_BlogProject.Core.DomailModels.BaseModels;
using _1_BlogProject.Core.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _1_BlogProject.Core.DomailModels.Models
{
    public class Category:BaseEntity,IBaseEntity
    {
        public string Name { get; set; }
        public string url { get { return NormalizedUrl.TurkishToEnglish(Name); } } //Türkçe ingilizce karakterleri çevirsin 

        public virtual ICollection<Article>Articles { get; set; }
       
    }
}
