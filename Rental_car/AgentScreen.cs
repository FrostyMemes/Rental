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
    public partial class AgentScreen : Form
    {
        
        int selectedWaitingApplicationRow;
        int selectedConfirmedApplicationsRow;
        int selectedCarInformationRow;

        bool emailCorrection = true;
        bool passwordCorrection = true;
        bool surnameCoorection = true;
        bool nameCorrection = true;
        bool telephoneCorrection = true;
        bool addressCorrection = true;

        Regex regexEmail;

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

            regexEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");


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
                this.searchCarWithParametrsTableAdapter.Fill(this.dBDataSet.SearchCarWithParametrs, "", "", "", "");
                this.getClientStatisticTableAdapter.Fill(this.dBDataSet.GetClientStatistic, new System.Nullable<int>(((int)(System.Convert.ChangeType(DateTime.Now.Year, typeof(int))))));
                this.rental_cars_nowTableAdapter.Fill(this.dBDataSet.rental_cars_now);
                this.not_paid_invoicesTableAdapter.Fill(this.dBDataSet.not_paid_invoices);

                if (not_paid_invoicesDataGridView.Rows.Count != 0)
                {

                    this.getInvoiceContentTableAdapter.Fill(this.dBDataSet.GetInvoiceContent, new System.Nullable<int>(((int)(System.Convert.ChangeType(not_paid_invoicesDataGridView.Rows[0].Cells[0].Value, typeof(int))))));
                }

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
                if (waitingApplicationsDataGridView.Rows.Count == 0)
                    return;

                var selectedRow = waitingApplicationsDataGridView.SelectedRows[0];

                DBConnection.RunQuery($@"UPDATE application SET 
                                       Status = 'Подтверждено',
                                       Confirmed_date = DEFAULT,
                                       Agent_number = {Program.agentCard.Agent_number}
                                       WHERE Application_code = {selectedRow.Cells[16].Value}");
                waitingApplicationsDataGridView.Rows.RemoveAt(selectedRow.Index);
                
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
                if (waitingApplicationsDataGridView.Rows.Count == 0)
                    return;

                var selectedRow = waitingApplicationsDataGridView.SelectedRows[0];

                DBConnection.RunQuery($@"UPDATE application SET 
                                       Status = 'Отклонено',
                                       Confirmed_date = DEFAULT,
                                       Agent_number = {Program.agentCard.Agent_number}
                                       WHERE Application_code = {selectedRow.Cells[16].Value}");
                waitingApplicationsDataGridView.Rows.RemoveAt(selectedRow.Index);

                MessageBox.Show("Заявка отклонена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void detailClientWaitingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (waitingApplicationsDataGridView.Rows.Count == 0)
                return;

            var selectedRow = waitingApplicationsDataGridView.SelectedRows[0];

            OpenClientDetail(selectedRow.Cells[4].Value.ToString());

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
                if (waitingApplicationsDataGridView.Rows.Count == 0)
                    return;

                var selectedRow = waitingApplicationsDataGridView.SelectedRows[0];

                OpenClientDetail(selectedRow.Cells[4].Value.ToString());
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
            if (searchCarWithParametrsDataGridView.Rows.Count == 0)
                return;

            var selectedRow = searchCarWithParametrsDataGridView.SelectedRows[0];

            var carData = DBConnection.GetResultQueryDataTable($@"Select * from car where VIN = '{selectedRow.Cells[0].Value.ToString()}';");
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
                if (getConfirmApplicationsDataGridView.Rows.Count == 0)
                    return;

                var selectedRow = getConfirmApplicationsDataGridView.SelectedRows[0];
                string email = selectedRow.Cells[4].Value.ToString();
                string regNum = selectedRow.Cells[9].Value.ToString();
                string idApplication = selectedRow.Cells[19].Value.ToString();
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
                if (getConfirmApplicationsDataGridView.Rows.Count == 0)
                    return;

                var selectedRow = getConfirmApplicationsDataGridView.SelectedRows[0];

                if (CheckDocumentExsiting(selectedRow.Cells[19].Value.ToString()))
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
                                       WHERE Application_code = {selectedRow.Cells[19].Value}");
                    getConfirmApplicationsDataGridView.Rows.RemoveAt(selectedRow.Index);

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
            if (getConfirmApplicationsDataGridView.Rows.Count == 0)
                return;

            var selectedRow = getConfirmApplicationsDataGridView.SelectedRows[0];
            OpenClientDetail(selectedRow.Cells[4].Value.ToString());
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
            if (searchCarWithParametrsDataGridView.Rows.Count == 0)
                return;

            var selectedRow = searchCarWithParametrsDataGridView.SelectedRows[0];

            var carData = DBConnection.GetResultQueryDataTable($@"Select * from car where VIN = '{selectedRow.Cells[0].Value.ToString()}';"); 
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
                if (dtimeBirthday.Value >= DateTime.Now)
                {
                    MessageBox.Show("Проверьте правильность введенных вами дат", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

        private void refreshWaitingApplicationTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.waiting_applicationsTableAdapter.Fill(this.dBDataSet.waiting_applications);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelAllUnderDateWaitingApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                DBConnection.RunQuery($@"UPDATE application SET Status='Отклонено' WHERE Status = 'Ожидается' AND Receiving_date <= NOW();");
                this.waiting_applicationsTableAdapter.Fill(this.dBDataSet.waiting_applications);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItemDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchCarWithParametrsDataGridView.SelectedRows.Count == 0)
                    return;

                DataGridViewRow selectedRow = searchCarWithParametrsDataGridView.SelectedRows[0];



                if (MessageBox.Show("Вы уверены, что хотите удалить автомобиль???", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $@"DELETE FROM car WHERE VIN = '{selectedRow.Cells[0].Value.ToString()}';";
                    DBConnection.RunQuery(query);
                    searchCarWithParametrsDataGridView.Rows.RemoveAt(selectedRow.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteAllUnderDateConfirmedApplications_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.RunQuery($@"UPDATE application SET application.Status = 'Отклонено'
                                        WHERE application.Status = 'Подтверждено' AND 
                                        application.Receiving_date <= NOW() AND
                                        application.Application_code NOT IN 
                                        (SELECT Application_code FROM 
                                        (SELECT document.Application_code FROM application, document WHERE application.Application_code = document.Application_code AND document.Document_number) as something);");
                this.getConfirmApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmApplications);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshCarCatalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchCarWithParametrsTableAdapter.Fill(this.dBDataSet.SearchCarWithParametrs, "", "", "", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.rental_cars_nowTableAdapter.Fill(this.dBDataSet.rental_cars_now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshTabletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.not_paid_invoicesTableAdapter.Fill(this.dBDataSet.not_paid_invoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) || (txtTelephone.Text.Length == 2 && e.KeyChar == 8);

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

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            telephoneCorrection = (txtTelephone.Text.Length == 12);
            if (txtTelephone.Text.Length < 2)
                txtTelephone.Text = "+7";
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            addressCorrection = (txtAddress.Text.Length > 0);

        }
    }
}
