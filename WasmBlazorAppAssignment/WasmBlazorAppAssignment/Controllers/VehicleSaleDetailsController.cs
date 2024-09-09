using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WasmBlazorAppAssignment.Data;
using WasmBlazorAppAssignment.Shared.Entities;

namespace WasmBlazorAppAssignment.Controllers
{
    [Route("api/vehiclesaledetails")]
    [ApiController]
    public class VehicleSaleDetailsController : ControllerBase
    {

        private readonly DataContext _context;

        public VehicleSaleDetailsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VehicleSaleDetails>>> GetAllVehiclesAsync()
        {
            return await _context.VehicleSaleDetails.ToListAsync();
        }
    }
}
