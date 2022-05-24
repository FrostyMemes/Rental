using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_car
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        public static ClientCard clientCard;
        public static AgentCard agentCard;
        public static ApplicationData applicationData;

        public static EnterScreen mainScreen;
        public static ClientScreen clientScreen;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainScreen = new EnterScreen());
        }
    }
}
