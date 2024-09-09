using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasmBlazorAppAssignment.Shared.Enums;

namespace WasmBlazorAppAssignment.Shared.Entities
{
    public class VehicleSaleDetails
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public VehicleClassification Classification { get; set; }
        public double Cost { get; set; }
        public double MSRP { get; set; }
    }

}
