using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScientificResearch.Entities
{
    public class Role : BaseEntity
    {
        public Role() : base()
        {

        }
        [Required]
        public string Name { get; set; }

        public List<UserInRole> UserInRoles { get; set; }
    }
}
