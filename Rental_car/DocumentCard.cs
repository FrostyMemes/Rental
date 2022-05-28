using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Rental_car
{
    class DocumentCard
    {
        
        public CarCard carCard;
        public ClientCard clientCard;
        public ApplicationCard applicationCard;

        public string idDocument;
        public bool documentExsiting;
        public string idApplication;

        public string Document_date;
        public string Date_inspection_before;
        public string Date_inspection_after;
        public string Description_damage_before;
        public string Description_damage_after;
        
        public string FacticalRentalEnd;
        public double Tax;
        public int DaysLate;
        public int DayPrice;

        public DocumentCard(string idApplication, string Email, string carRegNumber)
        {
            try
            {
                this.idApplication = idApplication;
                documentExsiting = DBConnection.GetResultQueryString($"SELECT car_rental.CheckDocumentExsisting({idApplication});") == "1";
                clientCard = new ClientCard(DBConnection.GetResultQueryDataTable($"Select * from client where Email ='{Email}';"));
                carCard = new CarCard(DBConnection.GetResultQueryDataTable($"Select * from car where Registration_number ='{carRegNumber}';"));
                applicationCard = new ApplicationCard(DBConnection.GetResultQueryDataTable($"Select * from application where Application_code = '{idApplication}'"));
                
                if (documentExsiting)
                    GetDocumentInformation();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetDocumentInformation()
        {
            DataTable documentInformation = DBConnection.GetResultQueryDataTable($"call car_rental.GetDocumentInfo({idApplication});");
            idDocument = documentInformation.Rows[0][0].ToString();
            Document_date = documentInformation.Rows[0][2].ToString();
            Date_inspection_before = documentInformation.Rows[0][4].ToString();
            Date_inspection_after = documentInformation.Rows[0][5].ToString();
            Description_damage_before = documentInformation.Rows[0][6].ToString();
            Description_damage_after = documentInformation.Rows[0][7].ToString();
            FacticalRentalEnd = documentInformation.Rows[0][8].ToString();
            DaysLate = int.Parse(documentInformation.Rows[0][9].ToString());
            
            if (DaysLate != 0)
                Tax = DaysLate * (1.1 * applicationCard.PriceAtDay);
        }

    }
}
