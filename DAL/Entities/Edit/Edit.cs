using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.EditEntites
{
    public class Edit :Entity
    {
        public int Id { get; set; }

        public int PreparationId { get; set; }
        public Preparation Preparation { get; set; }

        public int UsageId { get; set; }
        public Usage Usage { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
