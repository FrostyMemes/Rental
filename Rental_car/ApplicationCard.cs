using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Rental_car
{
    public class ApplicationCard
    {
        
             
        public string Application_code { get; set; }
        public DateTime Applicatio_date { get; set; }
        public string Client_number { get; set; }
        public string VIN { get; set; }
        public string Child_seat { get; set; }
        public DateTime DateTimeStartRental { get; set; }
        public DateTime DateTimeEndRental { get; set; }
        public int Days { get; set; }
        public int Price { get; set; }
               
        public int PriceAtDay { get; set; }
        public ApplicationCard(string VIN, int Price)
        {
            this.VIN = VIN;
            this.Price = Price;
        }



        public ApplicationCard(DataTable applicationInformation)
        {
            Application_code        = applicationInformation.Rows[0][0].ToString();
            Applicatio_date         = DateTime.Parse(applicationInformation.Rows[0][1].ToString()); 
            Client_number           = applicationInformation.Rows[0][2].ToString();
            VIN                     = applicationInformation.Rows[0][3].ToString();
            Child_seat              = applicationInformation.Rows[0][4].ToString();          
            DateTimeStartRental     = DateTime.Parse(applicationInformation.Rows[0][5].ToString());
            DateTimeEndRental       = DateTime.Parse(applicationInformation.Rows[0][6].ToString());
            Days                    = int.Parse(applicationInformation.Rows[0][7].ToString());
            Price                   = int.Parse(applicationInformation.Rows[0][8].ToString());
            PriceAtDay              = Price / Days;
        }
    }
}
