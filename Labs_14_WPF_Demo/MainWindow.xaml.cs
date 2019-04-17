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

namespace Labs_14_WPF_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();

        }

        void Initialize()
        {

            Button01.FontSize = 20;
            Button01.Content = "If Carmen is stupid, Click Here";
        }

        int counter = 0;
        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            Label01.Content = $"Hey you clicked {counter} times";
            ListBox01.Items.Add($"Hey ou clicked{counter} times");
            Label01.FontSize++;

        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            counter = 0;
            Label01.Content = null;
            ListBox01.Items.Clear();
        }
    }
}

