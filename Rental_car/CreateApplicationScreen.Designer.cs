
namespace Rental_car
{
    partial class CreateApplicationScreen
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
            this.dateTimePickerStartRental = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndRental = new System.Windows.Forms.DateTimePicker();
            this.btnCreateApplication = new System.Windows.Forms.Button();
            this.comboBoxChildeSeat = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRentalDays = new System.Windows.Forms.Label();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerStartRental
            // 
            this.dateTimePickerStartRental.Location = new System.Drawing.Point(148, 24);
            this.dateTimePickerStartRental.Name = "dateTimePickerStartRental";
            this.dateTimePickerStartRental.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartRental.TabIndex = 0;
            this.dateTimePickerStartRental.ValueChanged += new System.EventHandler(this.dateTimePickerStartRental_ValueChanged);
            // 
            // dateTimePickerEndRental
            // 
            this.dateTimePickerEndRental.Location = new System.Drawing.Point(148, 63);
            this.dateTimePickerEndRental.Name = "dateTimePickerEndRental";
            this.dateTimePickerEndRental.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndRental.TabIndex = 1;
            this.dateTimePickerEndRental.ValueChanged += new System.EventHandler(this.dateTimePickerEndRental_ValueChanged);
            // 
            // btnCreateApplication
            // 
            this.btnCreateApplication.Location = new System.Drawing.Point(51, 218);
            this.btnCreateApplication.Name = "btnCreateApplication";
            this.btnCreateApplication.Size = new System.Drawing.Size(283, 30);
            this.btnCreateApplication.TabIndex = 3;
            this.btnCreateApplication.Text = "Подать заявку на прокат";
            this.btnCreateApplication.UseVisualStyleBackColor = true;
            this.btnCreateApplication.Click += new System.EventHandler(this.btnCreateApplication_Click);
            // 
            // comboBoxChildeSeat
            // 
            this.comboBoxChildeSeat.FormattingEnabled = true;
            this.comboBoxChildeSeat.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.comboBoxChildeSeat.Location = new System.Drawing.Point(148, 101);
            this.comboBoxChildeSeat.Name = "comboBoxChildeSeat";
            this.comboBoxChildeSeat.Size = new System.Drawing.Size(200, 21);
            this.comboBoxChildeSeat.TabIndex = 4;
            this.comboBoxChildeSeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxChildeSeat_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(48, 154);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(94, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Итоговая сумма:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Детское кресло";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата начала проката";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата окончания проката";
            // 
            // labelRentalDays
            // 
            this.labelRentalDays.AutoSize = true;
            this.labelRentalDays.Location = new System.Drawing.Point(61, 135);
            this.labelRentalDays.Name = "labelRentalDays";
            this.labelRentalDays.Size = new System.Drawing.Size(81, 13);
            this.labelRentalDays.TabIndex = 9;
            this.labelRentalDays.Text = "Дней проката:";
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Location = new System.Drawing.Point(51, 182);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(283, 30);
            this.btnCheckAvailability.TabIndex = 10;
            this.btnCheckAvailability.Text = "Проверить доступность";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // CreateApplicationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 253);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.labelRentalDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxChildeSeat);
            this.Controls.Add(this.btnCreateApplication);
            this.Controls.Add(this.dateTimePickerEndRental);
            this.Controls.Add(this.dateTimePickerStartRental);
            this.Name = "CreateApplicationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подать заявку";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateApplicationScreen_FormClosing);
            this.Load += new System.EventHandler(this.CreateApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStartRental;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndRental;
        private System.Windows.Forms.Button btnCreateApplication;
        private System.Windows.Forms.ComboBox comboBoxChildeSeat;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRentalDays;
        private System.Windows.Forms.Button btnCheckAvailability;
    }
}