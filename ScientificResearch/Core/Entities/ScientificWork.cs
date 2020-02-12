using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScientificResearch.Entities
{
    public class ScientificWork:BaseEntity
    {
        public ScientificWork():base()
        {

        }
        public string Name { get; set; }

        public string Content { get; set; }

        public DateTime Time { get; set; }

        public int LevelId { get; set; }

        public int LecturerId { get; set; }

        public virtual Level Level { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public virtual User User { get; set; }
    }
}
