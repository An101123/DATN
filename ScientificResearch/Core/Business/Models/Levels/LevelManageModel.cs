using ScientificResearch.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScientificResearch.Core.Business.Models.Levels
{
    public class LevelManageModel : IValidatableObject
    {
        public string Name { get; set; }

        public void GetLevelFromModel(Level menu)
        {
            menu.Name = Name;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name.Equals(""))
            {
                yield return new ValidationResult("Menu name is required!", new string[] { "Name" });
            }
        }
    }
}
