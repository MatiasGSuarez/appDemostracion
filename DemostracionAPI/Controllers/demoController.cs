using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Common;

namespace DemostracionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class demoController : ControllerBase
    {
        private readonly DbModelContext _context;

        public demoController(DbModelContext context){
            _context = context;
        }

        //Aca va la ruta del servicio, si no especificamos va por defecto el nombre del constructor.
        [HttpGet("Customer")]   
        public async Task <List<Customer>> GetCustomersAsync()
        {
            try
            {
                var Customers = await _context.Customers.ToListAsync();
                return Customers;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}
