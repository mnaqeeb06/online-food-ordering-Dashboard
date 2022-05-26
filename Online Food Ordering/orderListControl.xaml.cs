using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Online_Food_Ordering
{
    /// <summary>
    /// Interaction logic for orderListControl.xaml
    /// </summary>
    public partial class orderListControl : UserControl
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba c55t-a\source\repos\Online Food Ordering\Online Food Ordering\onlinefood.mdf;Integrated Security=True";
        SqlConnection connection;
      

        public orderListControl()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            displayData();
            calulation_Queries();
        }

        private void displayData() {
            OrderClassesDataContext orderDC = new OrderClassesDataContext();
            var result = from i in orderDC.GetTable<orderlistTable>() select i;
            gridView1.ItemsSource = result;

        }
        public void calulation_Queries() {
            OrderClassesDataContext orderDC = new OrderClassesDataContext();
            var newOrders = (from i in orderDC.GetTable<orderlistTable>() select i).Count();

            newOrder_Label.Content = newOrders;

            // var newOrders = (from i in orderDC.GetTable<orderlistTable>() where Status= select i).Count();
            var delivererd = (from i in orderDC.GetTable<orderlistTable>() where i.Status.Contains("Delivered") select i).Count();
            delivered_label.Content = delivererd;

            var total_amount = (from i in orderDC.GetTable<orderlistTable>() select i.Amount).Sum();
            amount_label.Content = total_amount;

            var cancel = orderDC.GetTable<orderlistTable>().Where(s=>s.Status.Contains("cancelled")).Count();
            cancelled_label.Content = cancel;
        }


    }


}
