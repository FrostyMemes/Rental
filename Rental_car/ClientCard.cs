using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Rental_car
{
    class  ClientCard
    {

        public string Client_number { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }
        public string Passport_series { get; set; }
        public string Passport_number { get; set; }
        public string Passport_date { get; set; }
        public string Driver_certificate_code { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Contact_telephone { get; set; }
        public string Address { get; set; }
        public string Registration_date { get; set; }

        public ClientCard(DataTable clientInformation)
        {
            Client_number               = clientInformation.Rows[0][0].ToString();
            Email                       = clientInformation.Rows[0][1].ToString();
            Password                    = clientInformation.Rows[0][2].ToString();
            Surname                     = clientInformation.Rows[0][3].ToString();
            Name                        = clientInformation.Rows[0][4].ToString();
            Fathername                  = clientInformation.Rows[0][5].ToString();
            Passport_series             = clientInformation.Rows[0][6].ToString();
            Passport_number             = clientInformation.Rows[0][7].ToString();
            Passport_date               = clientInformation.Rows[0][8].ToString();
            Driver_certificate_code     = clientInformation.Rows[0][9].ToString();
            Birthday                    = clientInformation.Rows[0][10].ToString();
            Gender                      = clientInformation.Rows[0][11].ToString();
            Contact_telephone           = clientInformation.Rows[0][12].ToString();
            Address                     = clientInformation.Rows[0][13].ToString();
            Registration_date           = clientInformation.Rows[0][14].ToString();
        }
    }
}
