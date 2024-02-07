using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person : BaseClass
    {      
        public long PersonId { get; set; }
        public int Age { get; set; }
        public String Address { get; set; }
        public String DocumentNumber { get; set; }   
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String Surname { get; set; }         
    }
}
