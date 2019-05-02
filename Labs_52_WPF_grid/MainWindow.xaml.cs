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

namespace Labs_52_WPF_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customers;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, RoutedEventArgs e) 
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();

                foreach(var customer in customers)
                {

                    ListBox01.Items.Add(customer.ContactName); //To add customers to the click button

                }

                ListBox02.ItemsSource = db.Customers.ToList(); //Display whole object

            }
        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
