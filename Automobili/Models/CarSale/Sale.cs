using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auti.Models.CarSale
{
    public class Sale
    {
        public int Id { get; set; }

        public string CarName { get; set; }
        public Car Car { get; set; }

        public float Price { get; set; }

        public string SalesmenName { get; set; }
        public Salesman Salesmen { get; set; }

        public string BuyerName { get; set; }
        public Buyer Buyer { get; set; }
    }
}
