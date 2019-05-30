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
using Rabbit_explosion_game;

namespace Rabbit_Explosion_game_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int time;

        public MainWindow()
        {
            time = 0;
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /*private void LETSBREED(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear

            var result = Program.RabbitCounter(time);
            for (int i = 0; i < result.Count; i++)
            {
                ListBox1.Items.Add($"There are {result[i]} rabbits after {i} seconds");
            }
            time++;
        }*/
    }
}
