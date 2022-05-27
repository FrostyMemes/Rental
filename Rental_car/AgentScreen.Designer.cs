
namespace Rental_car
{
    partial class AgentScreen
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
            this.tabControlAgentScreen = new System.Windows.Forms.TabControl();
            this.tabPageWaitingApplications = new System.Windows.Forms.TabPage();
            this.waitingApplicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivercertificatecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalperiodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacttelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childeseatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripWaitingApplicationTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acceptWaitingApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denyWaitingApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailClientWaitingApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waiting_applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Rental_car.DBDataSet();
            this.tabPageConfirmedApplications = new System.Windows.Forms.TabPage();
            this.getConfirmApplicationsDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getConfirmApplicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.app_monthToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.app_monthToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.app_yearToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.app_yearToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findConfirmedApplicationMonthYearfillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.client_surnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.client_surnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.client_telephoneToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.client_telephoneToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findConfirmedApplicationClientfillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshConfirmedApplicationstoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPageAgentCatalogue = new System.Windows.Forms.TabPage();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.car_VINToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.car_VINToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.car_RegNumberToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.car_RegNumberToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.car_BrandToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.car_BrandToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.car_ModelToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.car_ModelToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.RefreshCatalogueToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchCarWithParametrsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripCarTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddCar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdateCar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteCar = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCarWithParametrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageRentalCars = new System.Windows.Forms.TabPage();
            this.rental_cars_nowDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rental_cars_nowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageNotPaidInvoice = new System.Windows.Forms.TabPage();
            this.getInvoiceContentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getInvoiceContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.not_paid_invoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.not_paid_invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageClientStatistic = new System.Windows.Forms.TabPage();
            this.fillToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.client_yearToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.client_yearToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.getClientStatisticDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientStatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateAgentData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFathername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.contextMenuStripConfirmedApplicationTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waiting_applicationsTableAdapter = new Rental_car.DBDataSetTableAdapters.waiting_applicationsTableAdapter();
            this.tableAdapterManager = new Rental_car.DBDataSetTableAdapters.TableAdapterManager();
            this.searchCarWithParametrsTableAdapter = new Rental_car.DBDataSetTableAdapters.SearchCarWithParametrsTableAdapter();
            this.not_paid_invoicesTableAdapter = new Rental_car.DBDataSetTableAdapters.not_paid_invoicesTableAdapter();
            this.getInvoiceContentTableAdapter = new Rental_car.DBDataSetTableAdapters.GetInvoiceContentTableAdapter();
            this.rental_cars_nowTableAdapter = new Rental_car.DBDataSetTableAdapters.rental_cars_nowTableAdapter();
            this.getClientStatisticTableAdapter = new Rental_car.DBDataSetTableAdapters.GetClientStatisticTableAdapter();
            this.getConfirmApplicationsTableAdapter = new Rental_car.DBDataSetTableAdapters.GetConfirmApplicationsTableAdapter();
            this.getConfirmedClientApplicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getConfirmedClientApplicationsTableAdapter = new Rental_car.DBDataSetTableAdapters.GetConfirmedClientApplicationsTableAdapter();
            this.getConfirmedMonthYearApplicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getConfirmedMonthYearApplicationsTableAdapter = new Rental_car.DBDataSetTableAdapters.GetConfirmedMonthYearApplicationsTableAdapter();
            this.tabControlAgentScreen.SuspendLayout();
            this.tabPageWaitingApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingApplicationsDataGridView)).BeginInit();
            this.contextMenuStripWaitingApplicationTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waiting_applicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.tabPageConfirmedApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getConfirmApplicationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getConfirmApplicationsBindingSource)).BeginInit();
            this.fillToolStrip3.SuspendLayout();
            this.tabPageAgentCatalogue.SuspendLayout();
            this.fillToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCarWithParametrsDataGridView)).BeginInit();
            this.contextMenuStripCarTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCarWithParametrsBindingSource)).BeginInit();
            this.tabPageRentalCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rental_cars_nowDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rental_cars_nowBindingSource)).BeginInit();
            this.tabPageNotPaidInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getInvoiceContentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInvoiceContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.not_paid_invoicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.not_paid_invoicesBindingSource)).BeginInit();
            this.tabPageClientStatistic.SuspendLayout();
            this.fillToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getClientStatisticDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientStatisticBindingSource)).BeginInit();
            this.tabPageProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStripConfirmedApplicationTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getConfirmedClientApplicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getConfirmedMonthYearApplicationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAgentScreen
            // 
            this.tabControlAgentScreen.Controls.Add(this.tabPageWaitingApplications);
            this.tabControlAgentScreen.Controls.Add(this.tabPageConfirmedApplications);
            this.tabControlAgentScreen.Controls.Add(this.tabPageAgentCatalogue);
            this.tabControlAgentScreen.Controls.Add(this.tabPageRentalCars);
            this.tabControlAgentScreen.Controls.Add(this.tabPageNotPaidInvoice);
            this.tabControlAgentScreen.Controls.Add(this.tabPageClientStatistic);
            this.tabControlAgentScreen.Controls.Add(this.tabPageProfile);
            this.tabControlAgentScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAgentScreen.Location = new System.Drawing.Point(0, 0);
            this.tabControlAgentScreen.Name = "tabControlAgentScreen";
            this.tabControlAgentScreen.SelectedIndex = 0;
            this.tabControlAgentScreen.Size = new System.Drawing.Size(1308, 596);
            this.tabControlAgentScreen.TabIndex = 0;
            // 
            // tabPageWaitingApplications
            // 
            this.tabPageWaitingApplications.Controls.Add(this.waitingApplicationsDataGridView);
            this.tabPageWaitingApplications.Location = new System.Drawing.Point(4, 22);
            this.tabPageWaitingApplications.Name = "tabPageWaitingApplications";
            this.tabPageWaitingApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWaitingApplications.Size = new System.Drawing.Size(1300, 570);
            this.tabPageWaitingApplications.TabIndex = 0;
            this.tabPageWaitingApplications.Text = "Ожидающие заявки";
            this.tabPageWaitingApplications.UseVisualStyleBackColor = true;
            // 
            // waitingApplicationsDataGridView
            // 
            this.waitingApplicationsDataGridView.AllowUserToAddRows = false;
            this.waitingApplicationsDataGridView.AllowUserToDeleteRows = false;
            this.waitingApplicationsDataGridView.AutoGenerateColumns = false;
            this.waitingApplicationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.waitingApplicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitingApplicationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fathernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.drivercertificatecodeDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.registrationnumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.rentalperiodDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.applicationdateDataGridViewTextBoxColumn,
            this.receivingdateDataGridViewTextBoxColumn,
            this.returndateDataGridViewTextBoxColumn,
            this.contacttelephoneDataGridViewTextBoxColumn,
            this.childeseatDataGridViewTextBoxColumn,
            this.applicationcodeDataGridViewTextBoxColumn});
            this.waitingApplicationsDataGridView.ContextMenuStrip = this.contextMenuStripWaitingApplicationTable;
            this.waitingApplicationsDataGridView.DataSource = this.waiting_applicationsBindingSource;
            this.waitingApplicationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitingApplicationsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.waitingApplicationsDataGridView.Name = "waitingApplicationsDataGridView";
            this.waitingApplicationsDataGridView.ReadOnly = true;
            this.waitingApplicationsDataGridView.RowHeadersVisible = false;
            this.waitingApplicationsDataGridView.Size = new System.Drawing.Size(1294, 564);
            this.waitingApplicationsDataGridView.TabIndex = 0;
            this.waitingApplicationsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.waitingApplicationsDataGridView_CellDoubleClick);
            this.waitingApplicationsDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.waitingApplicationsDataGridView_CellMouseDown);
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "Fathername";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "Fathername";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            this.fathernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drivercertificatecodeDataGridViewTextBoxColumn
            // 
            this.drivercertificatecodeDataGridViewTextBoxColumn.DataPropertyName = "Driver_certificate_code";
            this.drivercertificatecodeDataGridViewTextBoxColumn.HeaderText = "Driver_certificate_code";
            this.drivercertificatecodeDataGridViewTextBoxColumn.Name = "drivercertificatecodeDataGridViewTextBoxColumn";
            this.drivercertificatecodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationnumberDataGridViewTextBoxColumn
            // 
            this.registrationnumberDataGridViewTextBoxColumn.DataPropertyName = "Registration_number";
            this.registrationnumberDataGridViewTextBoxColumn.HeaderText = "Registration_number";
            this.registrationnumberDataGridViewTextBoxColumn.Name = "registrationnumberDataGridViewTextBoxColumn";
            this.registrationnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentalperiodDataGridViewTextBoxColumn
            // 
            this.rentalperiodDataGridViewTextBoxColumn.DataPropertyName = "Rental_period";
            this.rentalperiodDataGridViewTextBoxColumn.HeaderText = "Rental_period";
            this.rentalperiodDataGridViewTextBoxColumn.Name = "rentalperiodDataGridViewTextBoxColumn";
            this.rentalperiodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicationdateDataGridViewTextBoxColumn
            // 
            this.applicationdateDataGridViewTextBoxColumn.DataPropertyName = "Application_date";
            this.applicationdateDataGridViewTextBoxColumn.HeaderText = "Application_date";
            this.applicationdateDataGridViewTextBoxColumn.Name = "applicationdateDataGridViewTextBoxColumn";
            this.applicationdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivingdateDataGridViewTextBoxColumn
            // 
            this.receivingdateDataGridViewTextBoxColumn.DataPropertyName = "Receiving_date";
            this.receivingdateDataGridViewTextBoxColumn.HeaderText = "Receiving_date";
            this.receivingdateDataGridViewTextBoxColumn.Name = "receivingdateDataGridViewTextBoxColumn";
            this.receivingdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returndateDataGridViewTextBoxColumn
            // 
            this.returndateDataGridViewTextBoxColumn.DataPropertyName = "Return_date";
            this.returndateDataGridViewTextBoxColumn.HeaderText = "Return_date";
            this.returndateDataGridViewTextBoxColumn.Name = "returndateDataGridViewTextBoxColumn";
            this.returndateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contacttelephoneDataGridViewTextBoxColumn
            // 
            this.contacttelephoneDataGridViewTextBoxColumn.DataPropertyName = "Contact_telephone";
            this.contacttelephoneDataGridViewTextBoxColumn.HeaderText = "Contact_telephone";
            this.contacttelephoneDataGridViewTextBoxColumn.Name = "contacttelephoneDataGridViewTextBoxColumn";
            this.contacttelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childeseatDataGridViewTextBoxColumn
            // 
            this.childeseatDataGridViewTextBoxColumn.DataPropertyName = "Childe_seat";
            this.childeseatDataGridViewTextBoxColumn.HeaderText = "Childe_seat";
            this.childeseatDataGridViewTextBoxColumn.Name = "childeseatDataGridViewTextBoxColumn";
            this.childeseatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicationcodeDataGridViewTextBoxColumn
            // 
            this.applicationcodeDataGridViewTextBoxColumn.DataPropertyName = "Application_code";
            this.applicationcodeDataGridViewTextBoxColumn.HeaderText = "Application_code";
            this.applicationcodeDataGridViewTextBoxColumn.Name = "applicationcodeDataGridViewTextBoxColumn";
            this.applicationcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStripWaitingApplicationTable
            // 
            this.contextMenuStripWaitingApplicationTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptWaitingApplicationToolStripMenuItem,
            this.denyWaitingApplicationToolStripMenuItem,
            this.detailClientWaitingApplicationToolStripMenuItem});
            this.contextMenuStripWaitingApplicationTable.Name = "contextMenuStripWaitingApplicationTable";
            this.contextMenuStripWaitingApplicationTable.Size = new System.Drawing.Size(194, 70);
            // 
            // acceptWaitingApplicationToolStripMenuItem
            // 
            this.acceptWaitingApplicationToolStripMenuItem.Name = "acceptWaitingApplicationToolStripMenuItem";
            this.acceptWaitingApplicationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.acceptWaitingApplicationToolStripMenuItem.Text = "Подтвердить заявку";
            this.acceptWaitingApplicationToolStripMenuItem.Click += new System.EventHandler(this.acceptWaitingApplicationToolStripMenuItem_Click);
            // 
            // denyWaitingApplicationToolStripMenuItem
            // 
            this.denyWaitingApplicationToolStripMenuItem.Name = "denyWaitingApplicationToolStripMenuItem";
            this.denyWaitingApplicationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.denyWaitingApplicationToolStripMenuItem.Text = "Отклонить заявку";
            this.denyWaitingApplicationToolStripMenuItem.Click += new System.EventHandler(this.denyWaitingApplicationToolStripMenuItem_Click);
            // 
            // detailClientWaitingApplicationToolStripMenuItem
            // 
            this.detailClientWaitingApplicationToolStripMenuItem.Name = "detailClientWaitingApplicationToolStripMenuItem";
            this.detailClientWaitingApplicationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.detailClientWaitingApplicationToolStripMenuItem.Text = "Подробнее о клиенте";
            this.detailClientWaitingApplicationToolStripMenuItem.Click += new System.EventHandler(this.detailClientWaitingApplicationToolStripMenuItem_Click);
            // 
            // waiting_applicationsBindingSource
            // 
            this.waiting_applicationsBindingSource.DataMember = "waiting_applications";
            this.waiting_applicationsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageConfirmedApplications
            // 
            this.tabPageConfirmedApplications.AutoScroll = true;
            this.tabPageConfirmedApplications.Controls.Add(this.getConfirmApplicationsDataGridView);
            this.tabPageConfirmedApplications.Controls.Add(this.fillToolStrip3);
            this.tabPageConfirmedApplications.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfirmedApplications.Name = "tabPageConfirmedApplications";
            this.tabPageConfirmedApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfirmedApplications.Size = new System.Drawing.Size(1300, 570);
            this.tabPageConfirmedApplications.TabIndex = 1;
            this.tabPageConfirmedApplications.Text = "Подтвержденные заявки";
            this.tabPageConfirmedApplications.UseVisualStyleBackColor = true;
            // 
            // getConfirmApplicationsDataGridView
            // 
            this.getConfirmApplicationsDataGridView.AllowUserToAddRows = false;
            this.getConfirmApplicationsDataGridView.AllowUserToDeleteRows = false;
            this.getConfirmApplicationsDataGridView.AutoGenerateColumns = false;
            this.getConfirmApplicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getConfirmApplicationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn78,
            this.dataGridViewTextBoxColumn79,
            this.dataGridViewTextBoxColumn80});
            this.getConfirmApplicationsDataGridView.DataSource = this.getConfirmApplicationsBindingSource;
            this.getConfirmApplicationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getConfirmApplicationsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.getConfirmApplicationsDataGridView.Name = "getConfirmApplicationsDataGridView";
            this.getConfirmApplicationsDataGridView.ReadOnly = true;
            this.getConfirmApplicationsDataGridView.RowHeadersVisible = false;
            this.getConfirmApplicationsDataGridView.Size = new System.Drawing.Size(1294, 539);
            this.getConfirmApplicationsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fathername";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fathername";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contact_telephone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contact_telephone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Driver_certificate_code";
            this.dataGridViewTextBoxColumn6.HeaderText = "Driver_certificate_code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn7.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn8.HeaderText = "Model";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Registration_number";
            this.dataGridViewTextBoxColumn9.HeaderText = "Registration_number";
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
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Childe_seat";
            this.dataGridViewTextBoxColumn11.HeaderText = "Childe_seat";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Receiving_date";
            this.dataGridViewTextBoxColumn15.HeaderText = "Receiving_date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Return_date";
            this.dataGridViewTextBoxColumn16.HeaderText = "Return_date";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Rental_period";
            this.dataGridViewTextBoxColumn17.HeaderText = "Rental_period";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn18.HeaderText = "Price";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Application_date";
            this.dataGridViewTextBoxColumn19.HeaderText = "Application_date";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Application_code";
            this.dataGridViewTextBoxColumn20.HeaderText = "Application_code";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "SurnameA";
            this.dataGridViewTextBoxColumn78.HeaderText = "SurnameA";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "NameA";
            this.dataGridViewTextBoxColumn79.HeaderText = "NameA";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "Confirmed_date";
            this.dataGridViewTextBoxColumn80.HeaderText = "Confirmed_date";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            // 
            // getConfirmApplicationsBindingSource
            // 
            this.getConfirmApplicationsBindingSource.DataMember = "GetConfirmApplications";
            this.getConfirmApplicationsBindingSource.DataSource = this.dBDataSet;
            // 
            // fillToolStrip3
            // 
            this.fillToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.app_monthToolStripLabel,
            this.app_monthToolStripTextBox,
            this.app_yearToolStripLabel,
            this.app_yearToolStripTextBox,
            this.findConfirmedApplicationMonthYearfillToolStripButton,
            this.toolStripSeparator1,
            this.client_surnameToolStripLabel,
            this.client_surnameToolStripTextBox,
            this.client_telephoneToolStripLabel,
            this.client_telephoneToolStripTextBox,
            this.findConfirmedApplicationClientfillToolStripButton,
            this.toolStripSeparator2,
            this.refreshConfirmedApplicationstoolStripButton});
            this.fillToolStrip3.Location = new System.Drawing.Point(3, 542);
            this.fillToolStrip3.Name = "fillToolStrip3";
            this.fillToolStrip3.Size = new System.Drawing.Size(1294, 25);
            this.fillToolStrip3.TabIndex = 4;
            this.fillToolStrip3.Text = "fillToolStrip3";
            // 
            // app_monthToolStripLabel
            // 
            this.app_monthToolStripLabel.Name = "app_monthToolStripLabel";
            this.app_monthToolStripLabel.Size = new System.Drawing.Size(85, 22);
            this.app_monthToolStripLabel.Text = "Месяц заявки:";
            // 
            // app_monthToolStripTextBox
            // 
            this.app_monthToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.app_monthToolStripTextBox.Name = "app_monthToolStripTextBox";
            this.app_monthToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // app_yearToolStripLabel
            // 
            this.app_yearToolStripLabel.Name = "app_yearToolStripLabel";
            this.app_yearToolStripLabel.Size = new System.Drawing.Size(68, 22);
            this.app_yearToolStripLabel.Text = "Год заявки:";
            // 
            // app_yearToolStripTextBox
            // 
            this.app_yearToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.app_yearToolStripTextBox.Name = "app_yearToolStripTextBox";
            this.app_yearToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // findConfirmedApplicationMonthYearfillToolStripButton
            // 
            this.findConfirmedApplicationMonthYearfillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findConfirmedApplicationMonthYearfillToolStripButton.Name = "findConfirmedApplicationMonthYearfillToolStripButton";
            this.findConfirmedApplicationMonthYearfillToolStripButton.Size = new System.Drawing.Size(113, 22);
            this.findConfirmedApplicationMonthYearfillToolStripButton.Text = "Найти по времени";
            this.findConfirmedApplicationMonthYearfillToolStripButton.Click += new System.EventHandler(this.findConfirmedApplicationMonthYearfillToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // client_surnameToolStripLabel
            // 
            this.client_surnameToolStripLabel.Name = "client_surnameToolStripLabel";
            this.client_surnameToolStripLabel.Size = new System.Drawing.Size(61, 22);
            this.client_surnameToolStripLabel.Text = "Фамилия:";
            // 
            // client_surnameToolStripTextBox
            // 
            this.client_surnameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.client_surnameToolStripTextBox.Name = "client_surnameToolStripTextBox";
            this.client_surnameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // client_telephoneToolStripLabel
            // 
            this.client_telephoneToolStripLabel.Name = "client_telephoneToolStripLabel";
            this.client_telephoneToolStripLabel.Size = new System.Drawing.Size(104, 22);
            this.client_telephoneToolStripLabel.Text = "Номер телефона:";
            // 
            // client_telephoneToolStripTextBox
            // 
            this.client_telephoneToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.client_telephoneToolStripTextBox.Name = "client_telephoneToolStripTextBox";
            this.client_telephoneToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // findConfirmedApplicationClientfillToolStripButton
            // 
            this.findConfirmedApplicationClientfillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findConfirmedApplicationClientfillToolStripButton.Name = "findConfirmedApplicationClientfillToolStripButton";
            this.findConfirmedApplicationClientfillToolStripButton.Size = new System.Drawing.Size(109, 22);
            this.findConfirmedApplicationClientfillToolStripButton.Text = "Найти по клиенту";
            this.findConfirmedApplicationClientfillToolStripButton.Click += new System.EventHandler(this.findConfirmedApplicationClientfillToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshConfirmedApplicationstoolStripButton
            // 
            this.refreshConfirmedApplicationstoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshConfirmedApplicationstoolStripButton.Name = "refreshConfirmedApplicationstoolStripButton";
            this.refreshConfirmedApplicationstoolStripButton.Size = new System.Drawing.Size(113, 22);
            this.refreshConfirmedApplicationstoolStripButton.Text = "Обновить таблицу";
            this.refreshConfirmedApplicationstoolStripButton.Click += new System.EventHandler(this.refreshConfirmedApplicationstoolStripButton_Click);
            // 
            // tabPageAgentCatalogue
            // 
            this.tabPageAgentCatalogue.Controls.Add(this.fillToolStrip1);
            this.tabPageAgentCatalogue.Controls.Add(this.searchCarWithParametrsDataGridView);
            this.tabPageAgentCatalogue.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgentCatalogue.Name = "tabPageAgentCatalogue";
            this.tabPageAgentCatalogue.Size = new System.Drawing.Size(1300, 570);
            this.tabPageAgentCatalogue.TabIndex = 5;
            this.tabPageAgentCatalogue.Text = "Автопарк";
            this.tabPageAgentCatalogue.UseVisualStyleBackColor = true;
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.car_VINToolStripLabel,
            this.car_VINToolStripTextBox,
            this.car_RegNumberToolStripLabel,
            this.car_RegNumberToolStripTextBox,
            this.car_BrandToolStripLabel,
            this.car_BrandToolStripTextBox,
            this.car_ModelToolStripLabel,
            this.car_ModelToolStripTextBox,
            this.fillToolStripButton2,
            this.RefreshCatalogueToolStripButton});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 545);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(1300, 25);
            this.fillToolStrip1.TabIndex = 2;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // car_VINToolStripLabel
            // 
            this.car_VINToolStripLabel.Name = "car_VINToolStripLabel";
            this.car_VINToolStripLabel.Size = new System.Drawing.Size(29, 22);
            this.car_VINToolStripLabel.Text = "VIN:";
            // 
            // car_VINToolStripTextBox
            // 
            this.car_VINToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.car_VINToolStripTextBox.Name = "car_VINToolStripTextBox";
            this.car_VINToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // car_RegNumberToolStripLabel
            // 
            this.car_RegNumberToolStripLabel.Name = "car_RegNumberToolStripLabel";
            this.car_RegNumberToolStripLabel.Size = new System.Drawing.Size(67, 22);
            this.car_RegNumberToolStripLabel.Text = "Рег. номер";
            // 
            // car_RegNumberToolStripTextBox
            // 
            this.car_RegNumberToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.car_RegNumberToolStripTextBox.Name = "car_RegNumberToolStripTextBox";
            this.car_RegNumberToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // car_BrandToolStripLabel
            // 
            this.car_BrandToolStripLabel.Name = "car_BrandToolStripLabel";
            this.car_BrandToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.car_BrandToolStripLabel.Text = "Марка";
            // 
            // car_BrandToolStripTextBox
            // 
            this.car_BrandToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.car_BrandToolStripTextBox.Name = "car_BrandToolStripTextBox";
            this.car_BrandToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // car_ModelToolStripLabel
            // 
            this.car_ModelToolStripLabel.Name = "car_ModelToolStripLabel";
            this.car_ModelToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.car_ModelToolStripLabel.Text = "Модель";
            // 
            // car_ModelToolStripTextBox
            // 
            this.car_ModelToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.car_ModelToolStripTextBox.Name = "car_ModelToolStripTextBox";
            this.car_ModelToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton2
            // 
            this.fillToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton2.Name = "fillToolStripButton2";
            this.fillToolStripButton2.Size = new System.Drawing.Size(45, 22);
            this.fillToolStripButton2.Text = "Найти";
            this.fillToolStripButton2.Click += new System.EventHandler(this.fillToolStripButton2_Click);
            // 
            // RefreshCatalogueToolStripButton
            // 
            this.RefreshCatalogueToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshCatalogueToolStripButton.Name = "RefreshCatalogueToolStripButton";
            this.RefreshCatalogueToolStripButton.Size = new System.Drawing.Size(107, 22);
            this.RefreshCatalogueToolStripButton.Text = "Обновить список";
            this.RefreshCatalogueToolStripButton.Click += new System.EventHandler(this.RefreshCatalogueToolStripButton_Click);
            // 
            // searchCarWithParametrsDataGridView
            // 
            this.searchCarWithParametrsDataGridView.AllowUserToAddRows = false;
            this.searchCarWithParametrsDataGridView.AllowUserToDeleteRows = false;
            this.searchCarWithParametrsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCarWithParametrsDataGridView.AutoGenerateColumns = false;
            this.searchCarWithParametrsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchCarWithParametrsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.searchCarWithParametrsDataGridView.ContextMenuStrip = this.contextMenuStripCarTable;
            this.searchCarWithParametrsDataGridView.DataSource = this.searchCarWithParametrsBindingSource;
            this.searchCarWithParametrsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.searchCarWithParametrsDataGridView.Name = "searchCarWithParametrsDataGridView";
            this.searchCarWithParametrsDataGridView.ReadOnly = true;
            this.searchCarWithParametrsDataGridView.RowHeadersVisible = false;
            this.searchCarWithParametrsDataGridView.Size = new System.Drawing.Size(1300, 542);
            this.searchCarWithParametrsDataGridView.TabIndex = 0;
            this.searchCarWithParametrsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchCarWithParametrsDataGridView_CellMouseDoubleClick);
            this.searchCarWithParametrsDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchCarWithParametrsDataGridView_CellMouseDown);
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "VIN";
            this.dataGridViewTextBoxColumn21.HeaderText = "VIN";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Registration_number";
            this.dataGridViewTextBoxColumn22.HeaderText = "Registration_number";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn23.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn24.HeaderText = "Model";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Engine_number";
            this.dataGridViewTextBoxColumn25.HeaderText = "Engine_number";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Engine_volume";
            this.dataGridViewTextBoxColumn26.HeaderText = "Engine_volume";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Engine_power";
            this.dataGridViewTextBoxColumn27.HeaderText = "Engine_power";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Body_type";
            this.dataGridViewTextBoxColumn28.HeaderText = "Body_type";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn29.HeaderText = "Color";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn30.HeaderText = "Category";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Registration_certificate";
            this.dataGridViewTextBoxColumn31.HeaderText = "Registration_certificate";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Passport_series";
            this.dataGridViewTextBoxColumn32.HeaderText = "Passport_series";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Passport_number";
            this.dataGridViewTextBoxColumn33.HeaderText = "Passport_number";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Owner";
            this.dataGridViewTextBoxColumn34.HeaderText = "Owner";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn35.HeaderText = "Year";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Gearbox";
            this.dataGridViewTextBoxColumn36.HeaderText = "Gearbox";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn37.HeaderText = "Price";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn38.HeaderText = "Status";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // contextMenuStripCarTable
            // 
            this.contextMenuStripCarTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddCar,
            this.toolStripMenuItemUpdateCar,
            this.toolStripMenuItemDeleteCar});
            this.contextMenuStripCarTable.Name = "contextMenuStripCarTable";
            this.contextMenuStripCarTable.Size = new System.Drawing.Size(199, 70);
            // 
            // toolStripMenuItemAddCar
            // 
            this.toolStripMenuItemAddCar.Name = "toolStripMenuItemAddCar";
            this.toolStripMenuItemAddCar.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemAddCar.Text = "Добавить автомобиль";
            this.toolStripMenuItemAddCar.Click += new System.EventHandler(this.toolStripMenuItemAddCar_Click);
            // 
            // toolStripMenuItemUpdateCar
            // 
            this.toolStripMenuItemUpdateCar.Name = "toolStripMenuItemUpdateCar";
            this.toolStripMenuItemUpdateCar.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemUpdateCar.Text = "Изменить автомобиль";
            this.toolStripMenuItemUpdateCar.Click += new System.EventHandler(this.toolStripMenuItemUpdateCar_Click);
            // 
            // toolStripMenuItemDeleteCar
            // 
            this.toolStripMenuItemDeleteCar.Name = "toolStripMenuItemDeleteCar";
            this.toolStripMenuItemDeleteCar.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemDeleteCar.Text = "Удалить автомобиль";
            // 
            // searchCarWithParametrsBindingSource
            // 
            this.searchCarWithParametrsBindingSource.DataMember = "SearchCarWithParametrs";
            this.searchCarWithParametrsBindingSource.DataSource = this.dBDataSet;
            // 
            // tabPageRentalCars
            // 
            this.tabPageRentalCars.Controls.Add(this.rental_cars_nowDataGridView);
            this.tabPageRentalCars.Location = new System.Drawing.Point(4, 22);
            this.tabPageRentalCars.Name = "tabPageRentalCars";
            this.tabPageRentalCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRentalCars.Size = new System.Drawing.Size(1300, 570);
            this.tabPageRentalCars.TabIndex = 6;
            this.tabPageRentalCars.Text = "Сейчас в прокате";
            this.tabPageRentalCars.UseVisualStyleBackColor = true;
            // 
            // rental_cars_nowDataGridView
            // 
            this.rental_cars_nowDataGridView.AllowUserToAddRows = false;
            this.rental_cars_nowDataGridView.AllowUserToDeleteRows = false;
            this.rental_cars_nowDataGridView.AutoGenerateColumns = false;
            this.rental_cars_nowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rental_cars_nowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62});
            this.rental_cars_nowDataGridView.DataSource = this.rental_cars_nowBindingSource;
            this.rental_cars_nowDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rental_cars_nowDataGridView.Location = new System.Drawing.Point(3, 3);
            this.rental_cars_nowDataGridView.Name = "rental_cars_nowDataGridView";
            this.rental_cars_nowDataGridView.ReadOnly = true;
            this.rental_cars_nowDataGridView.RowHeadersVisible = false;
            this.rental_cars_nowDataGridView.Size = new System.Drawing.Size(1294, 564);
            this.rental_cars_nowDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn53.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn54.HeaderText = "Name";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "Fathername";
            this.dataGridViewTextBoxColumn55.HeaderText = "Fathername";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "Contact_telephone";
            this.dataGridViewTextBoxColumn56.HeaderText = "Contact_telephone";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn57.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn58.HeaderText = "Model";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "Registration_number";
            this.dataGridViewTextBoxColumn59.HeaderText = "Registration_number";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "Receiving_date";
            this.dataGridViewTextBoxColumn60.HeaderText = "Receiving_date";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "application_Return_date";
            this.dataGridViewTextBoxColumn61.HeaderText = "application_Return_date";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "Late_days";
            this.dataGridViewTextBoxColumn62.HeaderText = "Late_days";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            // 
            // rental_cars_nowBindingSource
            // 
            this.rental_cars_nowBindingSource.DataMember = "rental_cars_now";
            this.rental_cars_nowBindingSource.DataSource = this.dBDataSet;
            // 
            // tabPageNotPaidInvoice
            // 
            this.tabPageNotPaidInvoice.Controls.Add(this.getInvoiceContentDataGridView);
            this.tabPageNotPaidInvoice.Controls.Add(this.not_paid_invoicesDataGridView);
            this.tabPageNotPaidInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotPaidInvoice.Name = "tabPageNotPaidInvoice";
            this.tabPageNotPaidInvoice.Size = new System.Drawing.Size(1300, 570);
            this.tabPageNotPaidInvoice.TabIndex = 2;
            this.tabPageNotPaidInvoice.Text = "Неоплаченные счета";
            this.tabPageNotPaidInvoice.UseVisualStyleBackColor = true;
            // 
            // getInvoiceContentDataGridView
            // 
            this.getInvoiceContentDataGridView.AllowUserToAddRows = false;
            this.getInvoiceContentDataGridView.AllowUserToDeleteRows = false;
            this.getInvoiceContentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getInvoiceContentDataGridView.AutoGenerateColumns = false;
            this.getInvoiceContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getInvoiceContentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52});
            this.getInvoiceContentDataGridView.DataSource = this.getInvoiceContentBindingSource;
            this.getInvoiceContentDataGridView.Location = new System.Drawing.Point(861, 0);
            this.getInvoiceContentDataGridView.Name = "getInvoiceContentDataGridView";
            this.getInvoiceContentDataGridView.ReadOnly = true;
            this.getInvoiceContentDataGridView.RowHeadersVisible = false;
            this.getInvoiceContentDataGridView.Size = new System.Drawing.Size(438, 570);
            this.getInvoiceContentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Service_name";
            this.dataGridViewTextBoxColumn49.HeaderText = "Service_name";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Service_unit";
            this.dataGridViewTextBoxColumn50.HeaderText = "Service_unit";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn51.HeaderText = "Count";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn52.HeaderText = "Price";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            // 
            // getInvoiceContentBindingSource
            // 
            this.getInvoiceContentBindingSource.DataMember = "GetInvoiceContent";
            this.getInvoiceContentBindingSource.DataSource = this.dBDataSet;
            // 
            // not_paid_invoicesDataGridView
            // 
            this.not_paid_invoicesDataGridView.AllowUserToAddRows = false;
            this.not_paid_invoicesDataGridView.AllowUserToDeleteRows = false;
            this.not_paid_invoicesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.not_paid_invoicesDataGridView.AutoGenerateColumns = false;
            this.not_paid_invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.not_paid_invoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48});
            this.not_paid_invoicesDataGridView.DataSource = this.not_paid_invoicesBindingSource;
            this.not_paid_invoicesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.not_paid_invoicesDataGridView.Name = "not_paid_invoicesDataGridView";
            this.not_paid_invoicesDataGridView.ReadOnly = true;
            this.not_paid_invoicesDataGridView.RowHeadersVisible = false;
            this.not_paid_invoicesDataGridView.Size = new System.Drawing.Size(855, 574);
            this.not_paid_invoicesDataGridView.TabIndex = 0;
            this.not_paid_invoicesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.not_paid_invoicesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Invoice_number";
            this.dataGridViewTextBoxColumn39.HeaderText = "Invoice_number";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Document_number";
            this.dataGridViewTextBoxColumn40.HeaderText = "Document_number";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Invoice_date";
            this.dataGridViewTextBoxColumn41.HeaderText = "Invoice_date";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn42.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn43.HeaderText = "Name";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Fathername";
            this.dataGridViewTextBoxColumn44.HeaderText = "Fathername";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Contact_telephone";
            this.dataGridViewTextBoxColumn45.HeaderText = "Contact_telephone";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Total_price";
            this.dataGridViewTextBoxColumn46.HeaderText = "Total_price";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn47.HeaderText = "Status";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn48.HeaderText = "Email";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            // 
            // not_paid_invoicesBindingSource
            // 
            this.not_paid_invoicesBindingSource.DataMember = "not_paid_invoices";
            this.not_paid_invoicesBindingSource.DataSource = this.dBDataSet;
            // 
            // tabPageClientStatistic
            // 
            this.tabPageClientStatistic.Controls.Add(this.fillToolStrip2);
            this.tabPageClientStatistic.Controls.Add(this.getClientStatisticDataGridView);
            this.tabPageClientStatistic.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientStatistic.Name = "tabPageClientStatistic";
            this.tabPageClientStatistic.Size = new System.Drawing.Size(1300, 570);
            this.tabPageClientStatistic.TabIndex = 4;
            this.tabPageClientStatistic.Text = "Статистика по клиентам";
            this.tabPageClientStatistic.UseVisualStyleBackColor = true;
            // 
            // fillToolStrip2
            // 
            this.fillToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.client_yearToolStripLabel,
            this.client_yearToolStripTextBox,
            this.fillToolStripButton3});
            this.fillToolStrip2.Location = new System.Drawing.Point(0, 545);
            this.fillToolStrip2.Name = "fillToolStrip2";
            this.fillToolStrip2.Size = new System.Drawing.Size(1300, 25);
            this.fillToolStrip2.TabIndex = 2;
            this.fillToolStrip2.Text = "fillToolStrip2";
            // 
            // client_yearToolStripLabel
            // 
            this.client_yearToolStripLabel.Name = "client_yearToolStripLabel";
            this.client_yearToolStripLabel.Size = new System.Drawing.Size(29, 22);
            this.client_yearToolStripLabel.Text = "Год:";
            // 
            // client_yearToolStripTextBox
            // 
            this.client_yearToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.client_yearToolStripTextBox.Name = "client_yearToolStripTextBox";
            this.client_yearToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton3
            // 
            this.fillToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton3.Name = "fillToolStripButton3";
            this.fillToolStripButton3.Size = new System.Drawing.Size(186, 22);
            this.fillToolStripButton3.Text = "Вывести пользователей по году";
            this.fillToolStripButton3.Click += new System.EventHandler(this.fillToolStripButton3_Click_1);
            // 
            // getClientStatisticDataGridView
            // 
            this.getClientStatisticDataGridView.AllowUserToAddRows = false;
            this.getClientStatisticDataGridView.AllowUserToDeleteRows = false;
            this.getClientStatisticDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getClientStatisticDataGridView.AutoGenerateColumns = false;
            this.getClientStatisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getClientStatisticDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72,
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74,
            this.dataGridViewTextBoxColumn75,
            this.dataGridViewTextBoxColumn76,
            this.dataGridViewTextBoxColumn77});
            this.getClientStatisticDataGridView.DataSource = this.getClientStatisticBindingSource;
            this.getClientStatisticDataGridView.Location = new System.Drawing.Point(0, 0);
            this.getClientStatisticDataGridView.Name = "getClientStatisticDataGridView";
            this.getClientStatisticDataGridView.ReadOnly = true;
            this.getClientStatisticDataGridView.RowHeadersVisible = false;
            this.getClientStatisticDataGridView.Size = new System.Drawing.Size(1300, 570);
            this.getClientStatisticDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "Client_number";
            this.dataGridViewTextBoxColumn63.HeaderText = "Client_number";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn64.HeaderText = "Email";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn65.HeaderText = "Password";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn66.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn67.HeaderText = "Name";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "Fathername";
            this.dataGridViewTextBoxColumn68.HeaderText = "Fathername";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "Passport_series";
            this.dataGridViewTextBoxColumn69.HeaderText = "Passport_series";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "Passport_number";
            this.dataGridViewTextBoxColumn70.HeaderText = "Passport_number";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "Passport_date";
            this.dataGridViewTextBoxColumn71.HeaderText = "Passport_date";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "Driver_certificate_code";
            this.dataGridViewTextBoxColumn72.HeaderText = "Driver_certificate_code";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn73.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn74.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "Contact_telephone";
            this.dataGridViewTextBoxColumn75.HeaderText = "Contact_telephone";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn76.HeaderText = "Address";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "Registration_date";
            this.dataGridViewTextBoxColumn77.HeaderText = "Registration_date";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            this.dataGridViewTextBoxColumn77.ReadOnly = true;
            // 
            // getClientStatisticBindingSource
            // 
            this.getClientStatisticBindingSource.DataMember = "GetClientStatistic";
            this.getClientStatisticBindingSource.DataSource = this.dBDataSet;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.groupBox1);
            this.tabPageProfile.Controls.Add(this.groupBox3);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Size = new System.Drawing.Size(1300, 570);
            this.tabPageProfile.TabIndex = 3;
            this.tabPageProfile.Text = "Профиль ";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateAgentData);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtimeBirthday);
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFathername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(8, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 458);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личная информация";
            // 
            // btnUpdateAgentData
            // 
            this.btnUpdateAgentData.Location = new System.Drawing.Point(6, 422);
            this.btnUpdateAgentData.Name = "btnUpdateAgentData";
            this.btnUpdateAgentData.Size = new System.Drawing.Size(325, 23);
            this.btnUpdateAgentData.TabIndex = 39;
            this.btnUpdateAgentData.Text = "Изменить данные";
            this.btnUpdateAgentData.UseVisualStyleBackColor = true;
            this.btnUpdateAgentData.Click += new System.EventHandler(this.btnUpdateAgentData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Location = new System.Drawing.Point(6, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 224);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Адрес";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(17, 19);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(291, 189);
            this.txtAddress.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Телефон";
            // 
            // dtimeBirthday
            // 
            this.dtimeBirthday.Location = new System.Drawing.Point(136, 126);
            this.dtimeBirthday.Name = "dtimeBirthday";
            this.dtimeBirthday.Size = new System.Drawing.Size(195, 20);
            this.dtimeBirthday.TabIndex = 34;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(136, 156);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(195, 20);
            this.txtTelephone.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отчество";
            // 
            // txtFathername
            // 
            this.txtFathername.Location = new System.Drawing.Point(136, 100);
            this.txtFathername.Name = "txtFathername";
            this.txtFathername.Size = new System.Drawing.Size(195, 20);
            this.txtFathername.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Фамилия";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(136, 42);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(195, 20);
            this.txtSurname.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Location = new System.Drawing.Point(8, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 112);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные для входа";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Не менее 8 символов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(195, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // contextMenuStripConfirmedApplicationTable
            // 
            this.contextMenuStripConfirmedApplicationTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDocumentToolStripMenuItem,
            this.createDocumentToolStripMenuItem});
            this.contextMenuStripConfirmedApplicationTable.Name = "contextMenuStripConfirmedApplicationTable";
            this.contextMenuStripConfirmedApplicationTable.Size = new System.Drawing.Size(182, 48);
            // 
            // openDocumentToolStripMenuItem
            // 
            this.openDocumentToolStripMenuItem.Name = "openDocumentToolStripMenuItem";
            this.openDocumentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.openDocumentToolStripMenuItem.Text = "Открыть договор";
            this.openDocumentToolStripMenuItem.Click += new System.EventHandler(this.openDocumentToolStripMenuItem_Click);
            // 
            // createDocumentToolStripMenuItem
            // 
            this.createDocumentToolStripMenuItem.Name = "createDocumentToolStripMenuItem";
            this.createDocumentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.createDocumentToolStripMenuItem.Text = "Оформить договор";
            this.createDocumentToolStripMenuItem.Click += new System.EventHandler(this.createDocumentToolStripMenuItem_Click);
            // 
            // waiting_applicationsTableAdapter
            // 
            this.waiting_applicationsTableAdapter.ClearBeforeFill = true;
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
            // searchCarWithParametrsTableAdapter
            // 
            this.searchCarWithParametrsTableAdapter.ClearBeforeFill = true;
            // 
            // not_paid_invoicesTableAdapter
            // 
            this.not_paid_invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // getInvoiceContentTableAdapter
            // 
            this.getInvoiceContentTableAdapter.ClearBeforeFill = true;
            // 
            // rental_cars_nowTableAdapter
            // 
            this.rental_cars_nowTableAdapter.ClearBeforeFill = true;
            // 
            // getClientStatisticTableAdapter
            // 
            this.getClientStatisticTableAdapter.ClearBeforeFill = true;
            // 
            // getConfirmApplicationsTableAdapter
            // 
            this.getConfirmApplicationsTableAdapter.ClearBeforeFill = true;
            // 
            // getConfirmedClientApplicationsBindingSource
            // 
            this.getConfirmedClientApplicationsBindingSource.DataMember = "GetConfirmedClientApplications";
            this.getConfirmedClientApplicationsBindingSource.DataSource = this.dBDataSet;
            // 
            // getConfirmedClientApplicationsTableAdapter
            // 
            this.getConfirmedClientApplicationsTableAdapter.ClearBeforeFill = true;
            // 
            // getConfirmedMonthYearApplicationsBindingSource
            // 
            this.getConfirmedMonthYearApplicationsBindingSource.DataMember = "GetConfirmedMonthYearApplications";
            this.getConfirmedMonthYearApplicationsBindingSource.DataSource = this.dBDataSet;
            // 
            // getConfirmedMonthYearApplicationsTableAdapter
            // 
            this.getConfirmedMonthYearApplicationsTableAdapter.ClearBeforeFill = true;
            // 
            // AgentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 596);
            this.Controls.Add(this.tabControlAgentScreen);
            this.Name = "AgentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgentScreen_FormClosing);
            this.Load += new System.EventHandler(this.AgentScreen_Load);
            this.Shown += new System.EventHandler(this.AgentScreen_Shown);
            this.tabControlAgentScreen.ResumeLayout(false);
            this.tabPageWaitingApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waitingApplicationsDataGridView)).EndInit();
            this.contextMenuStripWaitingApplicationTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waiting_applicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.tabPageConfirmedApplications.ResumeLayout(false);
            this.tabPageConfirmedApplications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getConfirmApplicationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getConfirmApplicationsBindingSource)).EndInit();
            this.fillToolStrip3.ResumeLayout(false);
            this.fillToolStrip3.PerformLayout();
            this.tabPageAgentCatalogue.ResumeLayout(false);
            this.tabPageAgentCatalogue.PerformLayout();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCarWithParametrsDataGridView)).EndInit();
            this.contextMenuStripCarTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchCarWithParametrsBindingSource)).EndInit();
            this.tabPageRentalCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rental_cars_nowDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rental_cars_nowBindingSource)).EndInit();
            this.tabPageNotPaidInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getInvoiceContentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInvoiceContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.not_paid_invoicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.not_paid_invoicesBindingSource)).EndInit();
            this.tabPageClientStatistic.ResumeLayout(false);
            this.tabPageClientStatistic.PerformLayout();
            this.fillToolStrip2.ResumeLayout(false);
            this.fillToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getClientStatisticDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientStatisticBindingSource)).EndInit();
            this.tabPageProfile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStripConfirmedApplicationTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getConfirmedClientApplicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getConfirmedMonthYearApplicationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAgentScreen;
        private System.Windows.Forms.TabPage tabPageWaitingApplications;
        private System.Windows.Forms.TabPage tabPageConfirmedApplications;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TabPage tabPageNotPaidInvoice;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageClientStatistic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWaitingApplicationTable;
        private System.Windows.Forms.ToolStripMenuItem acceptWaitingApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denyWaitingApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailClientWaitingApplicationToolStripMenuItem;
        private System.Windows.Forms.BindingSource waiting_applicationsBindingSource;
        private DBDataSetTableAdapters.waiting_applicationsTableAdapter waiting_applicationsTableAdapter;
        private System.Windows.Forms.DataGridView waitingApplicationsDataGridView;
        private System.Windows.Forms.TabPage tabPageAgentCatalogue;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripConfirmedApplicationTable;
        private System.Windows.Forms.ToolStripMenuItem openDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDocumentToolStripMenuItem;
        private System.Windows.Forms.BindingSource searchCarWithParametrsBindingSource;
        private DBDataSetTableAdapters.SearchCarWithParametrsTableAdapter searchCarWithParametrsTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel car_VINToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox car_VINToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel car_RegNumberToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox car_RegNumberToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel car_BrandToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox car_BrandToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel car_ModelToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox car_ModelToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton2;
        private System.Windows.Forms.ToolStripButton RefreshCatalogueToolStripButton;
        private System.Windows.Forms.DataGridView searchCarWithParametrsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.TabPage tabPageRentalCars;
        private System.Windows.Forms.BindingSource not_paid_invoicesBindingSource;
        private DBDataSetTableAdapters.not_paid_invoicesTableAdapter not_paid_invoicesTableAdapter;
        private System.Windows.Forms.DataGridView not_paid_invoicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.BindingSource getInvoiceContentBindingSource;
        private DBDataSetTableAdapters.GetInvoiceContentTableAdapter getInvoiceContentTableAdapter;
        private System.Windows.Forms.DataGridView getInvoiceContentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.BindingSource rental_cars_nowBindingSource;
        private DBDataSetTableAdapters.rental_cars_nowTableAdapter rental_cars_nowTableAdapter;
        private System.Windows.Forms.DataGridView rental_cars_nowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.BindingSource getClientStatisticBindingSource;
        private DBDataSetTableAdapters.GetClientStatisticTableAdapter getClientStatisticTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip2;
        private System.Windows.Forms.ToolStripLabel client_yearToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox client_yearToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton3;
        private System.Windows.Forms.DataGridView getClientStatisticDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCarTable;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddCar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdateCar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtimeBirthday;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFathername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivercertificatecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalperiodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacttelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childeseatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillToolStrip3;
        private System.Windows.Forms.ToolStripLabel app_monthToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox app_monthToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel app_yearToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox app_yearToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findConfirmedApplicationMonthYearfillToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel client_surnameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox client_surnameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel client_telephoneToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox client_telephoneToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findConfirmedApplicationClientfillToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton refreshConfirmedApplicationstoolStripButton;
        private System.Windows.Forms.Button btnUpdateAgentData;
        private System.Windows.Forms.BindingSource getConfirmApplicationsBindingSource;
        private DBDataSetTableAdapters.GetConfirmApplicationsTableAdapter getConfirmApplicationsTableAdapter;
        private System.Windows.Forms.DataGridView getConfirmApplicationsDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.BindingSource getConfirmedClientApplicationsBindingSource;
        private DBDataSetTableAdapters.GetConfirmedClientApplicationsTableAdapter getConfirmedClientApplicationsTableAdapter;
        private System.Windows.Forms.BindingSource getConfirmedMonthYearApplicationsBindingSource;
        private DBDataSetTableAdapters.GetConfirmedMonthYearApplicationsTableAdapter getConfirmedMonthYearApplicationsTableAdapter;
    }
}