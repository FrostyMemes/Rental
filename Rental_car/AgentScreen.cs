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
    public partial class AgentScreen : Form
    {
        
        int selectedWaitingApplicationRow;
        int selectedConfirmedApplicationsRow;
        int selectedCarInformationRow;
        int selectedClientStatisticRow;

        public AgentScreen()
        {
            InitializeComponent();
        }

        private bool CheckDocumentExsiting(string idApplication)
        {
            return DBConnection.GetResultQueryString($"SELECT car_rental.CheckDocumentExsisting({idApplication});") == "1";
        }

        private void DrawLateRentalCars()
        {
            foreach(DataGridViewRow dgvRow in rental_cars_nowDataGridView.Rows)
            {
                if (int.Parse(dgvRow.Cells[9].Value.ToString()) > 0)
                    dgvRow.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void OpenClientDetail(string clientEmail)
        {
            try
            {
                var personData = DBConnection.GetResultQueryDataTable($@"Select * from client where Email = '{clientEmail}';");
                Program.clientCard = new ClientCard(personData);
                if (Program.clientDetailScreen == null)
                {
                    Program.clientDetailScreen = new ClientDetailScreen();
                    Program.clientDetailScreen.Show();
                }
                else
                {
                    Program.clientDetailScreen.DisplayClientInformation();
                    Program.clientDetailScreen.Activate();
                }
                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateDocument()
        {

        }

        private void AgentScreen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.GetConfirmApplications". При необходимости она может быть перемещена или удалена.
            


            try
            {
                txtEmail.Text           = Program.agentCard.Email;
                txtPassword.Text        = Program.agentCard.Password;
                txtSurname.Text         = Program.agentCard.Surname;
                txtName.Text            = Program.agentCard.Name;
                txtFathername.Text      = Program.agentCard.Fathername;
                txtTelephone.Text       = Program.agentCard.Contact_telephone;
                txtAddress.Text         = Program.agentCard.Address;
                dtimeBirthday.Value     = DateTime.Parse(Program.agentCard.Birthday.ToString());

                this.waiting_applicationsTableAdapter.Fill(this.dBDataSet.waiting_applications);
                this.getConfirmApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmApplications);
                this.getConfirmApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmApplications);
                this.searchCarWithParametrsTableAdapter.Fill(this.dBDataSet.SearchCarWithParametrs, "", "", "", "");
                this.getClientStatisticTableAdapter.Fill(this.dBDataSet.GetClientStatistic, new System.Nullable<int>(((int)(System.Convert.ChangeType(DateTime.Now.Year, typeof(int))))));
                this.rental_cars_nowTableAdapter.Fill(this.dBDataSet.rental_cars_now);
                this.not_paid_invoicesTableAdapter.Fill(this.dBDataSet.not_paid_invoices);


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void AgentScreen_Shown(object sender, EventArgs e)
        {
            DrawLateRentalCars();
        }

        private void AgentScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainScreen.Show();
            if (Program.clientDetailScreen != null)
            {
                Program.clientDetailScreen.Close();
                Program.clientDetailScreen = null;
            }
            if (Program.documentScreen != null)
            {
                Program.documentScreen.Close();
                Program.documentScreen = null;
            }

        }

        private void acceptWaitingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.RunQuery($@"UPDATE application SET 
                                       Status = 'Подтверждено',
                                       Confirmed_date = DEFAULT,
                                       Agent_number = {Program.agentCard.Agent_number}
                                       WHERE Application_code = {waitingApplicationsDataGridView.Rows[selectedWaitingApplicationRow].Cells[16].Value}");
                waitingApplicationsDataGridView.Rows.RemoveAt(selectedWaitingApplicationRow);
                
                MessageBox.Show("Заявка подтверждена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void denyWaitingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.RunQuery($@"UPDATE application SET 
                                       Status = 'Отклонено',
                                       Confirmed_date = DEFAULT,
                                       Agent_number = {Program.agentCard.Agent_number}
                                       WHERE Application_code = {waitingApplicationsDataGridView.Rows[selectedWaitingApplicationRow].Cells[16].Value}");
                waitingApplicationsDataGridView.Rows.RemoveAt(selectedWaitingApplicationRow);
                
                MessageBox.Show("Заявка отклонена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void detailClientWaitingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            
             OpenClientDetail(waitingApplicationsDataGridView.Rows[selectedWaitingApplicationRow].Cells[4].Value.ToString());

        }

        private void waitingApplicationsDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                waitingApplicationsDataGridView.ClearSelection();
                selectedWaitingApplicationRow = e.RowIndex;
                waitingApplicationsDataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void waitingApplicationsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                OpenClientDetail(waitingApplicationsDataGridView.Rows[selectedWaitingApplicationRow].Cells[4].Value.ToString());
            }
        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchCarWithParametrsTableAdapter.Fill(this.dBDataSet.SearchCarWithParametrs, car_VINToolStripTextBox.Text, car_RegNumberToolStripTextBox.Text, car_BrandToolStripTextBox.Text, car_ModelToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchCarWithParametrsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var carData = DBConnection.GetResultQueryDataTable($@"Select * from car where VIN = '{searchCarWithParametrsDataGridView.Rows[selectedCarInformationRow].Cells[0].Value.ToString()}';");
            if (carData.Rows.Count != 0)
            {
                Program.carCardMode = 1;
                Program.carCard = new CarCard(carData);
                CarCardScreen carCardScreen = new CarCardScreen();
                carCardScreen.Show();
            }
            else
            {
                MessageBox.Show("Такого автомобиля не существует в системе", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchCarWithParametrsDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                searchCarWithParametrsDataGridView.ClearSelection();
                selectedCarInformationRow = e.RowIndex;
                searchCarWithParametrsDataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void RefreshCatalogueToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchCarWithParametrsTableAdapter.Fill(this.dBDataSet.SearchCarWithParametrs, "", "", "", "");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void not_paid_invoicesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    this.getInvoiceContentTableAdapter.Fill(this.dBDataSet.GetInvoiceContent, new System.Nullable<int>(((int)(System.Convert.ChangeType(not_paid_invoicesDataGridView.Rows[e.RowIndex].Cells[0].Value, typeof(int))))));
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.getClientStatisticTableAdapter.Fill(this.dBDataSet.GetClientStatistic, new System.Nullable<int>(((int)(System.Convert.ChangeType(client_yearToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CreateDocumentScreen()
        {
            try
            {
                string email = getConfirmApplicationsDataGridView.Rows[selectedConfirmedApplicationsRow].Cells[4].Value.ToString();
                string regNum = getConfirmApplicationsDataGridView.Rows[selectedConfirmedApplicationsRow].Cells[9].Value.ToString();
                string idApplication = getConfirmApplicationsDataGridView.Rows[selectedConfirmedApplicationsRow].Cells[19].Value.ToString();
                Program.documentCard = new DocumentCard(idApplication, email, regNum);

                if (Program.documentScreen == null)
                {
                    Program.documentScreen = new DocumentScreen();
                    Program.documentScreen.Show();
                }
                else
                {
                    Program.documentScreen.DisplayDocumentInformation();
                    Program.documentScreen.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDocumentScreen();
        }

        private void canceltConfirmedApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDocumentExsiting(getConfirmApplicationsDataGridView.Rows[selectedConfirmedApplicationsRow].Cells[19].Value.ToString()))
                {
                    MessageBox.Show("На данную заявку уже были оформлены документы", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Вы уверены, что хотите отменить подтвержденную завявку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DBConnection.RunQuery($@"UPDATE application SET 
                                       Status = 'Отклонено',
                                       Confirmed_date = DEFAULT,
                                       Agent_number = {Program.agentCard.Agent_number}
                                       WHERE Application_code = {getConfirmApplicationsDataGridView.Rows[selectedConfirmedApplicationsRow].Cells[19].Value}");
                    getConfirmApplicationsDataGridView.Rows.RemoveAt(selectedConfirmedApplicationsRow);

                    MessageBox.Show("Заявка отклонена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientDetailConfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenClientDetail(getConfirmApplicationsDataGridView.Rows[selectedConfirmedApplicationsRow].Cells[4].Value.ToString());
        }

        private void getConfirmApplicationsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CreateDocumentScreen();
        }

        private void toolStripMenuItemAddCar_Click(object sender, EventArgs e)
        {
            Program.carCardMode = 0;
            CarCardScreen carCardScreen = new CarCardScreen();
            carCardScreen.Show();
        }

        private void toolStripMenuItemUpdateCar_Click(object sender, EventArgs e)
        {
            var carData = DBConnection.GetResultQueryDataTable($@"Select * from car where VIN = '{searchCarWithParametrsDataGridView.Rows[selectedCarInformationRow].Cells[0].Value.ToString()}';");
            if (carData.Rows.Count != 0)
            {
                Program.carCardMode = 1;
                Program.carCard = new CarCard(carData);
                CarCardScreen carCardScreen = new CarCardScreen();
                carCardScreen.Show();
            }
            else
            {
                MessageBox.Show("Такого автомобиля не существует в системе", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

 
      private void findConfirmedApplicationMonthYearfillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getConfirmedMonthYearApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmedMonthYearApplications, new System.Nullable<int>(((int)(System.Convert.ChangeType(app_monthToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(app_yearToolStripTextBox.Text, typeof(int))))));
                getConfirmApplicationsDataGridView.DataSource = getConfirmedMonthYearApplicationsBindingSource;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void refreshConfirmedApplicationstoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getConfirmApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmApplications);
                getConfirmApplicationsDataGridView.DataSource = getConfirmApplicationsBindingSource;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void findConfirmedApplicationClientfillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getConfirmedClientApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmedClientApplications, client_surnameToolStripTextBox.Text, client_telephoneToolStripTextBox.Text);
                getConfirmApplicationsDataGridView.DataSource = getConfirmedClientApplicationsBindingSource;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void getConfirmApplicationsDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getConfirmApplicationsDataGridView.ClearSelection();
                selectedConfirmedApplicationsRow = e.RowIndex;
                getConfirmApplicationsDataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnUpdateAgentData_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.RunQuery($@"UPDATE agent SET 
                                                    Email = '{txtEmail.Text}', 
                                                    Password = '{txtPassword.Text}', 
                                                    Surname = '{txtSurname.Text}', 
                                                    Name = '{txtName.Text}', 
                                                    Fathername = '{txtFathername.Text}',                                                  
                                                    Birthday = '{dtimeBirthday.Value.ToString("yyyy-MM-dd")}',                                                             
                                                    Contact_telephone = '{txtTelephone.Text}',
                                                    Address = '{txtAddress.Text}'
                                                    WHERE Agent_number = {Program.agentCard.Agent_number};");

                MessageBox.Show("Ваш аккаунт успешно изменен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.agentCard.Email = txtEmail.Text;
                Program.agentCard.Password = txtPassword.Text;
                Program.agentCard.Surname = txtSurname.Text;
                Program.agentCard.Name = txtName.Text;
                Program.agentCard.Fathername = txtFathername.Text;
                Program.agentCard.Contact_telephone = txtTelephone.Text;
                Program.agentCard.Address = txtAddress.Text;
                Program.agentCard.Address = dtimeBirthday.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
