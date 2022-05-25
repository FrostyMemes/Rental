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

        public AgentScreen()
        {
            InitializeComponent();
        }

        public bool CheckDocumentExsiting(string idApplication)
        {
            return DBConnection.GetResultQueryString($"SELECT car_rental.CheckDocumentExsisting({idApplication});") == "1";
        }

        private void AgentScreen_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.waiting_applicationsTableAdapter.Fill(this.dBDataSet.waiting_applications);
                this.getConfirmedApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmedApplications, new System.Nullable<int>(((int)(System.Convert.ChangeType(DateTime.Now.Month, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(DateTime.Now.Year, typeof(int))))));
                this.searchCarWithParametrsTableAdapter.Fill(this.dBDataSet.SearchCarWithParametrs, car_VINToolStripTextBox.Text, car_RegNumberToolStripTextBox.Text, car_BrandToolStripTextBox.Text, car_ModelToolStripTextBox.Text);
                this.getClientStatisticTableAdapter.Fill(this.dBDataSet.GetClientStatistic, new System.Nullable<int>(((int)(System.Convert.ChangeType(DateTime.Now.Year, typeof(int))))));
                this.rental_cars_nowTableAdapter.Fill(this.dBDataSet.rental_cars_now);
                this.not_paid_invoicesTableAdapter.Fill(this.dBDataSet.not_paid_invoices);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        private void acceptWaitingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.RunQuery($@"UPDATE application SET 
                                       Status = 'Подтверждено'
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
                                       Status = 'Отклонено'
                                       WHERE Application_code = {waitingApplicationsDataGridView.Rows[selectedWaitingApplicationRow].Cells[16].Value}");
                waitingApplicationsDataGridView.Rows.RemoveAt(selectedWaitingApplicationRow);
                
                MessageBox.Show("Заявка отклонена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgentScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainScreen.Show();
        }

        private void detailClientWaitingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {         
                try
                {
                    var personData = DBConnection.GetResultQueryDataTable($@"Select * from client where Email = '{waitingApplicationsDataGridView.Rows[selectedWaitingApplicationRow].Cells[3].Value}';");
                    Program.clientCard = new ClientCard(personData);
                    Program.ClientDetailScreen = new ClientDetailScreen();
                    Program.ClientDetailScreen.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getConfirmedApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmedApplications, new System.Nullable<int>(((int)(System.Convert.ChangeType(app_monthToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(app_yearToolStripTextBox.Text, typeof(int))))));
                getConfirmedApplicationsDataGridView.DataSource = getConfirmedApplicationsBindingSource;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.getConfirmedApplicationsTableAdapter.Fill(this.dBDataSet.GetConfirmedApplications, new System.Nullable<int>(((int)(System.Convert.ChangeType(DateTime.Now.Month, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(DateTime.Now.Year, typeof(int))))));
            getConfirmedApplicationsDataGridView.DataSource = getConfirmedApplicationsBindingSource;
        }

        private void fillToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.getClientConfirmedApplicationsTableAdapter.Fill(this.dBDataSet.GetClientConfirmedApplications, client_surnameToolStripTextBox.Text, client_telephoneToolStripTextBox.Text);
                getConfirmedApplicationsDataGridView.DataSource = getClientConfirmedApplicationsBindingSource;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void getConfirmedApplicationsDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getConfirmedApplicationsDataGridView.ClearSelection();
                selectedConfirmedApplicationsRow = e.RowIndex;
                getConfirmedApplicationsDataGridView.Rows[e.RowIndex].Selected = true;
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
            if (e.RowIndex != -1)
            {
                var carData = DBConnection.GetResultQueryDataTable($@"Select * from car where VIN = '{searchCarWithParametrsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()}';");
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
        }

        private void RefreshCatalogueToolStripButton_Click(object sender, EventArgs e)
        {
            this.searchCarWithParametrsTableAdapter.Fill(this.dBDataSet.SearchCarWithParametrs, "", "", "", "");
        }

        private void fillToolStripButton3_Click(object sender, EventArgs e)
        {
            

        }

        private void not_paid_invoicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void openDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckDocumentExsiting(getConfirmedApplicationsDataGridView.Rows[selectedConfirmedApplicationsRow].Cells[16].Value.ToString()))
                MessageBox.Show("Документы есть");
            else
                MessageBox.Show("Документов на данную заявку оформлено не было", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckDocumentExsiting(getConfirmedApplicationsDataGridView.Rows[selectedConfirmedApplicationsRow].Cells[16].Value.ToString()))
                MessageBox.Show("На данную заявку уже были оформлены документы", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Документов на данную заявку оформлено не было", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
