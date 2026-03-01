using BLL.Specification;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SpecClasses
{
    public class GetByVehicleNumSpec : GenericSpecification<Project>
    {
        public GetByVehicleNumSpec(string vehicleNum,string chassisNum) : base(p => p.Vehicle.VehicleNumber == vehicleNum ||
                                                                                    p.Vehicle.ChassisNumber == chassisNum)
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
            AddInclude("Vehicle.BatterySize");
            AddInclude("Vehicle.TireNumber");

            // 3. الجداول المتداخلة جوه Edit
            AddInclude("Edit.Preparation");
            AddInclude("Edit.Usage");
            AddInclude("Edit.Status");

            EnableNoTracking();
        }
    }
}
