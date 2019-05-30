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

namespace Labs_Homework_104_WPF_NorthWindEntityProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customers = new List<Customer>();
        static List<Employee> employees = new List<Employee>();
        static List<Product> product = new List<Product>();
        static List<Supplier> supplier = new List<Supplier>();
        static List<Order> order = new List<Order>();
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {



        }

        private void EmployeeButton(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities1())
            {
                employees = db.Employees.ToList();
                EmployeesList.DisplayMemberPath = "FirstName";
                EmployeesList.ItemsSource = employees;
            }
        }

        private void CustomersButton(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities1())
            {
                customers = db.Customers.ToList();
                CustomersList.DisplayMemberPath = "ContactName";
                CustomersList.ItemsSource = customers;
            }
        }

        private void SuppliersButton(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities1())
            {
                supplier = db.Suppliers.ToList();
                SuppliersList.DisplayMemberPath = "CompanyName";
                SuppliersList.ItemsSource = supplier;
            }
        }

        private void ProductsButton(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities1())
            {
                product = db.Products.ToList();
                ProductsList.DisplayMemberPath = "ProductName";
                ProductsList.ItemsSource = product;
            }
        }

        private void OrdersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new NorthwindEntities1())
            {
               
            }
            
        }
    }
}
