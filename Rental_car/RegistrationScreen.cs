using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Rental_car
{
   
    
    public partial class RegistrationScreen : Form
    {
        Regex regexEmail;
        bool emailCorrection = false;
        bool passwordCorrection = false;
        bool surnameCoorection = false;
        bool nameCorrection = false;
        bool passportSeriesCorrection = false;
        bool passportNumberCorrcetion = false;
        bool driverCodeCorrection = false;
        bool telephoneCorrection = false;
        bool addressCorrection = false;
        public RegistrationScreen()
        {
            InitializeComponent();
            
        }
        private void RegistrationScreen_Load(object sender, EventArgs e)
        {
            regexEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            cbGender.SelectedIndex = 0;
        }

        private void RegistrationScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainScreen.Show();
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8);
        }

        private void txtFathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8);
        }

        private void txtPassportSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8);
        }

        private void txtPassportNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8);
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) || (txtTelephone.Text.Length == 2 && e.KeyChar == 8);
        }

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            emailCorrection = (regexEmail.IsMatch(txtEmail.Text) && txtEmail.Text.Length > 0);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {          
            passwordCorrection = (txtPassword.Text.Length >= 8);
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            surnameCoorection = (txtSurname.Text.Length > 0);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            nameCorrection = (txtName.Text.Length > 0);
        }

        private void txtPassportSeries_Leave(object sender, EventArgs e)
        {
            passportSeriesCorrection = (txtPassportSeries.Text.Length == 4);
        }

        private void txtPassportNumber_Leave(object sender, EventArgs e)
        {
            passportNumberCorrcetion = (txtPassportNumber.Text.Length == 6);
        }

        private void txtDriveCode_Leave(object sender, EventArgs e)
        {
            driverCodeCorrection = (txtDriveCode.Text.Length == 10);
        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            telephoneCorrection = (txtTelephone.Text.Length == 12);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            addressCorrection = (txtAddress.Text.Length > 0);
        }

        private bool CheckAge()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = DateTime.Now - dtimeBirthday.Value;

            int years = (zeroTime + span).Year - 1;

            return (years>=18) ? true : false;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (!emailCorrection)
            {
                MessageBox.Show("Проверьте правильность вашего Email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!passwordCorrection)
            {
                MessageBox.Show("Пароль не соответствует необходимому формату", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!surnameCoorection)
            {
                MessageBox.Show("Проверьте правильность вашей фамилии", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!nameCorrection)
            {
                MessageBox.Show("Проверьте правильность вашего имени", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!passportSeriesCorrection)
            {
                MessageBox.Show("Проверьте правильность вашей серии паспорта", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!passportNumberCorrcetion)
            {
                MessageBox.Show("Проверьте правильность вашего номера паспорта", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!driverCodeCorrection)
            {
                MessageBox.Show("Проверьте правильность вашего кода водительского удостоверения", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!telephoneCorrection)
            {
                MessageBox.Show("Проверьте правильность вашего номера телефона", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!addressCorrection)
            {
                MessageBox.Show("Проверьте правильность вашего адреса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtimePassportDate.Value >= DateTime.Now || dtimeBirthday.Value >= DateTime.Now || dtimeBirthday.Value >= dtimePassportDate.Value)
            {
                MessageBox.Show("Проверьте правильность введенных вами дат", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckAge())
            {
                MessageBox.Show("Вам должно быть больше 18 лет!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnection.RunQuery($@"INSERT INTO client VALUES(NULL, 
                                                    '{txtEmail.Text}', 
                                                    '{txtPassword.Text}', 
                                                    '{txtSurname.Text}', 
                                                    '{txtName.Text}', 
                                                    '{txtFathername.Text}', 
                                                    '{txtPassportSeries.Text}', 
                                                    '{txtPassportNumber.Text}', 
                                                    '{dtimePassportDate.Value.ToString("yyyy-MM-dd")}', 
                                                    '{txtDriveCode.Text}', 
                                                    '{dtimeBirthday.Value.ToString("yyyy-MM-dd")}',                                                 
                                                    '{cbGender.Text}',
                                                    '{txtTelephone.Text}',
                                                    '{txtAddress.Text}', DEFAULT)");

                MessageBox.Show("Ваш аккаунт успешно зарегистрирован, добро пожаловать!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
