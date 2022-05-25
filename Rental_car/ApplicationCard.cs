using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_car
{
    public class ApplicationCard
    {
        public DateTime DateTimeStartRental { get; set; }
        public DateTime DateTimeEndRental { get; set; }
        public string VIN { get; set; }
        public int ApplicationCode { get; set; }
        public int Price { get; set; }
        public int Days { get; set; }

        public ApplicationCard(string VIN, int Price)
        {
            this.VIN = VIN;
            this.Price = Price;
        }
        public ApplicationCard(int applicationCode)
        {
            ApplicationCode = applicationCode;
        }

    }
}
