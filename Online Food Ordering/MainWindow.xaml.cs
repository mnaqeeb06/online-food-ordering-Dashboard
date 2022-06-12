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

namespace Online_Food_Ordering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Control homeuserControls = new homeControl();
        Control vendorsUserContron = new Vendors();
        Control workerControls = new WorkersControl();
        Control orderListControl = new orderListControl();

        DateTime today = DateTime.Today;
        

        public MainWindow()
        {
            InitializeComponent();
            mainCnvas.Children.Add(homeuserControls);
            date_label.Content = today;
        }

        private void Workers_Button_Click(object sender, RoutedEventArgs e)
        {
            mainCnvas.Children.Clear();
            this.mainCnvas.Children.Add(this.workerControls);

        }

        private void Order_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void OrderList_Button_Click(object sender, RoutedEventArgs e)
        {
            mainCnvas.Children.Clear();
            this.mainCnvas.Children.Add(this.orderListControl);

        }

        private void Vendors_Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            mainCnvas.Children.Clear();
            this.mainCnvas.Children.Add(this.vendorsUserContron);

        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            Control homeuserControls = new homeControl();
            mainCnvas.Children.Clear();
            mainCnvas.Children.Add(homeuserControls);
            
        }

        private void logout_Button_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void webSearck_Button_Click(object sender, RoutedEventArgs e)
        {
            webbrowser.Navigate("http://bigbite.somee.com");
        }
    }
}
