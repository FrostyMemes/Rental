using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Rental_car
{
    class CarCard
    {
        public string VIN {get; set;}
        public string Registration_number {get; set;}
        public string Brand {get; set;}
        public string Model {get; set;}
        public string Engine_number {get; set;}
        public string Engine_volume {get; set;}
        public string Engine_power {get; set;}
        public string Body_type {get; set;}
        public string Color {get; set;}
        public string Category {get; set;}
        public string Registration_certificate {get; set;}
        public string Passport_series {get; set;}
        public string Passport_number {get; set;}
        public string Owner {get; set;}
        public string Year {get; set;}
        public string Gearbox {get; set;}
        public string Price  {get; set;}
        public string Status {get; set;}
    
        public CarCard(DataTable carInformation)
        {
             VIN                      = carInformation.Rows[0][0].ToString();
             Registration_number      = carInformation.Rows[0][1].ToString();
             Brand                    = carInformation.Rows[0][2].ToString();
             Model                    = carInformation.Rows[0][3].ToString();
             Engine_number            = carInformation.Rows[0][4].ToString();
             Engine_volume            = carInformation.Rows[0][5].ToString();
             Engine_power             = carInformation.Rows[0][6].ToString();
             Body_type                = carInformation.Rows[0][7].ToString();
             Color                    = carInformation.Rows[0][8].ToString();
             Category                 = carInformation.Rows[0][9].ToString();
             Registration_certificate = carInformation.Rows[0][10].ToString();
             Passport_series          = carInformation.Rows[0][11].ToString();
             Passport_number          = carInformation.Rows[0][12].ToString();
             Owner                    = carInformation.Rows[0][13].ToString();
             Year                     = carInformation.Rows[0][14].ToString();
             Gearbox                  = carInformation.Rows[0][15].ToString();
             Price                    = carInformation.Rows[0][16].ToString();
             Status                   = carInformation.Rows[0][17].ToString();
        }
    }
}
