
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
            this.tabPageConfirmedApplications = new System.Windows.Forms.TabPage();
            this.tabPageAgentCatalogue = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.applicationcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacttelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitingapplicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Rental_car.DBDataSet();
            this.waiting_applicationsTableAdapter = new Rental_car.DBDataSetTableAdapters.waiting_applicationsTableAdapter();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabPageClientStatistic = new System.Windows.Forms.TabPage();
            this.tabControlAgentScreen.SuspendLayout();
            this.tabPageWaitingApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingapplicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAgentScreen
            // 
            this.tabControlAgentScreen.Controls.Add(this.tabPageWaitingApplications);
            this.tabControlAgentScreen.Controls.Add(this.tabPageConfirmedApplications);
            this.tabControlAgentScreen.Controls.Add(this.tabPageAgentCatalogue);
            this.tabControlAgentScreen.Controls.Add(this.tabPageProfile);
            this.tabControlAgentScreen.Controls.Add(this.tabPageClientStatistic);
            this.tabControlAgentScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAgentScreen.Location = new System.Drawing.Point(0, 0);
            this.tabControlAgentScreen.Name = "tabControlAgentScreen";
            this.tabControlAgentScreen.SelectedIndex = 0;
            this.tabControlAgentScreen.Size = new System.Drawing.Size(1394, 585);
            this.tabControlAgentScreen.TabIndex = 0;
            // 
            // tabPageWaitingApplications
            // 
            this.tabPageWaitingApplications.Controls.Add(this.dataGridView1);
            this.tabPageWaitingApplications.Location = new System.Drawing.Point(4, 22);
            this.tabPageWaitingApplications.Name = "tabPageWaitingApplications";
            this.tabPageWaitingApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWaitingApplications.Size = new System.Drawing.Size(1386, 559);
            this.tabPageWaitingApplications.TabIndex = 0;
            this.tabPageWaitingApplications.Text = "Ожидающие заявки";
            this.tabPageWaitingApplications.UseVisualStyleBackColor = true;
            this.tabPageWaitingApplications.Click += new System.EventHandler(this.tabPageWaitingApplications_Click);
            // 
            // tabPageConfirmedApplications
            // 
            this.tabPageConfirmedApplications.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfirmedApplications.Name = "tabPageConfirmedApplications";
            this.tabPageConfirmedApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfirmedApplications.Size = new System.Drawing.Size(1386, 559);
            this.tabPageConfirmedApplications.TabIndex = 1;
            this.tabPageConfirmedApplications.Text = "Подтвержденные заявки";
            this.tabPageConfirmedApplications.UseVisualStyleBackColor = true;
            // 
            // tabPageAgentCatalogue
            // 
            this.tabPageAgentCatalogue.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgentCatalogue.Name = "tabPageAgentCatalogue";
            this.tabPageAgentCatalogue.Size = new System.Drawing.Size(1386, 559);
            this.tabPageAgentCatalogue.TabIndex = 2;
            this.tabPageAgentCatalogue.Text = "Автопарк";
            this.tabPageAgentCatalogue.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.applicationcodeDataGridViewTextBoxColumn,
            this.applicationdateDataGridViewTextBoxColumn,
            this.receivingdateDataGridViewTextBoxColumn,
            this.returndateDataGridViewTextBoxColumn,
            this.contacttelephoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.waitingapplicationsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1380, 553);
            this.dataGridView1.TabIndex = 0;
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
            // applicationcodeDataGridViewTextBoxColumn
            // 
            this.applicationcodeDataGridViewTextBoxColumn.DataPropertyName = "Application_code";
            this.applicationcodeDataGridViewTextBoxColumn.HeaderText = "Application_code";
            this.applicationcodeDataGridViewTextBoxColumn.Name = "applicationcodeDataGridViewTextBoxColumn";
            this.applicationcodeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // waitingapplicationsBindingSource
            // 
            this.waitingapplicationsBindingSource.DataMember = "waiting_applications";
            this.waitingapplicationsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waiting_applicationsTableAdapter
            // 
            this.waiting_applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Size = new System.Drawing.Size(1386, 559);
            this.tabPageProfile.TabIndex = 3;
            this.tabPageProfile.Text = "Профиль ";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // tabPageClientStatistic
            // 
            this.tabPageClientStatistic.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientStatistic.Name = "tabPageClientStatistic";
            this.tabPageClientStatistic.Size = new System.Drawing.Size(1386, 559);
            this.tabPageClientStatistic.TabIndex = 4;
            this.tabPageClientStatistic.Text = "Статистика по клиентам";
            this.tabPageClientStatistic.UseVisualStyleBackColor = true;
            // 
            // AgentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 585);
            this.Controls.Add(this.tabControlAgentScreen);
            this.Name = "AgentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать!";
            this.Load += new System.EventHandler(this.AgentScreen_Load);
            this.tabControlAgentScreen.ResumeLayout(false);
            this.tabPageWaitingApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingapplicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageAgentCatalogue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource waitingapplicationsBindingSource;
        private DBDataSetTableAdapters.waiting_applicationsTableAdapter waiting_applicationsTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacttelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageClientStatistic;
    }
}