using DAL.Entities.EditEntites;
using DAL.Entities.VehicleEntities;
using DAL.EntitiesNotInDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.VehicleEntities
{
    public class VehicleHistory : Entity
    {
        public DateTime Date { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } // ده مكتوب صح

        // --- الخصائص النصية ---
        public string VehicleNumber { get; set; }
        public string ChassisNumber { get; set; }
        public string BatteryNumber { get; set; }
        public string DrivetrainType { get; set; }
        public string AirConditioning { get; set; }
        public string FuelType { get; set; }
        public string Gearbox { get; set; }
        public string Cabins { get; set; }

        // --- الـ Foreign Keys ---
        public int ModelId { get; set; }
        public int EngineId { get; set; }
        public int PayloadId { get; set; }
        public int BatterySizeId { get; set; }
        public int TireSizeId { get; set; }
        public int TireNumberId { get; set; }


        // 🚨 ضيف الكائنات دي عشان تجيب الأسماء وقت السجل 🚨
        public Engine Engine { get; set; }
        public Model Model { get; set; }
        public Payload Payload { get; set; }
        public BatterySize BatterySize { get; set; }
        public TireSize TireSize { get; set; }
        public TireNumber TireNumber { get; set; }

        public int PreparationId { get; set; }
        public int UsageId { get; set; }
        public int StatusId { get; set; }
        public int UnitId { get; set; }

        public Preparation Preparation { get; set; }
        public Usage Usage { get; set; }
        public Status Status { get; set; }
        public Unit Unit { get; set; }

    }
}
