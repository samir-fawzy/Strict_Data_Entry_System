using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SpecClasses
{
    public class Filter
    {
        public string? Enigne { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Payload { get; set; }
        public string? VehicleNumber { get; set; }
        public string? ChassisNumber { get; set; }
        public string? BatterySize { get; set; }
        public string? TireSize { get; set; }
        public string? UnitName { get; set; }
        public string? Usage { get; set; }
        public string? Preparation { get; set; }
        public string? Status { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
