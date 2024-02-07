using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Customer", Schema = "SalesLT")]
    public class Customer: BaseClass
    {
        public int CustomerID { get; set; }

        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }
        public string? EmailAddress { get; set; }
    }
}
