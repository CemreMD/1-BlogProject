using _1_BlogProject.Core.DomailModels.BaseModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BlogProject.Core.DomailModels.Models
{
    public class AppUser:IdentityUser,IBaseEntity
    {
        private string _firstName;


        private string normalizedFirstName;

        public string NormalizedFirstName
        {
            get { return normalizedFirstName; }
            set { normalizedFirstName = value; }
        }
        private string normalizedLastName;

        public string NormalizedLastName
        {
            get { return normalizedLastName; }
            set { normalizedLastName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public string Firstname
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string fullName { get { return _firstName + "" + lastName; } }

        public virtual ICollection<Article> articles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
