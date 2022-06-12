using System;
using System.Windows;
using System.Data.SqlClient;

namespace Online_Food_Ordering
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        String connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toshiba c55t-a\source\repos\Online Food Ordering\Online Food Ordering\onlinefood.mdf;Integrated Security=True";
            
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            String query = "SELECT * FROM signUp WHERE email=@email AND password=@password";

            SqlCommand comd = new SqlCommand(query,connection);
            comd.Parameters.AddWithValue("email", login_email_tb.Text);
            comd.Parameters.AddWithValue("password", login_password_tb.Password.ToString());

            SqlDataReader dataReader = comd.ExecuteReader();
            bool check = false;
            while (dataReader.Read())
            {

                if (dataReader[0].ToString() == login_email_tb.Text && dataReader[3].ToString() == login_password_tb.Password.ToString()) {
                    MainWindow w = new MainWindow();
                    w.Show();
                    this.Hide();
                    check = true;
                }

            }

            connection.Close();
            if (!check) {
                message.Content = "*Invalid Login";
            }

        }

        private void Login_password_tb_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
