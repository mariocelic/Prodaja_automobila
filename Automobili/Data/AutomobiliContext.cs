using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Automobili.Data
{
    public class AutomobiliContext : DbContext
    {
       public DbSet<Auti.Models.CarSale.Buyer> Buyers { get; set; }
       public DbSet<Auti.Models.CarSale.Car> Cars { get; set; }
       public DbSet<Auti.Models.CarSale.Sale> Sales{ get; set; }
       public DbSet<Auti.Models.CarSale.Salesman> Salesmens { get; set; }

        public AutomobiliContext()
            : base("name=DefaultConnection")
        {

        }


    }
}