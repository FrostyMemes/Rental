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
    public partial class CarCardScreen : Form
    {

        List<String> categoryList   = new List<string> { "M1", "M2", "M3", "N1", "N2", "N3" };
        List<String> statusList     = new List<string> { "Пригодно", "Требует ремонта", "Требует капитального ремонта", "Ремонту не подлежит", "Ремонтируется", "В прокате" };
        List<String> gearboxList    = new List<string> { "Автомат", "Ручная" };
        string oldVIN;

        public CarCardScreen()
        {
            InitializeComponent();
        }

        private void CarCardScreen_Load(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedIndex = 0;
            comboBoxGearbox.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
            buttonAddOrUpdate.Text = "Добавить";
            if (Program.carCardMode == 1)
            {
                buttonAddOrUpdate.Text = "Изменить";
                oldVIN                          = Program.carCard.VIN;
                textBoxVIN.Text                 = Program.carCard.VIN;
                textBoxRegNum.Text              = Program.carCard.Registration_number;
                textBoxBrand.Text               = Program.carCard.Brand;
                textBoxModel.Text               = Program.carCard.Model;
                textBoxEngineNum.Text           = Program.carCard.Engine_number;
                textBoxEnginePower.Text         = Program.carCard.Engine_power;
                textBoxEngineVolume.Text        = Program.carCard.Engine_volume;
                textBoxColor.Text               = Program.carCard.Color;
                textBoxBody.Text                = Program.carCard.Body_type;
                textBoxRegCertificateNum.Text   = Program.carCard.Registration_certificate;
                textBoxPassportSeries.Text      = Program.carCard.Passport_series;
                textBoxPassportNumber.Text      = Program.carCard.Passport_number;
                textBoxOwner.Text               = Program.carCard.Owner;
                textBoxYear.Text                = Program.carCard.Year;
                textBoxPrice.Text               = Program.carCard.Price;
                comboBoxCategory.SelectedIndex  = categoryList.IndexOf(Program.carCard.Category);
                comboBoxGearbox.SelectedIndex   = gearboxList.IndexOf(Program.carCard.Gearbox);
                comboBoxStatus.SelectedIndex    = statusList.IndexOf(Program.carCard.Status);
            }
        }

        private void buttonAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.carCardMode == 1)
                {
                    DBConnection.RunQuery($@"UPDATE car SET 
                                                    VIN = '{textBoxVIN.Text}', 
                                                    Registration_number = '{textBoxRegNum.Text}', 
                                                    Brand = '{textBoxBrand.Text}', 
                                                    Model = '{textBoxModel.Text}', 
                                                    Engine_number = '{textBoxEngineNum.Text}', 
                                                    Engine_volume = '{textBoxEngineVolume.Text}', 
                                                    Engine_power = '{textBoxEnginePower.Text}', 
                                                    Body_type = '{textBoxBody.Text}', 
                                                    Color = '{textBoxColor.Text}', 
                                                    Category = '{comboBoxCategory.Text}',                                                 
                                                    Registration_certificate = '{textBoxRegCertificateNum.Text}',
                                                    Passport_series = '{textBoxPassportSeries.Text}',
                                                    Passport_number = '{textBoxPassportNumber.Text}', 
                                                    Owner = '{textBoxOwner.Text}', 
                                                    Year = '{textBoxYear.Text}', 
                                                    Gearbox = '{comboBoxGearbox.Text}',
                                                    Price = '{textBoxPrice.Text}',
                                                    Status = '{comboBoxStatus.Text}'
                                                    WHERE VIN = '{oldVIN}';");
                    oldVIN = textBoxVIN.Text;
                    MessageBox.Show("Изменено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DBConnection.RunQuery($@"INSERT INTO car SET 
                                                    VIN = '{textBoxVIN.Text}', 
                                                    Registration_number = '{textBoxRegNum.Text}', 
                                                    Brand = '{textBoxBrand.Text}', 
                                                    Model = '{textBoxModel.Text}', 
                                                    Engine_number = '{textBoxEngineNum.Text}', 
                                                    Engine_volume = '{textBoxEngineVolume.Text}', 
                                                    Engine_power = '{textBoxEnginePower.Text}', 
                                                    Body_type = '{textBoxBody.Text}', 
                                                    Color = '{textBoxColor.Text}', 
                                                    Category = '{comboBoxCategory.Text}',                                                 
                                                    Registration_certificate = '{textBoxRegCertificateNum.Text}',
                                                    Passport_series = '{textBoxPassportSeries.Text}',
                                                    Passport_number = '{textBoxPassportNumber.Text}', 
                                                    Owner = '{textBoxOwner.Text}', 
                                                    Year = '{textBoxYear.Text}', 
                                                    Gearbox = '{comboBoxGearbox.Text}',
                                                    Price = '{textBoxPrice.Text}',
                                                    Status = '{comboBoxStatus.Text}';");
                    MessageBox.Show("Добавлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
