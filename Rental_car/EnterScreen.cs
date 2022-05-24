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
    public partial class EnterScreen : Form
    {
        bool role = true;
        string nameUserTable = "client";
        public EnterScreen()
        {
            InitializeComponent();
        }

        private void EnterScreen_Load(object sender, EventArgs e)
        {
            DBConnection.Connect();
        }

        private void labelLingRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationScreen = new RegistrationScreen();
            registrationScreen.Show();
            this.Hide();
        }

        private void labelLinkChangeRole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            role = !role;
            if (!role)
            {
                labelLinkChangeRole.Text = "Вы клиент?";
                nameUserTable = "agent";
            }
            else
            {
                labelLinkChangeRole.Text = "Вы представитель фирмы проката?";
                nameUserTable = "client";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var personData = DBConnection.GetResultQueryDataTable($@"Select * from {nameUserTable} where Email = '{txtEmail.Text}' and Password ='{txtPassword.Text}';");
            if (personData.Rows.Count != 0)
            {
                if (role)
                {
                    Program.clientCard = new ClientCard(personData);
                    Program.clientScreen = new ClientScreen();
                    Program.clientScreen.Show();
                }
                else
                {
                    Program.agentCard = new AgentCard(personData);
                    Program.agentScreen = new AgentScreen();
                    Program.agentScreen.Show();                 
                }
                this.Hide();
            }
            else
                MessageBox.Show("Пользователь не найден.\nПроверьте данные и повторите попытку.");
        }
    }
}
