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
    public partial class DocumentScreen : Form
    {
        List<String> categoryList = new List<string> { "M1", "M2", "M3", "N1", "N2", "N3" };
        List<String> statusList = new List<string> { "Пригодно", "Требует ремонта", "Требует капитального ремонта", "Ремонту не подлежит", "Ремонтируется", "В прокате" };
        List<String> gearboxList = new List<string> { "Автомат", "Ручная" };
        List<String> genderList = new List<string> { "М", "Ж" };

        int priceAtDayRental;

        public DocumentScreen()
        {
            InitializeComponent();
        }



        private void DocumentScreen_Load(object sender, EventArgs e)
        {
            DisplayDocumentInformation();
        }

        public void DisplayDocumentInformation()
        {
            try
            {
               

                txtName.Text                    = Program.documentCard.clientCard.Name;
                txtFathername.Text              = Program.documentCard.clientCard.Fathername;
                txtSurname.Text                 = Program.documentCard.clientCard.Surname;
                txtEmail.Text                   = Program.documentCard.clientCard.Email;
                txtTelephone.Text               = Program.documentCard.clientCard.Contact_telephone;
                txtPassportSeries.Text          = Program.documentCard.clientCard.Passport_series;
                txtPassportNumber.Text          = Program.documentCard.clientCard.Passport_number;
                txtDriveCode.Text               = Program.documentCard.clientCard.Driver_certificate_code;
                txtAddress.Text                 = Program.documentCard.clientCard.Address;
                dtimeBirthday.Value             = DateTime.Parse(Program.documentCard.clientCard.Birthday.ToString());
                dtimePassportDate.Value         = DateTime.Parse(Program.documentCard.clientCard.Passport_date.ToString());
                cbGender.SelectedIndex          = genderList.IndexOf(Program.documentCard.clientCard.Gender);


                textBoxVIN.Text                 = Program.documentCard.carCard.VIN;
                textBoxRegNum.Text              = Program.documentCard.carCard.Registration_number;
                textBoxBrand.Text               = Program.documentCard.carCard.Brand;
                textBoxModel.Text               = Program.documentCard.carCard.Model;
                textBoxEngineNum.Text           = Program.documentCard.carCard.Engine_number;
                textBoxEnginePower.Text         = Program.documentCard.carCard.Engine_power;
                textBoxEngineVolume.Text        = Program.documentCard.carCard.Engine_volume;
                textBoxColor.Text               = Program.documentCard.carCard.Color;
                textBoxBody.Text                = Program.documentCard.carCard.Body_type;
                textBoxRegCertificateNum.Text   = Program.documentCard.carCard.Registration_certificate;
                textBoxPassportSeries.Text      = Program.documentCard.carCard.Passport_series;
                textBoxPassportNumber.Text      = Program.documentCard.carCard.Passport_number;
                textBoxOwner.Text               = Program.documentCard.carCard.Owner;
                textBoxYear.Text                = Program.documentCard.carCard.Year;
                textBoxPrice.Text               = Program.documentCard.applicationCard.ToString();
                comboBoxCategory.SelectedIndex  = categoryList.IndexOf(Program.documentCard.carCard.Category);
                comboBoxGearbox.SelectedIndex   = gearboxList.IndexOf(Program.documentCard.carCard.Gearbox);
                comboBoxStatus.SelectedIndex    = statusList.IndexOf(Program.documentCard.carCard.Status);

                
                labelDateStartRental.Text       = Program.documentCard.applicationCard.DateTimeStartRental.ToString("dd.MM.yyyy");
                labelDateEndRental.Text         = Program.documentCard.applicationCard.DateTimeStartRental.ToString("dd.MM.yyyy");
                labelRentalPrice.Text           = Program.documentCard.applicationCard.Price.ToString();
                labelCountDays.Text             = Program.documentCard.applicationCard.Days.ToString();

                SetEnableForComponents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SetEnableForComponents()
        {
          /*textBoxDamageDescriptionBeforeRental.Enabled            = Program.documentCard.documentExsiting;
            textBoxDamageDescriptionAfterRental.Enabled             = Program.documentCard.documentExsiting;
            dateTimePickerDamageDescriptionBeforeRental.Enabled     = Program.documentCard.documentExsiting;
            dateTimePickerDamageDescriptionAfterRental.Enabled      = Program.documentCard.documentExsiting;
            buttonUpdateDamageStatus.Enabled                        = Program.documentCard.documentExsiting;*/

            groupBoxDamageDescriptionPanel.Enabled                  = Program.documentCard.documentExsiting;
            buttonConfirmRentalCarReturn.Enabled                    = Program.documentCard.documentExsiting;
            buttonInvoice.Enabled                                   = Program.documentCard.documentExsiting;
            buttonExportDocument.Enabled                            = Program.documentCard.documentExsiting;
            buttonCreateDocument.Enabled                            = !Program.documentCard.documentExsiting;
        }

        private void DocumentScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.documentScreen = null;
        }

        private void buttonCreateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.RunQuery($@"INSERT INTO document VALUES(
                                                                NULL,
                                                                {Program.documentCard.applicationCard.Application_code},
                                                                DEFAULT,
                                                                {Program.agentCard.Agent_number},
                                                                NULL,
                                                                NULL,
                                                                NULL,
                                                                NULL,
                                                                NULL);");

                DBConnection.RunQuery($@"UPDATE car SET Status = 'В прокате' WHERE VIN = '{Program.documentCard.carCard.VIN}';");

                Program.documentCard.documentExsiting = true;
                SetEnableForComponents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
