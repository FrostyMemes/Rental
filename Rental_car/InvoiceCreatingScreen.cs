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

                if (getDocumentInvoicesDataGridView.SelectedRows.Count == 0)
                    return;

                DataGridViewRow selectedRow = getDocumentInvoicesDataGridView.SelectedRows[0];
                this.getInvoiceContentForAgentTableAdapter.Fill(this.dBDataSet.GetInvoiceContentForAgent, new System.Nullable<int>(((int)(System.Convert.ChangeType(selectedRow.Cells[0].Value.ToString(), typeof(int))))));

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

                var invoice_information = DBConnection.GetResultQueryDataTable($@"SELECT * FROM invoice WHERE Invoice_number = {selectedRow.Cells[0].Value.ToString()}");
                var invoice_content_information = DBConnection.GetResultQueryDataTable($@"SELECT * FROM invoice_content WHERE Invoice_number = {selectedRow.Cells[0].Value.ToString()}");
                string invoiceNum = invoice_information.Rows[0][0].ToString(); 
                string documentNum = invoice_information.Rows[0][1].ToString();
                DateTime dateInvoice = DateTime.Parse(invoice_information.Rows[0][2].ToString());                
                string address = invoice_information.Rows[0][3].ToString();
                string TIN = invoice_information.Rows[0][4].ToString();
                string RVC = invoice_information.Rows[0][5].ToString();
                string BIC = invoice_information.Rows[0][6].ToString();
                string VAT = invoice_information.Rows[0][7].ToString();
                string totalPrice = invoice_information.Rows[0][10].ToString();
                int startInvoiceContentIndex = 8;


                documentNum = new string('0', 10 - documentNum.Length) + documentNum;
                invoiceNum = new string('0', 7 - invoiceNum.Length) + invoiceNum;

                string invoiceFullNumber = $@"{invoiceNum}.{documentNum}";

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


                range = (Excel.Range)sheet.get_Range("B1", "F1").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);
                range = (Excel.Range)sheet.get_Range("B2", "F2").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);
                range = (Excel.Range)sheet.get_Range("B3", "F3").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);

                sheet.Cells[1, 7] = $@"Адрес: {address}";
                range = (Excel.Range)sheet.get_Range("G1", "I3").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);

                sheet.Cells[5, 1] = $@"Счет № {invoiceFullNumber} от {dateInvoice.ToString("dd MMMM yyyy")} г.";
                range = (Excel.Range)sheet.get_Range("A5", "I5").Cells;
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThick;
                range.Font.Bold = true;
                range.Merge(Type.Missing);
         

                sheet.Cells[startInvoiceContentIndex - 1, 1] = "№";
                range = (Excel.Range) sheet.Range[sheet.Cells[startInvoiceContentIndex - 1, 1], sheet.Cells[startInvoiceContentIndex - 1, 1]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                

                sheet.Cells[startInvoiceContentIndex - 1, 2] = "Товары (работы, услуги)";
                range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex - 1, 2], sheet.Cells[startInvoiceContentIndex - 1, 4]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);              
                range.Merge(Type.Missing);

                sheet.Cells[startInvoiceContentIndex - 1, 5] = "Ед.";
                range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex - 1, 5], sheet.Cells[startInvoiceContentIndex - 1, 5]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                ;

                sheet.Cells[startInvoiceContentIndex - 1, 6] = "Кол-во";
                range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex - 1, 6], sheet.Cells[startInvoiceContentIndex - 1, 6]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                

                sheet.Cells[startInvoiceContentIndex - 1, 7] = "Цена";
                range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex - 1, 7], sheet.Cells[startInvoiceContentIndex - 1, 7]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);


                sheet.Cells[startInvoiceContentIndex - 1, 8] = "Сумма";
                range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex - 1, 8], sheet.Cells[startInvoiceContentIndex - 1, 9]];
                range.HorizontalAlignment = Excel.Constants.xlLeft;
                range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                range.Merge(Type.Missing);

                int sum = 0;

                for (int i = 0; i != invoice_content_information.Rows.Count; i++)
                {
                    sheet.Cells[startInvoiceContentIndex +i, 1] = (i+1).ToString();
                    range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex + i, 1], sheet.Cells[startInvoiceContentIndex + i, 1]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);


                    sheet.Cells[startInvoiceContentIndex + i, 2] = invoice_content_information.Rows[i][2].ToString();
                    range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex + i, 2], sheet.Cells[startInvoiceContentIndex + i, 4]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    range.Merge(Type.Missing);

                    sheet.Cells[startInvoiceContentIndex + i, 5] = invoice_content_information.Rows[i][3].ToString();
                    range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex + i, 5], sheet.Cells[startInvoiceContentIndex + i, 5]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    

                    sheet.Cells[startInvoiceContentIndex + i, 6] = invoice_content_information.Rows[i][4].ToString();
                    range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex + i, 6], sheet.Cells[startInvoiceContentIndex + i, 6]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);


                    sheet.Cells[startInvoiceContentIndex + i, 7] = (int.Parse(invoice_content_information.Rows[i][5].ToString())/int.Parse(invoice_content_information.Rows[i][4].ToString())).ToString();
                    range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex + i, 7], sheet.Cells[startInvoiceContentIndex + i, 7]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);


                    sheet.Cells[startInvoiceContentIndex + i, 8] = invoice_content_information.Rows[i][5].ToString();
                    range = (Excel.Range)sheet.Range[sheet.Cells[startInvoiceContentIndex + i, 8], sheet.Cells[startInvoiceContentIndex + i, 9]];
                    range.HorizontalAlignment = Excel.Constants.xlLeft;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    range.Merge(Type.Missing);
                    sum += int.Parse(invoice_content_information.Rows[i][5].ToString());



                }

                int result = startInvoiceContentIndex + invoice_content_information.Rows.Count;

                sheet.Cells[result, 8] = "Итого:";
                sheet.Cells[result, 9] = sum;
                sheet.Cells[result + 1, 8] = "НДС:";
                sheet.Cells[result + 1, 9] = VAT;


                sheet.Cells[result + 2, 7] = "Всего к оплате:";
                range = (Excel.Range)sheet.Range[sheet.Cells[result + 2, 7], sheet.Cells[result + 2, 8]];
                range.HorizontalAlignment = Excel.Constants.xlRight;
                range.Font.Bold = true;
                range.Merge(Type.Missing);
                sheet.Cells[result + 2, 9] = totalPrice;


                sheet.Cells[result + 4, 1] = "Заверил:";

                range = (Excel.Range)sheet.Range[sheet.Cells[result + 4, 2], sheet.Cells[result + 4, 3]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Font.Bold = true;
                range.Merge(Type.Missing);


                sheet.Cells[result + 4, 4] = $@"{Program.agentCard.Surname} {Program.agentCard.Name[0]}.{Program.agentCard.Fathername[0]}.";
                range = (Excel.Range)sheet.Range[sheet.Cells[result + 4, 4], sheet.Cells[result + 4, 5]];
                range.Merge(Type.Missing);


                sheet.Cells[result + 6, 1] = "Плательщик:";

                range = (Excel.Range)sheet.Range[sheet.Cells[result + 6, 2], sheet.Cells[result + 6, 3]];
                range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Font.Bold = true;
                range.Merge(Type.Missing);

                sheet.Cells[result + 6, 4] = $@"{Program.documentCard.clientCard.Surname} {Program.documentCard.clientCard.Name[0]}.{Program.documentCard.clientCard.Fathername[0]}.";
                range = (Excel.Range)sheet.Range[sheet.Cells[result + 6, 4], sheet.Cells[result + 6, 5]];
                range.Merge(Type.Missing);

                workBook.SaveAs(invoiceFullNumber);


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

        private void buttonConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (getDocumentInvoicesDataGridView.SelectedRows.Count == 0)
                    return;

                DataGridViewRow selectedRow = getDocumentInvoicesDataGridView.SelectedRows[0];
                DBConnection.RunQuery($@"UPDATE invoice set Status = 'Оплачен' WHERE Invoice_number =  {selectedRow.Cells[0].Value.ToString()}");
                selectedRow.Cells[9].Value = "Оплачен";


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && (e.KeyChar !=8);
        }

      

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && (e.KeyChar != 8);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && (e.KeyChar != 8);
        }

        private void textBoxVAT_Leave(object sender, EventArgs e)
        {
            if (int.Parse(textBoxVAT.Text) > 0)
                textBoxVAT.Text = "100";
        }
    }
}
