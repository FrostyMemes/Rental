using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


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
                    dateTimePickerDamageDescriptionBeforeRental.Value = DateTime.Parse(Program.documentCard.Date_inspection_before);

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


            groupBoxDamageDescriptionBeforeRental.Enabled = !String.IsNullOrEmpty(Program.documentCard.Description_damage_before) || Program.documentCard.documentExsiting;
            groupBoxDamageDescriptionAfterRental.Enabled = !String.IsNullOrEmpty(Program.documentCard.Description_damage_after) || Program.documentCard.documentExsiting;

            buttonConfirmRentalCarReturn.Enabled                    = Program.documentCard.documentExsiting && (String.IsNullOrEmpty(Program.documentCard.FacticalRentalEnd));
            buttonInvoice.Enabled                                   = Program.documentCard.documentExsiting;
            buttonExportDocument.Enabled                            = Program.documentCard.documentExsiting;
            buttonCreateDocument.Enabled                            = !Program.documentCard.documentExsiting;
            buttonUpdateDamageStatus.Enabled = groupBoxDamageDescriptionBeforeRental.Enabled || groupBoxDamageDescriptionAfterRental.Enabled;

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
            

            if (String.IsNullOrEmpty(Program.documentCard.Description_damage_before))
            {
                DBConnection.RunQuery($@"UPDATE document SET 
                    Date_inspection_before = '{dateTimePickerDamageDescriptionBeforeRental.Value.ToString("yyyy-MM-dd HH:mm:ss")}',
                    Description_damage_before = '{textBoxDamageDescriptionBeforeRental.Text}'
                    WHERE Document_number = {Program.documentCard.idDocument};");

                Program.documentCard.Description_damage_before  = textBoxDamageDescriptionBeforeRental.Text;
                Program.documentCard.Date_inspection_before     = dateTimePickerDamageDescriptionBeforeRental.Value.ToString();
                groupBoxDamageDescriptionBeforeRental.Enabled   = false;
               
            }

            if (!String.IsNullOrEmpty(textBoxDamageDescriptionAfterRental.Text) && String.IsNullOrEmpty(labelFactRentalEnd.Text))
            {
                MessageBox.Show("Автомобиль еще находится в прокате. Дабавит данных о тех. осмотре автомобиля после проката можно только по его завершению", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!String.IsNullOrEmpty(Program.documentCard.Description_damage_after))
            {
                string descrAfterRental = !String.IsNullOrEmpty(textBoxDamageDescriptionAfterRental.Text) ? $@"'{textBoxDamageDescriptionAfterRental.Text}'" : "NULL";
                DBConnection.RunQuery($@"UPDATE document SET 
                    Date_inspection_after = '{dateTimePickerDamageDescriptionAfterRental.Value.ToString("yyyy-MM-dd HH:mm:ss")}',
                    Description_damage_after = {descrAfterRental}
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

        private void buttonExportDocument_Click(object sender, EventArgs e)
        {
            try
            {

                string documentNum = new string('0', 10 - Program.documentCard.idDocument.Length) + $@"{Program.documentCard.idDocument} от {Program.documentCard.Document_date}";
                string applicationNum = new string('0', 10 - Program.documentCard.idApplication.Length) + $@"{Program.documentCard.idApplication} от {Program.documentCard.applicationCard.Applicatio_date.ToString("dd MMMM yyyy")}";


                Excel.Application excelApplication = new Excel.Application();

                excelApplication.Visible = true;
                excelApplication.SheetsInNewWorkbook = 2;

                var workBook = excelApplication.Workbooks.Add(Type.Missing);
                excelApplication.DisplayAlerts = false;

                Excel.Worksheet sheet = (Excel.Worksheet)excelApplication.Worksheets.get_Item(1);
                Excel.Range range;

                sheet.Name = "Договор";

                sheet.Cells[2, 2] =$@"Договор о прокате № {documentNum}";
                range = (Excel.Range)sheet.get_Range("A2", "J2").Cells;
                range.HorizontalAlignment = Excel.Constants.xlCenter;
                range.Font.Size = 11;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                sheet.Cells[3, 1] = $@"Заявка № {applicationNum}";
                range = (Excel.Range)sheet.get_Range("A3", "D3").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Font.Size = 11;
                range.Merge(Type.Missing);

                sheet.Cells[5, 1] = $@"Арендатор:";
                range = (Excel.Range)sheet.get_Range("A5", "B5").Cells;
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Size = 14;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                for (int i = 6; i != 15; i++)
                {
                    range = (Excel.Range)sheet.Range[sheet.Cells[i, 1], sheet.Cells[i, 2]];
                    range.HorizontalAlignment = Excel.Constants.xlRight;
                    range.Font.Bold = true;
                    range.Merge(Type.Missing);

                    range = (Excel.Range)sheet.Range[sheet.Cells[i, 3], sheet.Cells[i, 6]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                    range.Merge(Type.Missing);
                }

                range = (Excel.Range)sheet.Range[sheet.Cells[15, 1], sheet.Cells[15, 2]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[15, 3], sheet.Cells[15, 9]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Merge(Type.Missing);

                sheet.Cells[6, 1] = $@"ФИО:";
                sheet.Cells[7, 1] = $@"Серия паспорта:";
                sheet.Cells[8, 1] = $@"Номер паспорта:";
                sheet.Cells[9, 1] = $@"Выдан:";
                sheet.Cells[10, 1] = $@"Код вод. удост:";
                sheet.Cells[11, 1] = $@"Дата рождения:";
                sheet.Cells[12, 1] = $@"Пол:";
                sheet.Cells[13, 1] = $@"Телефон:";
                sheet.Cells[14, 1] = $@"Email:";
                sheet.Cells[15, 1] = $@"Адрес:";

                sheet.Cells[6, 3] = $@"{Program.documentCard.clientCard.Surname} {Program.documentCard.clientCard.Name} {Program.documentCard.clientCard.Fathername}";
                sheet.Cells[7, 3] = Program.documentCard.clientCard.Passport_series;
                sheet.Cells[8, 3] = Program.documentCard.clientCard.Passport_number;
                sheet.Cells[9, 3] = Program.documentCard.clientCard.Passport_date;
                sheet.Cells[10, 3] = Program.documentCard.clientCard.Driver_certificate_code;
                sheet.Cells[11, 3] = Program.documentCard.clientCard.Birthday;
                sheet.Cells[12, 3] = Program.documentCard.clientCard.Gender;
                sheet.Cells[13, 3] = Program.documentCard.clientCard.Contact_telephone;
                sheet.Cells[14, 3] = Program.documentCard.clientCard.Email;
                sheet.Cells[15, 3] = Program.documentCard.clientCard.Address;

                sheet.Cells[17, 1] = $@"Арендодатель в лице:";
                range = (Excel.Range)sheet.get_Range("A17", "C17").Cells;
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Size = 14;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[18, 1], sheet.Cells[18, 2]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);
                range = (Excel.Range)sheet.Range[sheet.Cells[19, 1], sheet.Cells[19, 2]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);
                range = (Excel.Range)sheet.Range[sheet.Cells[20, 1], sheet.Cells[20, 2]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);
                range = (Excel.Range)sheet.Range[sheet.Cells[21, 1], sheet.Cells[21, 2]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[18, 3], sheet.Cells[18, 6]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Merge(Type.Missing);
                range = (Excel.Range)sheet.Range[sheet.Cells[19, 3], sheet.Cells[19, 6]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Merge(Type.Missing);               
                range = (Excel.Range)sheet.Range[sheet.Cells[20, 3], sheet.Cells[20, 6]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Merge(Type.Missing);
                range = (Excel.Range)sheet.Range[sheet.Cells[21, 3], sheet.Cells[21, 6]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Merge(Type.Missing);

                sheet.Cells[18, 1] = $@"ФИО:";
                sheet.Cells[19, 1] = $@"Серия паспорта:";
                sheet.Cells[20, 1] = $@"Номер паспорта:";
                sheet.Cells[21, 1] = $@"Телефон:";

                sheet.Cells[18, 3] = $@"{Program.agentCard.Surname} {Program.agentCard.Name} {Program.agentCard.Fathername}";
                sheet.Cells[19, 3] = Program.agentCard.Passport_series;
                sheet.Cells[20, 3] = Program.agentCard.Passport_number;
                sheet.Cells[21, 3] = Program.agentCard.Contact_telephone;


                for (int i = 23; i<30; i++)
                {
                    range = (Excel.Range)sheet.Range[sheet.Cells[i, 1], sheet.Cells[i, 2]];
                    range.HorizontalAlignment = Excel.Constants.xlCenter;
                    range.Font.Bold = true;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    range.Merge(Type.Missing);

                    range = (Excel.Range)sheet.Range[sheet.Cells[i, 3], sheet.Cells[i, 4]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.Font.Size = 10;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    range.Merge(Type.Missing);

                    range = (Excel.Range)sheet.Range[sheet.Cells[i, 5], sheet.Cells[i, 6]];
                    range.HorizontalAlignment = Excel.Constants.xlCenter;
                    range.Font.Bold = true;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    range.Merge(Type.Missing);

                    range = (Excel.Range)sheet.Range[sheet.Cells[i, 7], sheet.Cells[i, 8]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.Font.Size = 10;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    range.Merge(Type.Missing);
                }
                
                sheet.Cells[23, 1] = $@"Автомобиль";
                sheet.Cells[24, 1] = $@"VIN";
                sheet.Cells[25, 1] = $@"Рег. номер";
                sheet.Cells[26, 1] = $@"Номер двигателя";
                sheet.Cells[27, 1] = $@"Тип кузова";
                sheet.Cells[28, 1] = $@"Цвет";
                sheet.Cells[29, 1] = $@"Категория";

                sheet.Cells[23, 5] = $@"Номер рег. серт.";
                sheet.Cells[24, 5] = $@"Серия паспорта";
                sheet.Cells[25, 5] = $@"Номер паспорта";
                sheet.Cells[26, 5] = $@"Владелец";
                sheet.Cells[27, 5] = $@"Год";
                sheet.Cells[28, 5] = $@"КПП";
                sheet.Cells[29, 5] = $@"Объем двигателя";

                sheet.Cells[23, 3] = $@"{Program.documentCard.carCard.Brand} {Program.documentCard.carCard.Model}";
                sheet.Cells[24, 3] = $@"{Program.documentCard.carCard.VIN}";
                sheet.Cells[25, 3] = $@"{Program.documentCard.carCard.Registration_number}";
                sheet.Cells[26, 3] = $@"{Program.documentCard.carCard.Engine_number}";
                sheet.Cells[27, 3] = $@"{Program.documentCard.carCard.Body_type}";
                sheet.Cells[28, 3] = $@"{Program.documentCard.carCard.Color}";
                sheet.Cells[29, 3] = $@"{Program.documentCard.carCard.Category}";

                sheet.Cells[23, 7] = $@"{Program.documentCard.carCard.Registration_certificate}";
                sheet.Cells[24, 7] = $@"{Program.documentCard.carCard.Passport_series}";
                sheet.Cells[25, 7] = $@"{Program.documentCard.carCard.Passport_number}";
                sheet.Cells[26, 7] = $@"{Program.documentCard.carCard.Owner}";
                sheet.Cells[27, 7] = $@"{Program.documentCard.carCard.Year}";
                sheet.Cells[28, 7] = $@"{Program.documentCard.carCard.Gearbox}";
                sheet.Cells[29, 7] = $@"{Program.documentCard.carCard.Engine_volume}";


                sheet.Cells[32, 1] = "Заверил:";
                sheet.Cells[32, 1].Font.Size = 8;

                range = (Excel.Range)sheet.Range[sheet.Cells[32, 2], sheet.Cells[32, 3]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Font.Bold = true;
                range.Merge(Type.Missing);


                sheet.Cells[32, 4] = $@"{Program.agentCard.Surname} {Program.agentCard.Name[0]}.{Program.agentCard.Fathername[0]}.";
                range = (Excel.Range)sheet.Range[sheet.Cells[32, 4], sheet.Cells[32, 5]];
                range.Merge(Type.Missing);


                sheet.Cells[35, 1] = "Плательщик:";
                sheet.Cells[35, 1].Font.Size = 8;

                range = (Excel.Range)sheet.Range[sheet.Cells[35, 2], sheet.Cells[35, 3]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                sheet.Cells[35, 4] = $@"{Program.documentCard.clientCard.Surname} {Program.documentCard.clientCard.Name[0]}.{Program.documentCard.clientCard.Fathername[0]}.";
                range = (Excel.Range)sheet.Range[sheet.Cells[35, 4], sheet.Cells[35, 5]];
                range.Merge(Type.Missing);

                sheet.Cells[37, 1] = "Дата распечатки:";
                range = (Excel.Range)sheet.Range[sheet.Cells[37, 1], sheet.Cells[37, 2]];              
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[37, 3], sheet.Cells[37, 4]];
                range.Merge(Type.Missing);
                sheet.Cells[37, 3] = DateTime.Now.ToString("dd.MM.yyyy HH.mm");


                sheet = (Excel.Worksheet)excelApplication.Worksheets.get_Item(2);
                sheet.Name = "Акт";
                // workBook.SaveAs(documentNum+applicationNum);

               

                sheet.Cells[1, 1] = $"Акт приема-передачи автомобиля \n от договора № {documentNum}";
                range = (Excel.Range)sheet.get_Range("A1", "J2").Cells;
                range.HorizontalAlignment = Excel.Constants.xlCenter;
                range.Font.Size = 11;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                sheet.Cells[4, 1] = "Дата оформления договора:";
                range = (Excel.Range)sheet.Range[sheet.Cells[4, 1], sheet.Cells[4, 3]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);
                
                sheet.Cells[4, 4] = Program.documentCard.Document_date;
               
                range = (Excel.Range)sheet.Range[sheet.Cells[4, 4], sheet.Cells[4, 5]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Merge(Type.Missing);

                sheet.Cells[6, 1] = "Гос. номер автомобиля:";
                range = (Excel.Range)sheet.Range[sheet.Cells[6, 1], sheet.Cells[6, 3]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                sheet.Cells[6, 4] = Program.documentCard.carCard.Registration_number;
                range = (Excel.Range)sheet.Range[sheet.Cells[6, 4], sheet.Cells[6, 5]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.HorizontalAlignment = Excel.Constants.xlLeft;

                range.Merge(Type.Missing);

                sheet.Cells[8, 1] = "Код пред. фирмы.:";
                range = (Excel.Range)sheet.Range[sheet.Cells[8, 1], sheet.Cells[8, 3]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                string numAgent = '.'+new string('0', 5 - Program.agentCard.Agent_number.Length) + Program.agentCard.Agent_number.Length;
                sheet.Cells[8, 4] = numAgent; 
                range = (Excel.Range)sheet.Range[sheet.Cells[8, 4], sheet.Cells[8, 5]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Merge(Type.Missing);

                sheet.Cells[10, 1] = "ФИО пред. фирмы:";
                range = (Excel.Range)sheet.Range[sheet.Cells[10, 1], sheet.Cells[10, 3]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                sheet.Cells[10, 4] = $@"{Program.agentCard.Surname} {Program.agentCard.Name[0]}.{Program.agentCard.Fathername[0]}.";
                range = (Excel.Range)sheet.Range[sheet.Cells[10, 4], sheet.Cells[10, 5]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.HorizontalAlignment = Excel.Constants.xlLeft;

                sheet.Cells[12, 1] = "Детское кресло:";
                range = (Excel.Range)sheet.Range[sheet.Cells[12, 1], sheet.Cells[12, 3]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                sheet.Cells[12, 4] = $@"{Program.documentCard.applicationCard.Child_seat}";
                range = (Excel.Range)sheet.Range[sheet.Cells[12, 4], sheet.Cells[12, 5]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Merge(Type.Missing);




                sheet.Cells[14, 2] = "Дата тех. осмотра до проката:";
                range = (Excel.Range)sheet.Range[sheet.Cells[14, 2], sheet.Cells[14, 5]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[14, 6], sheet.Cells[14, 7]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Merge(Type.Missing);

                sheet.Cells[16, 2] = "Описание тех. осмотра до проката:";
                range = (Excel.Range)sheet.Range[sheet.Cells[16, 2], sheet.Cells[16, 5]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[17, 2], sheet.Cells[26, 8]];
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);

                sheet.Cells[28, 2] = "Дата тех. осмотра после проката:";
                range = (Excel.Range)sheet.Range[sheet.Cells[28, 2], sheet.Cells[28, 5]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[28, 6], sheet.Cells[28, 7]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Merge(Type.Missing);

                sheet.Cells[30, 2] = "Описание тех. осмотра после проката:";
                range = (Excel.Range)sheet.Range[sheet.Cells[30, 2], sheet.Cells[30, 5]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[31, 2], sheet.Cells[40, 8]];
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);

                sheet.Cells[43, 1] = "Заверил:";
                sheet.Cells[43, 1].Font.Size = 8;

                range = (Excel.Range)sheet.Range[sheet.Cells[43, 2], sheet.Cells[43, 3]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Font.Bold = true;
                range.Merge(Type.Missing);


                sheet.Cells[43, 4] = $@"{Program.agentCard.Surname} {Program.agentCard.Name[0]}.{Program.agentCard.Fathername[0]}.";
                range = (Excel.Range)sheet.Range[sheet.Cells[43, 4], sheet.Cells[43, 5]];
                range.Merge(Type.Missing);

                sheet.Cells[45, 1] = "Ответственный за тех. осмотр:";
                sheet.Cells[45, 1].Font.Size = 9;
                range = (Excel.Range)sheet.Range[sheet.Cells[45, 1], sheet.Cells[45, 3]];
                range.Merge(Type.Missing);

                range = (Excel.Range)sheet.Range[sheet.Cells[45, 4], sheet.Cells[45, 6]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

            }






            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
