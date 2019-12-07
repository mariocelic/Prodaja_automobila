using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auti.Models.CarSale
{
    public class Buyer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Kontakt { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
