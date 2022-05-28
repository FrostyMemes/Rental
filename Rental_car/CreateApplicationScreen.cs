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
    public partial class CreateApplicationScreen : Form
    {
        int rentalPrice = 0;
        int rentalDays = 0;
        public CreateApplicationScreen()
        {
            InitializeComponent();
        }

        private void CreateApplicationForm_Load(object sender, EventArgs e)
        {
            comboBoxChildeSeat.SelectedIndex = 0;
        }



        private void comboBoxChildeSeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTimePickerStartRental_ValueChanged(object sender, EventArgs e)
        {
            RecalculateRentalData();
        }

        private void dateTimePickerEndRental_ValueChanged(object sender, EventArgs e)
        {
            RecalculateRentalData();
        }


        private void btnCreateApplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerEndRental.Value<dateTimePickerStartRental.Value || dateTimePickerStartRental.Value < DateTime.Now || dateTimePickerEndRental.Value < DateTime.Now)
                {
                    MessageBox.Show("Неверный формат даты", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CheckAvailability())
                {
                        DBConnection.RunQuery($@"INSERT INTO application VALUES(NULL, 
                                                         DEFAULT, 
                                                        '{Program.clientCard.Client_number}', 
                                                        '{Program.applicationCard.VIN}', 
                                                        '{comboBoxChildeSeat.Text}', 
                                                        '{dateTimePickerStartRental.Value.ToString("yyyy-MM-dd")}', 
                                                        '{dateTimePickerEndRental.Value.ToString("yyyy-MM-dd")}',  
                                                         {rentalDays}, 
                                                         {rentalPrice}, 
                                                         DEFAULT, 
                                                         NULL,
                                                         NULL)");

                        MessageBox.Show("Заявка на прокат была добавлена в обработку!\nОжидайте ответа представителя", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                 else
                 {
                    MessageBox.Show("Автомобиль занят на это время.\nВыберите другой период проката", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 this.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            if (CheckAvailability())
                MessageBox.Show("Автомобиль доступен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Автомобиль занят на это время.\nВыберите другой период проката", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RecalculateRentalData()
        {
            rentalDays = Math.Abs((dateTimePickerEndRental.Value - dateTimePickerStartRental.Value).Days + 1);
            rentalPrice = rentalDays * Program.applicationCard.Price;
            labelRentalDays.Text = $"Дней проката: {rentalDays}";
            labelPrice.Text = $"Итоговая сумма: {rentalPrice}";
        }

        private bool CheckAvailability()
        {
            try
            {
                return (DBConnection.GetResultQueryString($"SELECT car_rental.CheckAvaibleCarAtPreiod('{dateTimePickerStartRental.Value.ToString("yyyy-MM-dd")}', '{Program.applicationCard.VIN}');") == "0");
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

    }
}
