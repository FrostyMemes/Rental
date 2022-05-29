using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace Rental_car
{
    public partial class InvoiceCreatingScreen : Form
    {

        public InvoiceCreatingScreen()
        {
            InitializeComponent();
        }

        private void InvoiceCreatingScreen_Load(object sender, EventArgs e)
        {
            try
            {
                this.getDocumentInvoicesTableAdapter.Fill(this.dBDataSet.GetDocumentInvoices, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.documentCard.idDocument, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

   

        private void buttonAddNewInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxVAT.Text))
                    textBoxVAT.Text = "0";

                string query = $@"INSERT INTO invoice VALUES(
                                                    NULL,
                                                    {Program.documentCard.idDocument},
                                                    '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',
                                                    'Проспект кольский',
                                                    '504967286023',
                                                    '154785693', 
                                                    '145762314', 
                                                    '{textBoxVAT.Text}', 
                                                    {Program.agentCard.Agent_number},
                                                    'Ожидается', 
                                                    0);";
                DBConnection.RunQuery(query);
                this.getDocumentInvoicesTableAdapter.Fill(this.dBDataSet.GetDocumentInvoices, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.documentCard.idDocument, typeof(int))))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (getDocumentInvoicesDataGridView.SelectedRows.Count == 0)
                    return;

                DataGridViewRow selectedRow = getDocumentInvoicesDataGridView.SelectedRows[0];



                if (MessageBox.Show("Вы уверены, что хотите удалить счет?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $@"DELETE FROM invoice WHERE Invoice_number = {selectedRow.Cells[0].Value.ToString()};";
                    DBConnection.RunQuery(query);
                    getDocumentInvoicesDataGridView.Rows.RemoveAt(selectedRow.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.getDocumentInvoicesTableAdapter.Fill(this.dBDataSet.GetDocumentInvoices, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.documentCard.idDocument, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void getDocumentInvoicesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow= getDocumentInvoicesDataGridView.SelectedRows[0];
                this.getInvoiceContentForAgentTableAdapter.Fill(this.dBDataSet.GetInvoiceContentForAgent, new System.Nullable<int>(((int)(System.Convert.ChangeType(selectedRow.Cells[0].Value.ToString(), typeof(int))))));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddInvoiceContent_Click(object sender, EventArgs e)
        {
            try
            {
                if (getDocumentInvoicesDataGridView.SelectedRows.Count == 0)
                    return;

                DataGridViewRow selectedRow = getDocumentInvoicesDataGridView.SelectedRows[0];

               
                string query = $@"INSERT INTO invoice_content VALUES(
                                                    NULL,
                                                    {selectedRow.Cells[0].Value.ToString()},
                                                    '{textBoxService.Text}',
                                                    '{textBoxServiceUnit.Text}',
                                                     {textBoxCount.Text},
                                                     {textBoxPrice.Text});";
                DBConnection.RunQuery(query);
                this.getInvoiceContentForAgentTableAdapter.Fill(this.dBDataSet.GetInvoiceContentForAgent, new System.Nullable<int>(((int)(System.Convert.ChangeType(selectedRow.Cells[0].Value.ToString(), typeof(int))))));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void getInvoiceContentForAgentDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow selectedRow = getInvoiceContentForAgentDataGridView.SelectedRows[0];
                    string query = $@"DELETE FROM invoice_content WHERE Record_code = {selectedRow.Cells[0].Value.ToString()};";
                    DBConnection.RunQuery(query);
                    getInvoiceContentForAgentDataGridView.Rows.RemoveAt(selectedRow.Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buttonPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {

                if (getDocumentInvoicesDataGridView.SelectedRows.Count == 0)
                    return;

                DataGridViewRow selectedRow = getDocumentInvoicesDataGridView.SelectedRows[0];
                string invoiceNum = selectedRow.Cells[0].Value.ToString();
                string documentNum = selectedRow.Cells[1].Value.ToString();
                DateTime dateInvoice = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                string address = selectedRow.Cells[3].Value.ToString();
                string TIN = selectedRow.Cells[4].Value.ToString();
                string RVC = selectedRow.Cells[5].Value.ToString();
                string BIC = selectedRow.Cells[6].Value.ToString();
                string VAT = selectedRow.Cells[7].Value.ToString();

                documentNum = new string('0', 10 - documentNum.Length) + documentNum;
                invoiceNum = new string('0', 7 - invoiceNum.Length) + invoiceNum;

                string fileName = $@"Счет {invoiceNum}.{documentNum}.{dateInvoice.ToString("dd.MM.yyyy")}";

                Excel.Application excelApplication = new Excel.Application();

                excelApplication.Visible = true;
                excelApplication.SheetsInNewWorkbook = 1;

                var workBook = excelApplication.Workbooks.Add(Type.Missing);
                excelApplication.DisplayAlerts = false;

                Excel.Worksheet sheet = (Excel.Worksheet)excelApplication.Worksheets.get_Item(1);
                Excel.Range range;


                sheet.Name = "Счет";

                sheet.Cells[1, 1] = "БИК:";
                sheet.Cells[2, 1] = "ИНН:";
                sheet.Cells[3, 1] = "КПП:";

                range = (Excel.Range)sheet.get_Range("B1", "D1").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);
                
                range = (Excel.Range)sheet.get_Range("B2", "D2").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);
                
                range = (Excel.Range)sheet.get_Range("B3", "D3").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);

                sheet.Cells[1, 2] = BIC;
                sheet.Cells[2, 2] = TIN;
                sheet.Cells[3, 2] = RVC;

                sheet.get_Range("A1", "A3").Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;           
                sheet.get_Range("A1", "A3").Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.get_Range("A1", "A3").Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.get_Range("A1", "A1").Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.get_Range("A1", "A2").Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.get_Range("A1", "A3").Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;


                // workBook.SaveAs(fileName);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void InvoiceCreatingScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.invoiceCreatingScreen = null;
        }

        private void InvoiceCreatingScreen_Shown(object sender, EventArgs e)
        {
            if (getDocumentInvoicesDataGridView.SelectedRows.Count == 0)
                return;

            DataGridViewRow selectedRow = getDocumentInvoicesDataGridView.SelectedRows[0];
            this.getInvoiceContentForAgentTableAdapter.Fill(this.dBDataSet.GetInvoiceContentForAgent, new System.Nullable<int>(((int)(System.Convert.ChangeType(selectedRow.Cells[0].Value.ToString(), typeof(int))))));

        }
    }
}
