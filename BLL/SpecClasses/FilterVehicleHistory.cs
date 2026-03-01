using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SpecClasses
{
    public class FilterVehicleHistory
    {
        public int? EnigneId { get; set; }
        public int? BrandId { get; set; }
        public int? ModelId { get; set; }
        public int? PayloadId { get; set; }
        public string? VehicleNumber { get; set; }
        public string? ChassisNumber { get; set; }
        public int? BatterySizeId { get; set; }
        public int? TireSizeId { get; set; }
        public int? UnitNameId { get; set; }
        public int? UsageId { get; set; }
        public int? PreparationId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
