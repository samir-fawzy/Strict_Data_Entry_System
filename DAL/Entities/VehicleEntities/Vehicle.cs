using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using DAL.EntitiesNotInDB;

namespace DAL.Entities.VehicleEntities
{
    public class Vehicle : Entity
    {
        // الخصائص النصية والرقمية 
        public string VehicleNumber { get; set; }
        public string ChassisNumber { get; set; }
        
        public string BatteryNumber { get; set; }
        public string DrivetrainType { get; set; }

        // 1. التعديل الأول: شيلنا الـ ICollection من الـ Enums
        // العربية هتاخد قيمة واحدة بس من الـ Enum وتتحفظ كرقم في الداتابيز
        public string AirConditioning { get; set; }
        public string Fuel { get; set; } // غيرت اسمها لـ Fuel عشان متتعارضش مع اسم الـ Enum
        public string Gearbox { get; set; }
        public string Cabin { get; set; }

        // العلاقات (Foreign Keys & Navigation Properties)

        public int ModelId { get; set; }
        public Model Model { get; set; }

        public int EngineId { get; set; }
        public Engine Engine { get; set; } // علاقة مفردة

        public int PayloadId { get; set; }
        public Payload Payload { get; set; } // علاقة مفردة

        public int BatterySizeId { get; set; }
        public BatterySize BatterySize { get; set; } // علاقة مفردة

        public int TireSizeId { get; set; }
        public TireSize TireSize { get; set; } // علاقة مفردة

        public int TireNumberId { get; set; }
        public TireNumber TireNumber { get; set; } // علاقة مفردة

    }

    //public enum DrivetrainType
    //{
    //    FWD,        // جر أمامي
   //    RWD,        // دفع خلفي
    //    AWD,        // دفع كلي مستمر
    //    FourWD      // دفع رباعي
    //}

    //public enum AirConditioningType
    //{
    //    غيرمكيف,    // بدون تكييف
    //    مكيف,       // تكييف مانيوال
    //}

    //public enum FuelType
    //{
    //    بدون,
    //    بنزين80,
    //    بنزين92,
    //    سمرديزل,
    //    سولار,
    //    كهرباء
    //}

    //public enum GearboxType
    //{
    //    مانيوال,
    //    اوتوماتك,
    //    CVT
    //}

    //public enum CabinType
    //{
    //    كابينةمزدوجة,
    //    كابينةمفردة
    //}

}

