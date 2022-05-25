
namespace Rental_car
{
    partial class ClientDetailScreen
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
            this.groupBoxClientApplications = new System.Windows.Forms.GroupBox();
            this.getClientApplicationForAgentDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientApplicationForAgentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Rental_car.DBDataSet();
            this.ClientInformation = new System.Windows.Forms.GroupBox();
            this.labelNumberPassport = new System.Windows.Forms.Label();
            this.labelDriverCode = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelRegistrationDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelSeriesPassport = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFathername = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.getClientApplicationForAgentTableAdapter = new Rental_car.DBDataSetTableAdapters.GetClientApplicationForAgentTableAdapter();
            this.tableAdapterManager = new Rental_car.DBDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getClientDamagedCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientDamagedCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClientDamagedCarsTableAdapter = new Rental_car.DBDataSetTableAdapters.GetClientDamagedCarsTableAdapter();
            this.groupBoxClientApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getClientApplicationForAgentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientApplicationForAgentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.ClientInformation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDamagedCarsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDamagedCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxClientApplications
            // 
            this.groupBoxClientApplications.Controls.Add(this.getClientApplicationForAgentDataGridView);
            this.groupBoxClientApplications.Location = new System.Drawing.Point(14, 12);
            this.groupBoxClientApplications.Name = "groupBoxClientApplications";
            this.groupBoxClientApplications.Size = new System.Drawing.Size(684, 492);
            this.groupBoxClientApplications.TabIndex = 21;
            this.groupBoxClientApplications.TabStop = false;
            this.groupBoxClientApplications.Text = "История проката";
            // 
            // getClientApplicationForAgentDataGridView
            // 
            this.getClientApplicationForAgentDataGridView.AllowUserToAddRows = false;
            this.getClientApplicationForAgentDataGridView.AllowUserToDeleteRows = false;
            this.getClientApplicationForAgentDataGridView.AutoGenerateColumns = false;
            this.getClientApplicationForAgentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getClientApplicationForAgentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.getClientApplicationForAgentDataGridView.DataSource = this.getClientApplicationForAgentBindingSource;
            this.getClientApplicationForAgentDataGridView.Location = new System.Drawing.Point(15, 33);
            this.getClientApplicationForAgentDataGridView.Name = "getClientApplicationForAgentDataGridView";
            this.getClientApplicationForAgentDataGridView.ReadOnly = true;
            this.getClientApplicationForAgentDataGridView.RowHeadersVisible = false;
            this.getClientApplicationForAgentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.getClientApplicationForAgentDataGridView.Size = new System.Drawing.Size(649, 439);
            this.getClientApplicationForAgentDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VIN";
            this.dataGridViewTextBoxColumn1.HeaderText = "VIN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Registration_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Registration_number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn5.HeaderText = "Color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gearbox";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gearbox";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Receiving_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Receiving_date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Return_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Return_date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Rental_period";
            this.dataGridViewTextBoxColumn9.HeaderText = "Rental_period";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn10.HeaderText = "Price";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn11.HeaderText = "Status";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Application_code";
            this.dataGridViewTextBoxColumn12.HeaderText = "Application_code";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Document_number";
            this.dataGridViewTextBoxColumn13.HeaderText = "Document_number";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // getClientApplicationForAgentBindingSource
            // 
            this.getClientApplicationForAgentBindingSource.DataMember = "GetClientApplicationForAgent";
            this.getClientApplicationForAgentBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientInformation
            // 
            this.ClientInformation.Controls.Add(this.labelNumberPassport);
            this.ClientInformation.Controls.Add(this.labelDriverCode);
            this.ClientInformation.Controls.Add(this.labelBirth);
            this.ClientInformation.Controls.Add(this.labelGender);
            this.ClientInformation.Controls.Add(this.labelRegistrationDate);
            this.ClientInformation.Controls.Add(this.groupBox2);
            this.ClientInformation.Controls.Add(this.labelSeriesPassport);
            this.ClientInformation.Controls.Add(this.labelTelephone);
            this.ClientInformation.Controls.Add(this.labelEmail);
            this.ClientInformation.Controls.Add(this.labelFathername);
            this.ClientInformation.Controls.Add(this.labelName);
            this.ClientInformation.Controls.Add(this.labelSurname);
            this.ClientInformation.Location = new System.Drawing.Point(12, 31);
            this.ClientInformation.Name = "ClientInformation";
            this.ClientInformation.Size = new System.Drawing.Size(368, 523);
            this.ClientInformation.TabIndex = 22;
            this.ClientInformation.TabStop = false;
            this.ClientInformation.Text = "Личная информация клиента";
            // 
            // labelNumberPassport
            // 
            this.labelNumberPassport.AutoSize = true;
            this.labelNumberPassport.Location = new System.Drawing.Point(56, 194);
            this.labelNumberPassport.Name = "labelNumberPassport";
            this.labelNumberPassport.Size = new System.Drawing.Size(97, 13);
            this.labelNumberPassport.TabIndex = 45;
            this.labelNumberPassport.Text = "Номер паспорта: ";
            // 
            // labelDriverCode
            // 
            this.labelDriverCode.AutoSize = true;
            this.labelDriverCode.Location = new System.Drawing.Point(18, 221);
            this.labelDriverCode.Name = "labelDriverCode";
            this.labelDriverCode.Size = new System.Drawing.Size(135, 13);
            this.labelDriverCode.TabIndex = 44;
            this.labelDriverCode.Text = "Код вод. удостоверения: ";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(60, 245);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(93, 13);
            this.labelBirth.TabIndex = 43;
            this.labelBirth.Text = "День рождения: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(119, 272);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(33, 13);
            this.labelGender.TabIndex = 42;
            this.labelGender.Text = "Пол: ";
            // 
            // labelRegistrationDate
            // 
            this.labelRegistrationDate.AutoSize = true;
            this.labelRegistrationDate.Location = new System.Drawing.Point(46, 300);
            this.labelRegistrationDate.Name = "labelRegistrationDate";
            this.labelRegistrationDate.Size = new System.Drawing.Size(106, 13);
            this.labelRegistrationDate.TabIndex = 41;
            this.labelRegistrationDate.Text = "Дата регистрации: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Location = new System.Drawing.Point(21, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 159);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Адрес";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(17, 19);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(291, 121);
            this.txtAddress.TabIndex = 10;
            // 
            // labelSeriesPassport
            // 
            this.labelSeriesPassport.AutoSize = true;
            this.labelSeriesPassport.Location = new System.Drawing.Point(59, 164);
            this.labelSeriesPassport.Name = "labelSeriesPassport";
            this.labelSeriesPassport.Size = new System.Drawing.Size(94, 13);
            this.labelSeriesPassport.TabIndex = 37;
            this.labelSeriesPassport.Text = "Серия паспорта: ";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(95, 139);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(58, 13);
            this.labelTelephone.TabIndex = 35;
            this.labelTelephone.Text = "Телефон: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(115, 114);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 28;
            this.labelEmail.Text = "Email: ";
            // 
            // labelFathername
            // 
            this.labelFathername.AutoSize = true;
            this.labelFathername.Location = new System.Drawing.Point(93, 90);
            this.labelFathername.Name = "labelFathername";
            this.labelFathername.Size = new System.Drawing.Size(60, 13);
            this.labelFathername.TabIndex = 20;
            this.labelFathername.Text = "Отчество: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(115, 68);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Имя: ";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(88, 46);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(62, 13);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Фамилия: ";
            // 
            // getClientApplicationForAgentTableAdapter
            // 
            this.getClientApplicationForAgentTableAdapter.ClearBeforeFill = true;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxClientApplications);
            this.panel1.Location = new System.Drawing.Point(396, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 554);
            this.panel1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getClientDamagedCarsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(14, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 484);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поврежденные автомобили";
            // 
            // getClientDamagedCarsDataGridView
            // 
            this.getClientDamagedCarsDataGridView.AllowUserToAddRows = false;
            this.getClientDamagedCarsDataGridView.AllowUserToDeleteRows = false;
            this.getClientDamagedCarsDataGridView.AutoGenerateColumns = false;
            this.getClientDamagedCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getClientDamagedCarsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.getClientDamagedCarsDataGridView.DataSource = this.getClientDamagedCarsBindingSource;
            this.getClientDamagedCarsDataGridView.Location = new System.Drawing.Point(15, 27);
            this.getClientDamagedCarsDataGridView.Name = "getClientDamagedCarsDataGridView";
            this.getClientDamagedCarsDataGridView.ReadOnly = true;
            this.getClientDamagedCarsDataGridView.RowHeadersVisible = false;
            this.getClientDamagedCarsDataGridView.Size = new System.Drawing.Size(649, 454);
            this.getClientDamagedCarsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "VIN";
            this.dataGridViewTextBoxColumn14.HeaderText = "VIN";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Registration_number";
            this.dataGridViewTextBoxColumn15.HeaderText = "Registration_number";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn16.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn17.HeaderText = "Model";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn18.HeaderText = "Color";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Description_damage_after";
            this.dataGridViewTextBoxColumn19.HeaderText = "Description_damage_after";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn20.HeaderText = "Status";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Document_number";
            this.dataGridViewTextBoxColumn21.HeaderText = "Document_number";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // getClientDamagedCarsBindingSource
            // 
            this.getClientDamagedCarsBindingSource.DataMember = "GetClientDamagedCars";
            this.getClientDamagedCarsBindingSource.DataSource = this.dBDataSet;
            // 
            // getClientDamagedCarsTableAdapter
            // 
            this.getClientDamagedCarsTableAdapter.ClearBeforeFill = true;
            // 
            // ClientDetailScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientInformation);
            this.Name = "ClientDetailScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о клиенте";
            this.Load += new System.EventHandler(this.ClientDetailScreen_Load);
            this.groupBoxClientApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getClientApplicationForAgentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientApplicationForAgentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.ClientInformation.ResumeLayout(false);
            this.ClientInformation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getClientDamagedCarsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDamagedCarsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClientApplications;
        private System.Windows.Forms.GroupBox ClientInformation;
        private System.Windows.Forms.Label labelSeriesPassport;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFathername;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelNumberPassport;
        private System.Windows.Forms.Label labelDriverCode;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelRegistrationDate;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource getClientApplicationForAgentBindingSource;
        private DBDataSetTableAdapters.GetClientApplicationForAgentTableAdapter getClientApplicationForAgentTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView getClientApplicationForAgentDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource getClientDamagedCarsBindingSource;
        private DBDataSetTableAdapters.GetClientDamagedCarsTableAdapter getClientDamagedCarsTableAdapter;
        private System.Windows.Forms.DataGridView getClientDamagedCarsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}