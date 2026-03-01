using BLL.Repository;
using DAL.Data.Services;
using DAL.Entities;
using DAL.Entities.EditEntites;
using DAL.Entities.VehicleEntities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Extensions
{
    internal static class Helper
    {
        public static async Task SetupComboBoxAsync<T>(ComboBox comboBox, IGenericRepository<T> repository) where T : Entity
        {
            var items = await repository.GetAllAsync();

            comboBox.BeginUpdate();

            comboBox.DataSource = items.ToList();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";

            comboBox.EndUpdate();
        }

        public static async Task<List<List<string>>> LoadStaticData()
        {
            var data = new List<List<string>>();
            var cabins = new List<string>
            {
                "كابينة مزدوجة" ,
                "كابينة مفردة",
            };

            var airConditions = new List<string>
            {
                "مكيف" ,
                "غير مكيف",
            };

            List<string> batteryNumber = new List<string>
            {
               "1",
               "2"
            };


            List<string> drivetrains = new List<string>
            {
                "6x6" ,
                "4x2" ,
                "4x4",
                "4x6",
            };

            var fuelTypes = new List<string>
            {
                "بدون",
                "بنزين80",
                "بنزين92",
                "سمر ديزل" ,
                "كهرباء",
                "سولار"
            };

            var gearboxTypes = new List<string>
            {
                "يدوي" ,
                "اوتوماتيك",
                "CVT"
            };

            data.AddRange(cabins, airConditions, batteryNumber, drivetrains, fuelTypes, gearboxTypes);

            return data;
        }


    }
}
