using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

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

        [HttpGet("Person")]   //Aca va la ruta del servicio, si no especificamos va por defecto el nombre del constructor.
        public async Task <List<Person>> GetPeopleAsync()
        {
            try
            {
                List<Person> persons = await _context.Person.ToListAsync();
                return persons;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
        
        [HttpGet("Customer")]   //Aca va la ruta del servicio, si no especificamos va por defecto el nombre del constructor.
        public async Task <List<Customer>> GetCustomersAsync()
        {
            try
            {
                List<Customer> Customers = await _context.Customer.ToListAsync();
                return Customers;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}
