using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_car
{
    public partial class ClientDetailScreen : Form
    {
        public ClientDetailScreen()
        {
            InitializeComponent();
        }

        private void ClientDetailScreen_Load(object sender, EventArgs e)
        {
           

            labelName.Text                  += Program.clientCard.Name;
            labelFathername.Text            += Program.clientCard.Fathername;
            labelSurname.Text               += Program.clientCard.Surname;
            labelEmail.Text                 += Program.clientCard.Email;
            labelTelephone.Text             += Program.clientCard.Contact_telephone;
            labelSeriesPassport.Text        += Program.clientCard.Passport_series;
            labelNumberPassport.Text        += Program.clientCard.Passport_number;
            labelBirth.Text                 += Program.clientCard.Birthday;
            labelGender.Text                += Program.clientCard.Gender;
            labelDriverCode.Text            += Program.clientCard.Driver_certificate_code;
            labelRegistrationDate.Text      += Program.clientCard.Registration_date;
            txtAddress.Text                 += Program.clientCard.Address;

            try
            {
                this.getClientApplicationForAgentTableAdapter.Fill(this.dBDataSet.GetClientApplicationForAgent, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.clientCard.Client_number, typeof(int))))));
                this.getClientDamagedCarsTableAdapter.Fill(this.dBDataSet.GetClientDamagedCars, Program.clientCard.Passport_series, Program.clientCard.Passport_number);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
        
    }
}
