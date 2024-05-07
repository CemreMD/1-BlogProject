using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BlogProject.Core.DomainServices
{
    public class NormalizedUrl
    {
        public static string TurkishToEnglish(string name)
        {
            string turkishCharacter = "ığüşöç ";
            string EnglishCharacter = "igusoc-";
            for (int i = 0; i<turkishCharacter.Length; i++)
            {
                name = name.ToLower().Replace(turkishCharacter[i], EnglishCharacter[i]);
            }
            return name;
        }
    }
}
