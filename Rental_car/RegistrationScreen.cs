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
        public RegistrationScreen()
        {
            InitializeComponent();
            regexEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        }

        private void RegistrationScreen_Load(object sender, EventArgs e)
        {

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

        private void btnRegistration_Click(object sender, EventArgs e)
        {
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

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RegistrationScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainScreen.Show();
        }
    }
}
