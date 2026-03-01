using DAL.Entities;
using DAL.Entities.EditEntites;
using DAL.Entities.VehicleEntities;
using DAL.EntitiesNotInDB;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply all IEntityTypeConfiguration<T> implementations from this assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
        // DbSet properties for your entities can be added here
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }   
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Payload> Payloads { get; set; }    
        public DbSet<BatterySize> BatterySizes { get; set; }
        public DbSet<TireSize> TireSizes { get; set; }
        public DbSet<TireNumber> TireNumbers { get; set; }
        public DbSet<Edit> Edits { get; set; }
        public DbSet<VehicleHistory> VehicleHistories { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Preparation> Preparations { get; set; }
        public DbSet<Usage> Usages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
    
    
}
