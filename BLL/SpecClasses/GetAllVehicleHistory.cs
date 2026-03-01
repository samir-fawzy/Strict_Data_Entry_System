using BLL.Specification;
using DAL.Entities.VehicleEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SpecClasses
{
    public class GetAllVehicleHistory : GenericSpecification<VehicleHistory>
    {
        public GetAllVehicleHistory(FilterVehicleHistory f) : base(vh =>
                    // 🛠️ التصحيح: استخدام == null أو !HasValue بدلاً من != null
                    (!f.EnigneId.HasValue || vh.EngineId == f.EnigneId) &&
                    (!f.ModelId.HasValue || vh.ModelId == f.ModelId) &&
                    (string.IsNullOrEmpty(f.VehicleNumber) || vh.VehicleNumber == f.VehicleNumber) &&
                    (string.IsNullOrEmpty(f.ChassisNumber) || vh.ChassisNumber == f.ChassisNumber) &&

                    // فلتر التاريخ
                    (!f.Start.HasValue || vh.Date >= f.Start.Value.Date) &&
                    (!f.End.HasValue || vh.Date < f.End.Value.Date.AddDays(1))
                )
        {
            AddInclude("Vehicle");

            // 🚨 مسحنا AddInclude("Edit") لأن مفيش جدول Edit جوه الهيستوري
            // وبدلناه بالجداول المباشرة الخاصة بالتعديل والوحدة
            AddInclude("Preparation");
            AddInclude("Usage");
            AddInclude("Status");

            AddInclude("Unit");

            AddInclude("Engine");
            AddInclude("Model.Brand");
            AddInclude("Payload");
            AddInclude("TireSize");
            AddInclude("BatterySize");
            AddInclude("TireNumber");

        }
    }
}
