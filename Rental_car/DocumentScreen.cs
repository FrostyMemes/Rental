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
        List<String> statusList = new List<string> { "Пригодно", "Требует ремонта", "Требует капитального ремонта", "Ремонту не подлежит", "Ремонтируется", "В прокате", "Идет осмотр" };
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
                dtimeBirthday.Value             = DateTime.Parse(Program.documentCard.clientCard.Birthday);
                dtimePassportDate.Value         = DateTime.Parse(Program.documentCard.clientCard.Passport_date);
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
                textBoxPrice.Text               = Program.documentCard.applicationCard.PriceAtDay.ToString();
                comboBoxCategory.SelectedIndex  = categoryList.IndexOf(Program.documentCard.carCard.Category);
                comboBoxGearbox.SelectedIndex   = gearboxList.IndexOf(Program.documentCard.carCard.Gearbox);
                comboBoxStatus.SelectedIndex    = statusList.IndexOf(Program.documentCard.carCard.Status);

                
                labelDateStartRental.Text                                           = Program.documentCard.applicationCard.DateTimeStartRental.ToString("dd.MM.yyyy");
                labelDateEndRental.Text                                             = Program.documentCard.applicationCard.DateTimeEndRental.ToString("dd.MM.yyyy");
                labelRentalPrice.Text                                               = Program.documentCard.applicationCard.Price.ToString();
                labelCountDays.Text                                                 = Program.documentCard.applicationCard.Days.ToString();
                labelFactRentalEnd.Text                                             = Program.documentCard.FacticalRentalEnd;
                labelTaxForLate.Text                                                = Program.documentCard.Tax.ToString();
                labelLateRentalDays.Text                                            = Program.documentCard.DaysLate.ToString();
                textBoxDamageDescriptionBeforeRental.Text                           = Program.documentCard.Description_damage_before;
                textBoxDamageDescriptionAfterRental.Text                            = Program.documentCard.Description_damage_after;

                if (!String.IsNullOrEmpty(Program.documentCard.Date_inspection_before))              
                dateTimePickerDamageDescriptionBeforeRental.Value  = DateTime.Parse(Program.documentCard.Date_inspection_before);

                if (!String.IsNullOrEmpty(Program.documentCard.Date_inspection_after))
                    dateTimePickerDamageDescriptionAfterRental.Value = DateTime.Parse(Program.documentCard.Date_inspection_after);

                SetEnableForComponents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SetEnableForComponents()
        {
          

            groupBoxDamageDescriptionPanel.Enabled                  = Program.documentCard.documentExsiting;
            buttonConfirmRentalCarReturn.Enabled                    = Program.documentCard.documentExsiting;
            buttonInvoice.Enabled                                   = Program.documentCard.documentExsiting;
            buttonExportDocument.Enabled                            = Program.documentCard.documentExsiting;
            buttonCreateDocument.Enabled                            = !Program.documentCard.documentExsiting;


            buttonConfirmRentalCarReturn.Enabled            = String.IsNullOrEmpty(Program.documentCard.FacticalRentalEnd);
            groupBoxDamageDescriptionBeforeRental.Enabled   = String.IsNullOrEmpty(Program.documentCard.Description_damage_before);
            groupBoxDamageDescriptionAfterRental.Enabled    = String.IsNullOrEmpty(Program.documentCard.Description_damage_after);

        }


        private void DocumentScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.documentScreen = null;

            if (Program.invoiceCreatingScreen != null)
            {
                Program.invoiceCreatingScreen.Close();
                Program.invoiceCreatingScreen = null;
            }

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

                Program.documentCard.GetDocumentInformation();
                SetEnableForComponents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonConfirmRentalCarReturn_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.RunQuery($@"UPDATE car SET Status = 'Идет осмотр' WHERE VIN = '{Program.documentCard.carCard.VIN}';");
                DBConnection.RunQuery($@"UPDATE document SET Fact_receiving_date = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE Document_number = {Program.documentCard.idDocument};");

                Program.documentCard.GetDocumentInformation();

                labelFactRentalEnd.Text     = Program.documentCard.FacticalRentalEnd;
                labelTaxForLate.Text        = Program.documentCard.Tax.ToString();
                labelLateRentalDays.Text    = Program.documentCard.DaysLate.ToString();
                buttonConfirmRentalCarReturn.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdateDamageStatus_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(Program.documentCard.Date_inspection_before))
            {
                DBConnection.RunQuery($@"UPDATE document SET 
                    Date_inspection_before = '{dateTimePickerDamageDescriptionBeforeRental.Value.ToString("yyyy-MM-dd HH:mm:ss")}',
                    Description_damage_before = '{textBoxDamageDescriptionBeforeRental.Text}'
                    WHERE Document_number = {Program.documentCard.idDocument};");

                Program.documentCard.Description_damage_before  = textBoxDamageDescriptionBeforeRental.Text;
                Program.documentCard.Date_inspection_before     = dateTimePickerDamageDescriptionBeforeRental.Value.ToString();
               // groupBoxDamageDescriptionBeforeRental.Enabled   = false;
            }

            if (!String.IsNullOrEmpty(textBoxDamageDescriptionAfterRental.Text) && String.IsNullOrEmpty(labelFactRentalEnd.Text))
            {
                MessageBox.Show("Автомобиль еще находится в прокате", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!String.IsNullOrEmpty(Program.documentCard.Date_inspection_after))
            {
                DBConnection.RunQuery($@"UPDATE document SET 
                    Date_inspection_after = '{dateTimePickerDamageDescriptionAfterRental.Value.ToString("yyyy-MM-dd HH:mm:ss")}',
                    Description_damage_after = '{textBoxDamageDescriptionAfterRental.Text}'
                    WHERE Document_number = {Program.documentCard.idDocument};");

                Program.documentCard.Description_damage_after   = textBoxDamageDescriptionAfterRental.Text;
                Program.documentCard.Date_inspection_after      = dateTimePickerDamageDescriptionAfterRental.Value.ToString();
                groupBoxDamageDescriptionAfterRental.Enabled    = false;
                return;
            }

        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            if (Program.invoiceCreatingScreen != null)
            {
                Program.invoiceCreatingScreen.Activate();
            }
            else
            {
                Program.invoiceCreatingScreen = new InvoiceCreatingScreen();
                Program.invoiceCreatingScreen.Show();
            }
        }
    }
}
