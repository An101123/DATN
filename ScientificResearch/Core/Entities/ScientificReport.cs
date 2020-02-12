using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScientificResearch.Entities
{
    public class ScientificReport:BaseEntity
    {
        public ScientificReport():base()
        {

        }
        public string Name { get; set; }

        public int ScientificReportTypeId { get; set; }

        public Guid LecturerId { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public virtual ScientificReportType ScientificReportType { get; set; }

        public virtual User User { get; set; }
    }
}
