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

        bool checkVIN;
        bool checkRegNum;
        bool checkBrand;
        bool checkModel;
        bool checkEngineNumber;
        bool checkEnginePower;
        bool checkEngineVolume;
        bool checkBody;
        bool checkColor;
        bool checkCertificareRegNum;
        bool checkPassportSeries;
        bool checkPassportNumber;
        bool checkOwner;
        bool checkYear;
        bool checkPrice;
        
        List<String> categoryList   = new List<string> { "M1", "M2", "M3", "N1", "N2", "N3" };
        List<String> statusList     = new List<string> { "Пригодно", "Требует ремонта", "Требует капитального ремонта", "Ремонту не подлежит", "Ремонтируется", "В прокате", "Идет осмотр" };
        List<String> gearboxList    = new List<string> { "Автомат", "Ручная" };
        string oldVIN;

        public CarCardScreen()
        {
            InitializeComponent();
        }

        public void SetValidationFlag(bool flag)
        {
             checkVIN = flag;
             checkRegNum = flag;
             checkBrand = flag;
             checkModel = flag;
             checkEngineNumber = flag;
             checkEnginePower = flag;
             checkEngineVolume = flag;
             checkColor = flag;
             checkCertificareRegNum = flag;
             checkPassportSeries = flag;
             checkPassportNumber = flag;
             checkOwner = flag;
             checkYear = flag;
             checkPrice = flag;
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
            else
            {
                SetValidationFlag(false);
            }
        }

        private void buttonAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValidation())
                    return;

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

        private void comboBoxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxGearbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8);
        }

        private void textBoxEnginePower_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8);
        }

        private void textBoxPassportNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8);
        }

        private void textBoxEngineVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !(e.KeyChar=='.') && !(e.KeyChar == 8);
        }

        private void textBoxRegCertificateNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !(textBoxRegCertificateNum.Text.Length < 4) && !(e.KeyChar == 8);
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8);
        }

        private void textBoxColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8);
        }

        /// <summary>
        /// //////////////
        /// </summary>

        private void textBoxVIN_TextChanged(object sender, EventArgs e)
        {
            checkVIN = textBoxVIN.Text.Length == 17;
        }

        private void textBoxRegNum_TextChanged(object sender, EventArgs e)
        {
            checkRegNum = (textBoxRegNum.Text.Length <= 10 && textBoxRegNum.Text.Length >= 8);
        }

        private void textBoxBrand_TextChanged(object sender, EventArgs e)
        {
            checkBrand = !String.IsNullOrEmpty(textBoxBrand.Text);
        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {
            checkModel = !String.IsNullOrEmpty(textBoxModel.Text);
        }

        private void textBoxEnginePower_TextChanged(object sender, EventArgs e)
        {
            checkEnginePower = !String.IsNullOrEmpty(textBoxEnginePower.Text);
        }

        private void textBoxEngineNum_TextChanged(object sender, EventArgs e)
        {
            checkEngineNumber = textBoxEngineNum.Text.Length <= 12 && textBoxEngineNum.Text.Length >= 10; 
        }

        private void textBoxEngineVolume_TextChanged(object sender, EventArgs e)
        {
            checkEngineVolume = !String.IsNullOrEmpty(textBoxEngineVolume.Text);
        }

        private void textBoxBody_TextChanged(object sender, EventArgs e)
        {
            checkBody = !String.IsNullOrEmpty(textBoxBody.Text);
        }

       
        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            checkColor = !String.IsNullOrEmpty(textBoxColor.Text);
        }

        private void textBoxRegCertificateNum_TextChanged(object sender, EventArgs e)
        {
            checkCertificareRegNum = textBoxRegCertificateNum.Text.Length == 10;
        }

        private void textBoxPassportSeries_TextChanged(object sender, EventArgs e)
        {
            checkPassportSeries = textBoxPassportSeries.Text.Length == 4;
        }

        private void textBoxPassportNumber_TextChanged(object sender, EventArgs e)
        {
            checkPassportNumber = textBoxPassportNumber.Text.Length == 6;
        }

        private void textBoxOwner_TextChanged(object sender, EventArgs e)
        {
            checkOwner = !String.IsNullOrEmpty(textBoxOwner.Text);
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            checkYear = !String.IsNullOrEmpty(textBoxYear.Text);
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            checkPrice = !String.IsNullOrEmpty(textBoxPrice.Text);
        }

        private bool CheckValidation()
        {
          
            
            if (!checkVIN)
            {
                MessageBox.Show("Проверьте VIN-номер", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!checkRegNum)
            {
                MessageBox.Show("Проверьте регистрационный номер", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!checkEngineNumber)
            {
                MessageBox.Show("Проверьте номер двигателя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!checkCertificareRegNum)
            {
                MessageBox.Show("Проверьте номер сертификата о регистрации автомобиля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!checkPassportSeries)
            {
                MessageBox.Show("Проверьте серию паспорта автомобиля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!checkPassportNumber)
            {
                MessageBox.Show("Проверьте номер паспорта автомобиля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }           

            if (!checkBrand || !checkModel || !checkEnginePower || !checkEngineVolume || !checkBody || !checkColor || !checkOwner || !checkYear || !checkPrice)
            {
                MessageBox.Show("Заполните поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
             
            return true;
        }

       
    }
}
