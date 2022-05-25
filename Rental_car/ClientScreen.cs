using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Rental_car
{
    public partial class ClientScreen : Form
    {
        int selectedApplicationRow;

        public ClientScreen()
        {
            InitializeComponent();
        }

        private void ClientScreen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.client_catalogue". При необходимости она может быть перемещена или удалена.
            
            try
            {
                this.getClientInvoicesTableAdapter.Fill(this.dBDataSet.GetClientInvoices, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.clientCard.Client_number, typeof(int))))));
                this.getClientApplicationTableAdapter.Fill(this.dBDataSet.GetClientApplication, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.clientCard.Client_number, typeof(int))))));
                this.client_catalogueTableAdapter.Fill(this.dBDataSet.client_catalogue);

                txtEmail.Text       = Program.clientCard.Email;
                txtPassword.Text    = Program.clientCard.Password;
                txtSurname.Text     = Program.clientCard.Surname;
                txtName.Text        = Program.clientCard.Name;
                txtFathername.Text  = Program.clientCard.Fathername;
                txtTelephone.Text   = Program.clientCard.Contact_telephone;
                txtAddress.Text     = Program.clientCard.Address;
                dtimeBirthday.Value = DateTime.Parse(Program.clientCard.Birthday.ToString());

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchCarTableAdapter.Fill(this.dBDataSet.SearchCar, brand_carToolStripTextBox.Text, model_carToolStripTextBox.Text);
                dataGridViewClientCatalogue.DataSource = searchCarBindingSource;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.client_catalogueTableAdapter.Fill(this.dBDataSet.client_catalogue);
            dataGridViewClientCatalogue.DataSource = clientcatalogueBindingSource;
        }



        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void getClientInvoicesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex != -1)
              this.getInvoiceContentTableAdapter.Fill(this.dBDataSet.GetInvoiceContent, new System.Nullable<int>(((int)(System.Convert.ChangeType(getClientInvoicesDataGridView.Rows[e.RowIndex].Cells[0].Value, typeof(int))))));

        }

        private void btnChangeUserInforamtion_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.RunQuery($@"UPDATE client SET 
                                                    Email = '{txtEmail.Text}', 
                                                    Password = '{txtPassword.Text}', 
                                                    Surname = '{txtSurname.Text}', 
                                                    Name = '{txtName.Text}', 
                                                    Fathername = '{txtFathername.Text}',                                                  
                                                    Birthday = '{dtimeBirthday.Value.ToString("yyyy-MM-dd")}',                                                 
                                                    Gender = '{cbGender.Text}',
                                                    Contact_telephone = '{txtTelephone.Text}',
                                                    Address = '{txtAddress.Text}'
                                                    WHERE Client_number = {Program.clientCard.Client_number};");

                MessageBox.Show("Ваш аккаунт успешно изменен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Program.clientCard.Email                = txtEmail.Text;
                Program.clientCard.Password             = txtPassword.Text;
                Program.clientCard.Surname              = txtSurname.Text;
                Program.clientCard.Name                 = txtName.Text;
                Program.clientCard.Fathername           = txtFathername.Text;
                Program.clientCard.Contact_telephone    = txtTelephone.Text;
                Program.clientCard.Address              = txtAddress.Text;
                Program.clientCard.Address              = dtimeBirthday.Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка!\nПовторите попытку позднее или обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainScreen.Show();
        }

        private void кToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string status = getClientApplicationDataGridView.Rows[selectedApplicationRow].Cells[12].Value.ToString();
                string idApplication = getClientApplicationDataGridView.Rows[selectedApplicationRow].Cells[13].Value.ToString();

                if (MessageBox.Show("Вы уверены, что хотите отменить заявку?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (status == "Подтверждено" && (MessageBox.Show("Данная заявка была подтверждена вы уверены, что хотите отменить её?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (DBConnection.GetResultQueryString($"SELECT car_rental.CheckDocumentExsisting({idApplication});") == "1")
                        {
                            MessageBox.Show("Данная заявка не может быть удалена, так как по ней был оформлен договор", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }                       
                    }
                    DBConnection.RunQuery($"DELETE FROM application WHERE Application_code = {idApplication}");
                    getClientApplicationDataGridView.Rows.RemoveAt(selectedApplicationRow);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshApplicationTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.getClientApplicationTableAdapter.Fill(this.dBDataSet.GetClientApplication, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.clientCard.Client_number, typeof(int))))));
        }

        private void getClientApplicationDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getClientApplicationDataGridView.ClearSelection();
                selectedApplicationRow = e.RowIndex;
                getClientApplicationDataGridView.Rows[e.RowIndex].Selected = true;
            }
        }


        private void dataGridViewClientCatalogue_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string vin = dataGridViewClientCatalogue.Rows[e.RowIndex].Cells[9].Value.ToString();
                int price = int.Parse(dataGridViewClientCatalogue.Rows[e.RowIndex].Cells[8].Value.ToString());
                Program.applicationData = new ApplicationData(vin, price);

                var createApplicationForm = new CreateApplicationScreen();
                createApplicationForm.Show();
            }
        }

        
    }
}
