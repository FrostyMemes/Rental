
namespace Rental_car
{
    partial class EnterScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLinkChangeRole = new System.Windows.Forms.LinkLabel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.labelLingRegistration = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            // 
            // labelLinkChangeRole
            // 
            this.labelLinkChangeRole.AutoSize = true;
            this.labelLinkChangeRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelLinkChangeRole.Location = new System.Drawing.Point(0, 343);
            this.labelLinkChangeRole.Name = "labelLinkChangeRole";
            this.labelLinkChangeRole.Size = new System.Drawing.Size(190, 13);
            this.labelLinkChangeRole.TabIndex = 12;
            this.labelLinkChangeRole.TabStop = true;
            this.labelLinkChangeRole.Text = "Вы представитель фирмы проката?";
            this.labelLinkChangeRole.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLinkChangeRole_LinkClicked);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(49, 203);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(167, 27);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labelLingRegistration
            // 
            this.labelLingRegistration.AutoSize = true;
            this.labelLingRegistration.Location = new System.Drawing.Point(46, 233);
            this.labelLingRegistration.Name = "labelLingRegistration";
            this.labelLingRegistration.Size = new System.Drawing.Size(113, 13);
            this.labelLingRegistration.TabIndex = 10;
            this.labelLingRegistration.TabStop = true;
            this.labelLingRegistration.Text = "Зарегистрироваться";
            this.labelLingRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLingRegistration_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "15462754";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "example@yandex.ru";
            // 
            // EnterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLinkChangeRole);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.labelLingRegistration);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Name = "EnterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прокат автомобиля";
            this.Load += new System.EventHandler(this.EnterScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel labelLinkChangeRole;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.LinkLabel labelLingRegistration;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
    }
}