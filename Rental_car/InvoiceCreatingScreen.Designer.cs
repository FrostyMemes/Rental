
namespace Rental_car
{
    partial class InvoiceCreatingScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddNewInvoice = new System.Windows.Forms.Button();
            this.getDocumentInvoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDeleteInvoice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddInvoiceContent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxServiceUnit = new System.Windows.Forms.TextBox();
            this.buttonPrintInvoice = new System.Windows.Forms.Button();
            this.textBoxVAT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.getInvoiceContentForAgentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getInvoiceContentForAgentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Rental_car.DBDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getDocumentInvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDocumentInvoicesTableAdapter = new Rental_car.DBDataSetTableAdapters.GetDocumentInvoicesTableAdapter();
            this.tableAdapterManager = new Rental_car.DBDataSetTableAdapters.TableAdapterManager();
            this.getInvoiceContentForAgentTableAdapter = new Rental_car.DBDataSetTableAdapters.GetInvoiceContentForAgentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getDocumentInvoicesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getInvoiceContentForAgentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInvoiceContentForAgentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDocumentInvoicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewInvoice
            // 
            this.buttonAddNewInvoice.Location = new System.Drawing.Point(0, 392);
            this.buttonAddNewInvoice.Name = "buttonAddNewInvoice";
            this.buttonAddNewInvoice.Size = new System.Drawing.Size(162, 34);
            this.buttonAddNewInvoice.TabIndex = 1;
            this.buttonAddNewInvoice.Text = "Добавить новый счет";
            this.buttonAddNewInvoice.UseVisualStyleBackColor = true;
            this.buttonAddNewInvoice.Click += new System.EventHandler(this.buttonAddNewInvoice_Click);
            // 
            // getDocumentInvoicesDataGridView
            // 
            this.getDocumentInvoicesDataGridView.AllowUserToAddRows = false;
            this.getDocumentInvoicesDataGridView.AllowUserToDeleteRows = false;
            this.getDocumentInvoicesDataGridView.AutoGenerateColumns = false;
            this.getDocumentInvoicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getDocumentInvoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getDocumentInvoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.getDocumentInvoicesDataGridView.DataSource = this.getDocumentInvoicesBindingSource;
            this.getDocumentInvoicesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.getDocumentInvoicesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.getDocumentInvoicesDataGridView.MultiSelect = false;
            this.getDocumentInvoicesDataGridView.Name = "getDocumentInvoicesDataGridView";
            this.getDocumentInvoicesDataGridView.ReadOnly = true;
            this.getDocumentInvoicesDataGridView.RowHeadersVisible = false;
            this.getDocumentInvoicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.getDocumentInvoicesDataGridView.Size = new System.Drawing.Size(1030, 164);
            this.getDocumentInvoicesDataGridView.TabIndex = 3;
            this.getDocumentInvoicesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.getDocumentInvoicesDataGridView_CellMouseClick);
            // 
            // buttonDeleteInvoice
            // 
            this.buttonDeleteInvoice.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteInvoice.Location = new System.Drawing.Point(0, 432);
            this.buttonDeleteInvoice.Name = "buttonDeleteInvoice";
            this.buttonDeleteInvoice.Size = new System.Drawing.Size(162, 34);
            this.buttonDeleteInvoice.TabIndex = 5;
            this.buttonDeleteInvoice.Text = "Удалить счет";
            this.buttonDeleteInvoice.UseVisualStyleBackColor = true;
            this.buttonDeleteInvoice.Click += new System.EventHandler(this.buttonDeleteInvoice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddInvoiceContent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxService);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.textBoxCount);
            this.groupBox1.Controls.Add(this.textBoxServiceUnit);
            this.groupBox1.Location = new System.Drawing.Point(258, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Содержимое счета";
            // 
            // buttonAddInvoiceContent
            // 
            this.buttonAddInvoiceContent.Location = new System.Drawing.Point(320, 76);
            this.buttonAddInvoiceContent.Name = "buttonAddInvoiceContent";
            this.buttonAddInvoiceContent.Size = new System.Drawing.Size(116, 23);
            this.buttonAddInvoiceContent.TabIndex = 9;
            this.buttonAddInvoiceContent.Text = "Добавить";
            this.buttonAddInvoiceContent.UseVisualStyleBackColor = true;
            this.buttonAddInvoiceContent.Click += new System.EventHandler(this.buttonAddInvoiceContent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена за услугу/и";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Единица услуги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Услуга";
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(21, 42);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(172, 20);
            this.textBoxService.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(555, 42);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(172, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(377, 42);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(172, 20);
            this.textBoxCount.TabIndex = 1;
            // 
            // textBoxServiceUnit
            // 
            this.textBoxServiceUnit.Location = new System.Drawing.Point(199, 42);
            this.textBoxServiceUnit.Name = "textBoxServiceUnit";
            this.textBoxServiceUnit.Size = new System.Drawing.Size(172, 20);
            this.textBoxServiceUnit.TabIndex = 0;
            // 
            // buttonPrintInvoice
            // 
            this.buttonPrintInvoice.Location = new System.Drawing.Point(0, 472);
            this.buttonPrintInvoice.Name = "buttonPrintInvoice";
            this.buttonPrintInvoice.Size = new System.Drawing.Size(162, 22);
            this.buttonPrintInvoice.TabIndex = 7;
            this.buttonPrintInvoice.Text = "Распечатать счет";
            this.buttonPrintInvoice.UseVisualStyleBackColor = true;
            this.buttonPrintInvoice.Click += new System.EventHandler(this.buttonPrintInvoice_Click);
            // 
            // textBoxVAT
            // 
            this.textBoxVAT.Location = new System.Drawing.Point(168, 474);
            this.textBoxVAT.Name = "textBoxVAT";
            this.textBoxVAT.Size = new System.Drawing.Size(84, 20);
            this.textBoxVAT.TabIndex = 10;
            this.textBoxVAT.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "НДС";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(168, 392);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 34);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // getInvoiceContentForAgentDataGridView
            // 
            this.getInvoiceContentForAgentDataGridView.AllowUserToAddRows = false;
            this.getInvoiceContentForAgentDataGridView.AllowUserToDeleteRows = false;
            this.getInvoiceContentForAgentDataGridView.AutoGenerateColumns = false;
            this.getInvoiceContentForAgentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getInvoiceContentForAgentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getInvoiceContentForAgentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.getInvoiceContentForAgentDataGridView.DataSource = this.getInvoiceContentForAgentBindingSource;
            this.getInvoiceContentForAgentDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.getInvoiceContentForAgentDataGridView.Location = new System.Drawing.Point(0, 164);
            this.getInvoiceContentForAgentDataGridView.MultiSelect = false;
            this.getInvoiceContentForAgentDataGridView.Name = "getInvoiceContentForAgentDataGridView";
            this.getInvoiceContentForAgentDataGridView.ReadOnly = true;
            this.getInvoiceContentForAgentDataGridView.RowHeadersVisible = false;
            this.getInvoiceContentForAgentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.getInvoiceContentForAgentDataGridView.Size = new System.Drawing.Size(1030, 220);
            this.getInvoiceContentForAgentDataGridView.TabIndex = 11;
            this.getInvoiceContentForAgentDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.getInvoiceContentForAgentDataGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Record_code";
            this.dataGridViewTextBoxColumn12.HeaderText = "Record_code";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Invoice_number";
            this.dataGridViewTextBoxColumn13.HeaderText = "Invoice_number";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Service_name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Service_name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Service_unit";
            this.dataGridViewTextBoxColumn15.HeaderText = "Service_unit";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn16.HeaderText = "Count";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn17.HeaderText = "Price";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // getInvoiceContentForAgentBindingSource
            // 
            this.getInvoiceContentForAgentBindingSource.DataMember = "GetInvoiceContentForAgent";
            this.getInvoiceContentForAgentBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Invoice_number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice_number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Document_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Document_number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Invoice_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Invoice_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "TIN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RVC";
            this.dataGridViewTextBoxColumn6.HeaderText = "RVC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BIC";
            this.dataGridViewTextBoxColumn7.HeaderText = "BIC";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VAT";
            this.dataGridViewTextBoxColumn8.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Agent_number";
            this.dataGridViewTextBoxColumn9.HeaderText = "Agent_number";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn10.HeaderText = "Status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Total_price";
            this.dataGridViewTextBoxColumn11.HeaderText = "Total_price";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // getDocumentInvoicesBindingSource
            // 
            this.getDocumentInvoicesBindingSource.DataMember = "GetDocumentInvoices";
            this.getDocumentInvoicesBindingSource.DataSource = this.dBDataSet;
            // 
            // getDocumentInvoicesTableAdapter
            // 
            this.getDocumentInvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agentTableAdapter = null;
            this.tableAdapterManager.applicationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.documentTableAdapter = null;
            this.tableAdapterManager.invoice_contentTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rental_car.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // getInvoiceContentForAgentTableAdapter
            // 
            this.getInvoiceContentForAgentTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceCreatingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 515);
            this.Controls.Add(this.getInvoiceContentForAgentDataGridView);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVAT);
            this.Controls.Add(this.buttonPrintInvoice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeleteInvoice);
            this.Controls.Add(this.getDocumentInvoicesDataGridView);
            this.Controls.Add(this.buttonAddNewInvoice);
            this.Name = "InvoiceCreatingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление счета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoiceCreatingScreen_FormClosing);
            this.Load += new System.EventHandler(this.InvoiceCreatingScreen_Load);
            this.Shown += new System.EventHandler(this.InvoiceCreatingScreen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.getDocumentInvoicesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getInvoiceContentForAgentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInvoiceContentForAgentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDocumentInvoicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewInvoice;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource getDocumentInvoicesBindingSource;
        private DBDataSetTableAdapters.GetDocumentInvoicesTableAdapter getDocumentInvoicesTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView getDocumentInvoicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button buttonDeleteInvoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddInvoiceContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxServiceUnit;
        private System.Windows.Forms.Button buttonPrintInvoice;
        private System.Windows.Forms.TextBox textBoxVAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.BindingSource getInvoiceContentForAgentBindingSource;
        private DBDataSetTableAdapters.GetInvoiceContentForAgentTableAdapter getInvoiceContentForAgentTableAdapter;
        private System.Windows.Forms.DataGridView getInvoiceContentForAgentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}