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

namespace Labs_69_WPF_Entity_CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customers;
        static List<Employee> employees;
        static List<Product> products;
        static List<Supplier> supplier;
        static List<Order> orders;
        static List<Order_Detail> orderdetails;

        static Customer customer;
        static Customer customerToEdit;
        static Customer customerToDelete;
        static Customer customerToAdd;
        static Order order;
        static Order_Detail orderdetail;
        static Product product;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                ListBox01.ItemsSource = customers;
                ListBox01.DisplayMemberPath = "ContactName";
            }
        }
        private void ListCustomersButton_Click(object sender, RoutedEventArgs e)
        {
            ListBox01.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                ListBox01.ItemsSource = customers;
                ListBox01.DisplayMemberPath = "ContactName";
            }
        }

        private void ListProductsButton_Click(object sender, RoutedEventArgs e)
        {
            ListBox01.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                products = db.Products.ToList();
                ListBox01.ItemsSource = products;
                ListBox01.DisplayMemberPath = "ProductName";
            }
        }
        private void ListSupppliersButton_Click(object sender, RoutedEventArgs e)
        {
            ListBox01.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                supplier = db.Suppliers.ToList();
                ListBox01.ItemsSource = supplier;
                ListBox01.DisplayMemberPath = "CompanyName";
            }
        }
        private void ListEmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            ListBox01.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                employees = db.Employees.ToList();
                ListBox01.ItemsSource = employees;
                ListBox01.DisplayMemberPath = "LastName";
            }
        }
        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox01.SelectedItem == null)
                return;
            ListBox02.ItemsSource = null;
            ListBox03.ItemsSource = null;
            // Select one customer
            customer = (Customer)ListBox01.SelectedItem;

            using (var db = new NorthwindEntities())
            {
                //Select all orders => Initially put all orders into ListBox02

                //orders = db.Orders.ToList();
                //ListBox02.ItemsSource = orders;
                //ListBox02.DisplayMemberPath = "OrderID";

                //Then put orders where customerid=this customerid
                orders = db.Orders.Where(o => customer.CustomerID == o.CustomerID).ToList();
                ListBox02.ItemsSource = orders;
                ListBox02.DisplayMemberPath = "OrderID";
            }

            //This adds the details on the customers to the text box
            TextBox01.Text = customer.ContactName;
            TextBox02.Text = customer.CompanyName;
            TextBox03.Text = customer.City;
            TextBox01.IsReadOnly = true;
            TextBox02.IsReadOnly = true;
            TextBox03.IsReadOnly = true;
        }
        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox02.SelectedItem == null)
            {
                return;
            }
            ListBox03.ItemsSource = null;
            ListBox04.ItemsSource = null;
            order = ListBox02.SelectedItem as Order;

            using (var db = new NorthwindEntities())
            {
                orderdetails = db.Order_Details.Where(od => od.OrderID == order.OrderID).ToList();
                ListBox03.ItemsSource = orderdetails;
                ListBox03.DisplayMemberPath = "ProductID";
                products = new List<Product>();
                foreach (var item in orderdetails)
                {
                    product = null;
                    product = db.Products.Where(p => p.ProductID == item.ProductID).FirstOrDefault();
                    products.Add(product);
                }
                ListBox04.ItemsSource = null;
                ListBox04.DisplayMemberPath = "ProductName";
                ListBox04.ItemsSource = products;
            }
        }
        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ListBox04_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox05.ItemsSource = null;
            ListBox05.Items.Clear();
            product = ListBox04.SelectedItem as Product;
            //Manually add product ID,name,unit price, quantity in stack to listbox05
            if (product != null)
            {
                ListBox05.Items.Add(product.ProductID);
                ListBox05.Items.Add(product.ProductName);
                ListBox05.Items.Add(product.CategoryID);
                ListBox05.Items.Add(product.UnitPrice);
                ListBox05.Items.Add(product.UnitsInStock);
                ListBox05.Items.Add(product.UnitsOnOrder);
            }
        }
        private void ListBox05_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // This IF statement asks if the buttons text is = Add and if it is execute the code below... Changing the button to save, making the text boxes 
            //to false etc
            if (AddButton.Content.ToString() == "Add")
            {
                AddButton.Content = "Save";
                TextBoxID.IsReadOnly = false;
                TextBox01.IsReadOnly = false;
                TextBox02.IsReadOnly = false;
                TextBox03.IsReadOnly = false;
                TextBoxID.Text = "ID";
                TextBox01.Text = "Name";
                TextBox02.Text = "Company Name";
                TextBox03.Text = "City";
            }
            //The else statement is now asking if the button is = to save and if it is we will change it back to the add text and add a new customer to the database
            else if (AddButton.Content.ToString() == "Save")
            {
                AddButton.Content = "Add";
                using (var db = new NorthwindEntities())
                {
                    customerToAdd = new Customer()
                    {
                        CustomerID = TextBoxID.Text,
                        ContactName = TextBox01.Text,
                        CompanyName = TextBox02.Text,
                        City = TextBox03.Text,
                    };
                    db.Customers.Add(customerToAdd);
                    db.SaveChanges();
                    //refresh view
                    ListBox01.ItemsSource = null;
                    ListBox02.ItemsSource = null;
                    ListBox03.ItemsSource = null;
                    ListBox04.ItemsSource = null;
                    ListBox05.Items.Clear();
                    customers = db.Customers.ToList();
                    ListBox01.ItemsSource = customers;

                    TextBoxID.Text = null;
                    TextBox01.Text = null;
                    TextBox02.Text = null;
                    TextBox03.Text = null;
                }

            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (EditButton.Content.ToString() == "Edit")
            {
                TextBox01.IsReadOnly = false;
                TextBox02.IsReadOnly = false;
                TextBox03.IsReadOnly = false;
                EditButton.Content = "Save Changes";
                AddButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
            else if (EditButton.Content.ToString() == "Save Changes")
            {
                //update record
                using (var db = new NorthwindEntities())
                {
                    // check if we have a valid customer to edit
                    //check we have a valid customer to edit!
                    if (customer != null)
                    {
                        customerToEdit = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                        customerToEdit.ContactName = TextBox01.Text;
                        customerToEdit.CompanyName = TextBox02.Text;
                        customerToEdit.City = TextBox03.Text;
                        //Writes changes to DB
                        db.SaveChanges();
                    }

                    //refresh the screen
                    ListBox01.ItemsSource = null;
                    ListBox02.ItemsSource = null;
                    ListBox03.ItemsSource = null;
                    customers = db.Customers.ToList();
                    ListBox01.ItemsSource = customers;
                }
                EditButton.Content = "Edit";
                EditButton.IsEnabled = true;
                AddButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
                TextBox01.IsReadOnly = true;
                TextBox02.IsReadOnly = true;
                TextBox03.IsReadOnly = true;
            }
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (customer == null)
            {
                return;
            }
            //select customer from data
            using (var db = new NorthwindEntities())
            {
                customerToDelete = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                db.Customers.Remove(customerToDelete);
                db.SaveChanges();

                MessageBox.Show("Data has been deleted");

                TextBoxID.Text = null;
                TextBox01.Text = null;
                TextBox02.Text = null;
                TextBox03.Text = null;

                //refresh
                ListBox01.ItemsSource = null;
                ListBox02.ItemsSource = null;
                ListBox03.ItemsSource = null;
                ListBox04.ItemsSource = null;
                ListBox05.Items.Clear();
                customers = db.Customers.ToList();
                ListBox01.ItemsSource = customers;

            }




        }
    }
}
