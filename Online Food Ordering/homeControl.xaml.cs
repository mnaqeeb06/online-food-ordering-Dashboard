using System;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Linq;

namespace Online_Food_Ordering
{
    /// <summary>
    /// Interaction logic for homeControl.xaml
    /// </summary>
    public partial class homeControl : UserControl
    {
       


        string connectionString;
        SqlConnection connection;
        String query;
        SqlCommand comd;
        
        public homeControl()
        {
            InitializeComponent();
            getOrderDetails();


            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba c55t-a\source\repos\Online Food Ordering\Online Food Ordering\onlinefood.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            query = "SELECT * FROM Trending_item WHERE Id=@id";

            comd = new SqlCommand(query, connection);
            comd.Parameters.AddWithValue("Id", 1);
            
            SqlDataReader dataReader = comd.ExecuteReader();

            while (dataReader.Read())
            {
                vender1_label.Content = dataReader[1];
                vender1_review.Content = dataReader[2];
                vender1_interest.Content = dataReader[3];
                vender1_order.Content = dataReader[4];
            }
            connection.Close();


            // vendor 2 in list
            query = "SELECT * FROM Trending_item WHERE Id=@id";
            connection.Open();
            comd = new SqlCommand(query, connection);
            comd.Parameters.AddWithValue("Id", 2);

            SqlDataReader dataReader2 = comd.ExecuteReader();

            while (dataReader2.Read())
            {
                vender2_label.Content = dataReader2[1];
                vender2_review.Content = dataReader2[2];
                vender2_interest.Content = dataReader2[3];
                vender2_order.Content = dataReader2[4];

            }
            connection.Close();

            //vender 3
            // vendor 2 in list
            query = "SELECT * FROM Trending_item WHERE Id=@id";
            connection.Open();
            comd = new SqlCommand(query, connection);
            comd.Parameters.AddWithValue("Id", 3);

            SqlDataReader dataReader3 = comd.ExecuteReader();

            while (dataReader3.Read())
            {
                vender3_label.Content = dataReader3[1];
                vender3_review.Content = dataReader3[2];
                vender3_interest.Content = dataReader3[3];
                vender3_order.Content = dataReader3[4];

            }
            connection.Close();

          

        }

        public void getOrderDetails() {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba c55t-a\source\repos\Online Food Ordering\Online Food Ordering\onlinefood.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString); 
            OrderClassesDataContext orderDC = new OrderClassesDataContext(connection);
           
            

            var newOrders = (from i in orderDC.GetTable<orderlistTable>() select i).Count();

            tb_totalOrder.Content = newOrders + " +";

            // var newOrders = (from i in orderDC.GetTable<orderlistTable>() where Status= select i).Count();
           // var delivererd = (from i in orderDC.GetTable<orderlistTable>() where i.Status.Contains("Delivered") select i).Count();
           // delivered_label.Content = delivererd;

            // calculate total amount of delivered orders 
            var total_amount = (from i in orderDC.GetTable<orderlistTable>() where i.Status.Contains("Delivered") select i.Amount).Sum();
            tb_amount.Content = total_amount +" $";

            //  var cancel = orderDC.GetTable<orderlistTable>().Where(s => s.Status.Contains("cancelled")).Count();
            //  cancelled_label.Content = cancel;

            connection.Close();


        }
    }
}
