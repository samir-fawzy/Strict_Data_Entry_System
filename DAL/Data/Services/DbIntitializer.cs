using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Services
{
    public class DbIntitializer
    {
        public static void EnsureMigrationSaved(AppDbContext context)
        {
            try
            {

                context.Database.Migrate();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Migration failed: {ex.Message}");
                Console.WriteLine("Falling back to EnsureCreated...");
                context.Database.EnsureCreated();
            }
            

        }
    }
}
