using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheUCFour.DatabaseContext.DatabaseContext;
using TheUCFour.Model.Model;
using TheUCFour.ViewModel.ViewModel;

namespace TheUCFour.Repository.Repository
{
    public class PurchaseReportRepository
    {
        string connectionString = @"Server = HABIB; Database = TheUCFour;
                Integrated Security = true";


        public List<PurchaseView1> LoadProducts()
        {
            List<PurchaseView1> purchaseView1s = new List<PurchaseView1>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM PurchaseView1";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                PurchaseView1 purchaseView1 = new PurchaseView1();
                purchaseView1.Product = sqlDataReader["Product"].ToString();
                purchaseView1.Date = sqlDataReader["Date"].ToString();
                purchaseView1.AvailableQuantity = Convert.ToDouble(sqlDataReader["AvailableQuantity"].ToString());
                purchaseView1.UnitPrice = Convert.ToDouble(sqlDataReader["UnitPrice"].ToString());
                purchaseView1.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                purchaseView1.Profit = Convert.ToDouble(sqlDataReader["Profit"].ToString());

                purchaseView1s.Add(purchaseView1);
            }
            sqlConnection.Close();

            return purchaseView1s;
        }
    }
}
