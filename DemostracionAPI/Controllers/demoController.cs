using Castle.Core.Resource;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Common;
using System.Linq.Expressions;
using System.Net.Mail;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        
        [HttpGet("Customer/PagedData")]   
        public async Task <PagedDataResponse<Customer>> GetCustomersPagedAsync([FromQuery] PagedDataRequest request)
        {
            try
            {
                var pagedDataResponse = new PagedDataResponse<Customer>();
                IList<Customer> customers = new List<Customer>();

                #region Filtrado
                if (!string.IsNullOrEmpty(request.FilterBy) && !string.IsNullOrEmpty(request.FilterValue))
                {
                    var query = _context.Customers.AsQueryable();
                    switch (request.FilterBy)
                    {
                        case "CustomerID":
                            query = query.Where(c => c.CustomerID.ToString() == request.FilterValue);
                            break;
                        case "Title":
                            query = query.Where(c => c.Title == request.FilterValue);
                            break;
                        case "FirstName":
                            query = query.Where(c => c.FirstName == request.FilterValue);
                            break;
                        case "MiddleName":
                            query = query.Where(c => c.MiddleName == request.FilterValue);
                            break;
                        case "LastName":
                            query = query.Where(c => c.LastName == request.FilterValue);
                            break;
                        case "CompanyName":
                            query = query.Where(c => c.CompanyName == request.FilterValue);
                            break;
                        case "EmailAddress":
                            query = query.Where(c => c.EmailAddress == request.FilterValue);
                            break;
                        default:
                            break;
                    }
                    customers = await query.ToListAsync();
                }
                #endregion

                #region Ordenamiento
                if (!string.IsNullOrEmpty(request.OrderBy))
                {
                    var query = _context.Customers.AsQueryable();
                    switch (request.OrderBy)
                    {
                        case "CustomerID":
                            query = query.OrderBy(c => c.CustomerID.ToString() == request.FilterValue);
                            break;
                        case "Title":
                            query = query.OrderBy(c => c.Title == request.FilterValue);
                            break;
                        case "FirstName":
                            query = query.OrderBy(c => c.FirstName == request.FilterValue);
                            break;
                        case "MiddleName":
                            query = query.OrderBy(c => c.MiddleName == request.FilterValue);
                            break;
                        case "LastName":
                            query = query.OrderBy(c => c.LastName == request.FilterValue);
                            break;
                        case "CompanyName":
                            query = query.OrderBy(c => c.CompanyName == request.FilterValue);
                            break;
                        case "EmailAddress":
                            query = query.OrderBy(c => c.EmailAddress == request.FilterValue);
                            break;
                        default:
                            break;
                    }
                    customers = await query.ToListAsync();
                }
                #endregion

                #region Paginado
                // Calcula el índice de inicio de la fila basado en el número de página y el tamaño de la página
                var startIndex = (request.PageNumber - 1) * request.PageSize;
                // Consulta la base de datos para obtener el total de elementos
                var totalCount = await _context.Customers.CountAsync();
                // Consulta la base de datos para obtener los registros de la página actual
                customers = await _context.Customers.Skip(startIndex).Take(request.PageSize).ToListAsync();
                // Calcula el total de páginas basado en el tamaño de la página y el total de elementos
                var totalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize);
                #endregion
                
                // Cargo la respuesta paginada
                pagedDataResponse.Results = customers.ToList();
                pagedDataResponse.PageNumber = request.PageNumber;
                pagedDataResponse.PageSize = request.PageSize;
                pagedDataResponse.PageCount = totalPages;
                pagedDataResponse.RowCount = totalCount;

                return pagedDataResponse;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}
