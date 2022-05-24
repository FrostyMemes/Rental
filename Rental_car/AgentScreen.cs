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
        public AgentScreen()
        {
            InitializeComponent();
        }

        private void AgentScreen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.waiting_applications". При необходимости она может быть перемещена или удалена.
            this.waiting_applicationsTableAdapter.Fill(this.dBDataSet.waiting_applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.waiting_applications". При необходимости она может быть перемещена или удалена.
            this.waiting_applicationsTableAdapter.Fill(this.dBDataSet.waiting_applications);

        }

        private void tabPageWaitingApplications_Click(object sender, EventArgs e)
        {

        }
    }
}
