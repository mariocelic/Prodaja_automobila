using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auti.Models.CarSale
{
    public class Salesman
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
