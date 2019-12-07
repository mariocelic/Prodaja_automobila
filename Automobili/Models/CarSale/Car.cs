using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auti.Models.CarSale
{
    public class Car
    {
        public int Id { get; set; }
        public string CarMaker { get; set; }
        public string CarModel { get; set; }

        public int YearManufacture { get; set; }
        public string Description { get; set; }
        public List<Sale> Sales { get; set; }

    }
}
