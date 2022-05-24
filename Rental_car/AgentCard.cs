using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Rental_car
{
    class AgentCard
    {
        public string Agent_number { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }
        public string Passport_series { get; set; }
        public string Passport_number { get; set; }      
        public string Birthday { get; set; }
        public string Contact_telephone { get; set; }
        public string Address { get; set; }

        public AgentCard(DataTable agentInformation)
        {
            Agent_number        = agentInformation.Rows[0][0].ToString();
            Email               = agentInformation.Rows[0][1].ToString();
            Password            = agentInformation.Rows[0][2].ToString();
            Surname             = agentInformation.Rows[0][3].ToString();
            Name                = agentInformation.Rows[0][4].ToString();
            Fathername          = agentInformation.Rows[0][5].ToString();
            Passport_series     = agentInformation.Rows[0][6].ToString();
            Passport_number     = agentInformation.Rows[0][7].ToString();
            Birthday            = agentInformation.Rows[0][8].ToString();
            Contact_telephone   = agentInformation.Rows[0][9].ToString();
            Address             = agentInformation.Rows[0][10].ToString();
        }
    }
}
