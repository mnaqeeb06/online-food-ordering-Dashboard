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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Online_Food_Ordering
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable dt;
        public Signup()
        {
            InitializeComponent();
             connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba c55t-a\source\repos\Online Food Ordering\Online Food Ordering\onlinefood.mdf;Integrated Security=True";
            adapter = new SqlDataAdapter();
            dt = new DataTable();
        }

   

        private void signup_click(object sender, RoutedEventArgs e)
        {
            // if password does not match with conform password
            if (signUP_password_tb.Password.ToString() != signUP_conformPassword_tb.Password.ToString()) {
                message.Content = "Password Does not match";
                return;
            }
            // if their is any empty field
            if (signUP_password_tb.Password.ToString()=="" || signUP_Email_tb.Text=="")
            {
                message.Content = "Complete All the Fields";
                return;
            }
            //if email does not contain @
            if (!signUP_Email_tb.Text.Contains("@")) {
                message.Content = "Enter Valid Email";
                return;
            }


            SqlConnection connection = new SqlConnection(connectionString);
            

            string query = "INSERT INTO signUp VALUES(@email,@Name,@phone,@password)";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("email", signUP_Email_tb.Text);
            command.Parameters.AddWithValue("Name", signUP_Name_tb.Text);
            command.Parameters.AddWithValue("phone", signUP_phone_tb.Text);
            command.Parameters.AddWithValue("password", signUP_password_tb.Password.ToString());
            connection.Open();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.Update(dt);
            connection.Close();
            

            Login l = new Login();
            l.Show();
            this.Hide();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // login button click
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // already have an account button
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
