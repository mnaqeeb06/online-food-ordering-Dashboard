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
            if (female_rb.IsChecked==true) {
                GENDER = "F";

            } else {
                GENDER = "M";
            }


            try {
                int.Parse(id_tb.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid 'Id'!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (int.Parse(id_tb.Text) == 0) {
                MessageBox.Show("'Id' cannot be zero!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (name_tb.Text.Equals(null))
            {
                MessageBox.Show("Name cannot be left empty", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            try
            {
                int.Parse(age_tb.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid 'Age'!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (int.Parse(age_tb.Text)==0) {
                MessageBox.Show("Age Cannot be zero!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }



            if (GENDER.Equals(null))
            {
                MessageBox.Show("Please Select Gender", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            command.Parameters.AddWithValue("idd", id_tb.Text);
            command.Parameters.AddWithValue("name", name_tb.Text);
            command.Parameters.AddWithValue("age", age_tb.Text);
            command.Parameters.AddWithValue("gender", GENDER);
            command.Parameters.AddWithValue("cnic", cnic_tb.Text);
            command.Parameters.AddWithValue("phone", phone_tb.Text);


            try
            {

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                adapter.Update(dt);

                connection.Close();

                displayData();
            }
            catch
            {

                MessageBox.Show("Id cannot be dublicated", "Duplication", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
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

            //Validation
            try
            {
                int.Parse(id_tb.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid 'Id'!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (int.Parse(id_tb.Text) == 0)
            {
                MessageBox.Show("'Id' cannot be zero!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (name_tb.Text.Equals(null))
            {
                MessageBox.Show("Name cannot be left empty", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            try
            {
                int.Parse(age_tb.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid 'Age'!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (int.Parse(age_tb.Text) == 0)
            {
                MessageBox.Show("Age Cannot be zero!", "Incorrect Input", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

           

                connection = new SqlConnection(connectionString);
            connection.Open();
            String newName = name_tb.Text;
            int newAge = int.Parse(age_tb.Text);
            String newCNIC = cnic_tb.Text;
            String newPhone = phone_tb.Text;

            int idd = int.Parse(id_tb.Text);

           
                string query = $"UPDATE workers_table SET Name={newName} Age={newAge},CNIC={newCNIC},PhoneNumber={newPhone} WHERE id={idd}";

                adapter.InsertCommand = new SqlCommand(query, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                connection.Close();

                displayData();
            
            
        }
    }
}
