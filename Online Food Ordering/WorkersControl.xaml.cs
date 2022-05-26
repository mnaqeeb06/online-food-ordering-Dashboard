using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;

namespace Online_Food_Ordering
{
    /// <summary>
    /// Interaction logic for WorkersControl.xaml
    /// </summary>
    public partial class WorkersControl : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba c55t-a\source\repos\Online Food Ordering\Online Food Ordering\onlinefood.mdf;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlConnection connection;
        SqlCommand command;



        public WorkersControl()
        {
            InitializeComponent();
            //-------Displaying data
            displayData();
            
            
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO workers_table VALUES(@idd,@name,@age,@gender,@cnic,@phone)";
            command = new SqlCommand(query, connection);

            string GENDER;
            if (male_rb.IsChecked==true) {
                GENDER = "M";

            } else {
                GENDER = "F";
            }

            command.Parameters.AddWithValue("idd", id_tb.Text);
            command.Parameters.AddWithValue("name", name_tb.Text);
            command.Parameters.AddWithValue("age", age_tb.Text);
            command.Parameters.AddWithValue("gender", GENDER);
            command.Parameters.AddWithValue("cnic", cnic_tb.Text);
            command.Parameters.AddWithValue("phone", phone_tb.Text);


            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.Update(dt);

            connection.Close();

            displayData();

        }

        private void displayData() {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM workers_table";
            command = new SqlCommand(query, connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            adapter.Fill(dt);

            //datagridView.ItemsSource = dt;
            // almost same work
            datagridView.ItemsSource = command.ExecuteReader();

            id_tb.Clear();
            name_tb.Clear();
            age_tb.Clear();
            cnic_tb.Clear();
            phone_tb.Clear();


        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            
            connection = new SqlConnection(connectionString);
            connection.Open();
            int idd = int.Parse(id_tb.Text);
            string query = $"DELETE FROM workers_table WHERE id={idd}";
            command = new SqlCommand(query,connection);
            

            adapter.DeleteCommand = new SqlCommand(query, connection);
            adapter.DeleteCommand.ExecuteNonQuery();
            connection.Close();

            displayData();
            
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            String newName = name_tb.Text;
            int newAge = int.Parse(age_tb.Text);
            String newCNIC = cnic_tb.Text;
            String newPhone = phone_tb.Text;

            int idd = int.Parse(id_tb.Text);


            string query = $"UPDATE workers_table SET Age={newAge},CNIC={newCNIC},PhoneNumber={newPhone} WHERE id={idd}";

            adapter.InsertCommand = new SqlCommand(query,connection);
            adapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

            displayData();
        }
    }
}
