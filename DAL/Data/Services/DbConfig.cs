using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Services
{
    public class DbConfig
    {
        public static AppDbContext CreateContext()
        {
            var connectionString = "Server=.;Database=MahmoudProjectDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new AppDbContext(options);
        }
    }
}
