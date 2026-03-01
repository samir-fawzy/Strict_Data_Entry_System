using DAL.Entities.EditEntites;
using DAL.Entities.VehicleEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Project : Entity
    {
        // بناءً على المعينات (Diamonds) الخارجة من Projects في الأسفل
        // المشروع مرتبط بـ Vehicle و Vehicle_History و Unit و Edits

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public int VehicleHistoryId { get; set; }
        public VehicleHistory VehicleHistory { get; set; }

      

        public int EditId { get; set; }
        public Edit Edit { get; set; }

        public int UnitId { get; set; } 
        public Unit Unit { get; set; }
    }
}
