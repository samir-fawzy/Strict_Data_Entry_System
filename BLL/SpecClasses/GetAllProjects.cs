using BLL.Specification;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SpecClasses
{
    public class GetAllProjects : GenericSpecification<Project>
    {
        public GetAllProjects(Filter f)
                    // التعديل السحري هنا: الفلتر بيشتغل بس لو فيه قيمة
                    : base(p =>
                        (string.IsNullOrEmpty(f.Enigne) || p.Vehicle.Engine.Name == f.Enigne) &&
                        (string.IsNullOrEmpty(f.Brand) || p.Vehicle.Model.Brand.Name == f.Brand) &&
                        (string.IsNullOrEmpty(f.Model) || p.Vehicle.Model.Name == f.Model) &&
                        (string.IsNullOrEmpty(f.VehicleNumber) || p.Vehicle.VehicleNumber == f.VehicleNumber) &&
                        (string.IsNullOrEmpty(f.ChassisNumber) || p.Vehicle.ChassisNumber == f.ChassisNumber) &&

                        (!f.Start.HasValue || p.VehicleHistory.Date >= f.Start.Value.Date) &&
                        (!f.End.HasValue || p.VehicleHistory.Date < f.End.Value.Date.AddDays(1))
                    )
        {
            AddInclude("Unit");
            AddInclude("Edit");
            AddInclude("Vehicle");
            AddInclude("VehicleHistory");

            // 2. الجداول المتداخلة جوه Vehicle
            AddInclude("Vehicle.Model.Brand"); // بيجيب الـ Model والـ Brand مع بعض
            AddInclude("Vehicle.Engine");      // كان ناقص
            AddInclude("Vehicle.Payload");
            AddInclude("Vehicle.TireSize");
            AddInclude("Vehicle.TireNumber");
            AddInclude("Vehicle.BatterySize");

            // 3. الجداول المتداخلة جوه Edit
            AddInclude("Edit.Preparation");
            AddInclude("Edit.Usage");
            AddInclude("Edit.Status");

            EnableNoTracking();
        }

        public object Vehicle { get; internal set; }
    }
}
