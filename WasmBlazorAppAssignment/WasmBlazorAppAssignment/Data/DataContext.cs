using Microsoft.EntityFrameworkCore;
using WasmBlazorAppAssignment.Shared.Entities;
using WasmBlazorAppAssignment.Shared.Enums;

namespace WasmBlazorAppAssignment.Data
{
    public class DataContext : DbContext
    {

        public DbSet<VehicleSaleDetails> VehicleSaleDetails { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleSaleDetails>().HasData(
                       new VehicleSaleDetails
                       {
                           Id = 1,
                           Make = "Audi",
                           Model = "A4",
                           Colour = "Red",
                           Classification = VehicleClassification.Sedan,
                           Cost = 1500,
                           MSRP = 3000
                       },
                       new VehicleSaleDetails
                       {
                           Id = 2,
                           Make = "Chevrolet",
                           Model = "Camaro",
                           Classification = VehicleClassification.Convertible,
                           Colour = "Blue",
                           Cost = 4000,
                           MSRP = 9000
                       },
                       new VehicleSaleDetails
                       {
                           Id = 3,
                           Make = "Dodge",
                           Model = "Ram",
                           Colour = "Red",
                           Classification = VehicleClassification.SUV,
                           Cost = 5000,
                           MSRP = 12000
                       },
            new VehicleSaleDetails
            {
                Id = 4,
                Make = "Audi",
                Model = "A4",
                Colour = "Black",
                Classification = VehicleClassification.SUV,
                Cost = 1500,
                MSRP = 3000
            },
                       new VehicleSaleDetails
                       {
                           Id = 5,
                           Make = "Chevrolet",
                           Model = "Camaro",
                           Colour = "Blue",
                           Classification = VehicleClassification.Sedan,
                           Cost = 40000,
                           MSRP = 50000
                       },
                       new VehicleSaleDetails
                       {
                           Id = 6,
                           Make = "Dodge",
                           Model = "Ram",
                           Classification = VehicleClassification.Sedan,
                           Colour = "Red",
                           Cost = 5000,
                           MSRP = 12000
                       });

        }
    }
}
