using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Online_Food_Ordering
{
    /// <summary>
    /// Interaction logic for Vendors.xaml
    /// </summary>
    public partial class Vendors : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba c55t-a\source\repos\Online Food Ordering\Online Food Ordering\onlinefood.mdf;Integrated Security=True";
        SqlConnection connection;
        OrderTrackDataClassesDataContext dc;

        public Vendors()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            dc = new OrderTrackDataClassesDataContext(connection);

            showData();
        }

        private void showData()
        {
            // Query syntax
            var result = from i in dc.GetTable<Trending_item>() select i;

            datagridView.ItemsSource = result;

        }

        int id;
        String name;
        int review;
        String interests;
        int total_order;

        private void getValues()
        {
            try
            {
                id = int.Parse(id_tb.Text);
            }
            catch
            {
                MessageBox.Show("'Id'Should Be a Valid Number!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            name = verdor_name_tb.Text;
            try
            {
            review = int.Parse(review_tb.Text);

            }
            catch
            {
                MessageBox.Show("'Review'Should Be a Valid Number!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            interests = Interest_tb.Text;
            try
            {

            total_order = int.Parse(order_tb.Text);
            }
            catch
            {
                MessageBox.Show("'Total Order' Should Be a Valid Number!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            Trending_item TI = new Trending_item();
            getValues();

            if (id == 0) {
                MessageBox.Show("'Id' cannot be zero!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            TI.Id = id;
            TI.Vendor_name = name;
            TI.Review = review;
            TI.interest = interests;
            TI.orders = total_order;

            try
            {
                TI = dc.Trending_items.First((s) => s.Id.Equals(id));

            }
            catch {
                dc.Trending_items.InsertOnSubmit(TI);
                dc.SubmitChanges();
                showData();
                return;
            }
            MessageBox.Show("'Id' cannot be repeated!", "Duplicate Id", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            int delete_id = int.Parse(id_tb.Text);
            // single is use to delete the value which match the certain condition

            // singleorDefault is use to delete the value which match the certain condition but if 
            // the condition does not match it will delete first value
            Trending_item item = dc.Trending_items.Single((i) => i.Id.Equals(delete_id));
            dc.Trending_items.DeleteOnSubmit(item);
            dc.SubmitChanges();

            showData();

        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            int update_id = int.Parse(id_tb.Text);
            Trending_item item = dc.Trending_items.First((s) => s.Id.Equals(update_id));
            item.Review = int.Parse(review_tb.Text);
            item.interest = Interest_tb.Text;
            item.orders = int.Parse(order_tb.Text);
            dc.SubmitChanges();
            showData();

        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {

            if (!searchBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("ID Should be a number", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string result;
            Trending_item item;

            try
            {
            int id = int.Parse(searchBox.Text);
            item = dc.Trending_items.First((s) => s.Id.Equals(id));     
            }
            catch
            {
             MessageBox.Show("This Id does not exixt!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
             return;
            }
            result = " Name Of Vendor: " + item.Vendor_name.ToString() + "\n Interest: " + item.interest.ToString() + "\n Total Order: " + item.orders.ToString();
            MessageBox.Show(result,"Details",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}
