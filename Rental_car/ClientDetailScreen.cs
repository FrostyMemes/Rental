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
            DisplayClientInformation();
        }
    

        public void DisplayClientInformation()
        {
            labelName.Text                  = "Имя: " + Program.clientCard.Name;
            labelFathername.Text            = "Отчество: " + Program.clientCard.Fathername;
            labelSurname.Text               = "Фамилия: " + Program.clientCard.Surname;
            labelEmail.Text                 = "Email: " + Program.clientCard.Email;
            labelTelephone.Text             = "Телефон: " + Program.clientCard.Contact_telephone;
            labelSeriesPassport.Text        = "Серия паспорта: " + Program.clientCard.Passport_series;
            labelNumberPassport.Text        = "Номер паспорта: " + Program.clientCard.Passport_number;
            labelBirth.Text                 = "День рождения: " + Program.clientCard.Birthday;
            labelGender.Text                = "Пол: " + Program.clientCard.Gender;
            labelDriverCode.Text            = "Код вод. удостоверения: " + Program.clientCard.Driver_certificate_code;
            labelRegistrationDate.Text      = "Дата регистрации: " + Program.clientCard.Registration_date;
            txtAddress.Text                 = "Адрес: " + Program.clientCard.Address;

            try
            {
                this.getClientApplicationForAgentTableAdapter.Fill(this.dBDataSet.GetClientApplicationForAgent, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.clientCard.Client_number, typeof(int))))));
                this.getClientDamagedCarsTableAdapter.Fill(this.dBDataSet.GetClientDamagedCars, Program.clientCard.Passport_series, Program.clientCard.Passport_number);
                this.getClientInvoicesTableAdapter.Fill(this.dBDataSet.GetClientInvoices, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.clientCard.Client_number, typeof(int))))));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void getClientInvoicesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.getInvoiceContentTableAdapter.Fill(this.dBDataSet.GetInvoiceContent, new System.Nullable<int>(((int)(System.Convert.ChangeType(getClientInvoicesDataGridView.Rows[e.RowIndex].Cells[0].Value, typeof(int))))));
            }
        }

        private void ClientDetailScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.clientDetailScreen = null;
        }
    }
}
