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
using System.Windows.Threading;

namespace Snakes_and_ladders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter;
        int counter2;
        public MainWindow()
        {
            InitializeComponent();

            Initialize();
        }

        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            dateTime.Text = DateTime.Now.ToString();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Please don't quit!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)

            {
                Application.Current.Shutdown();
            }

        }

        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);
            switch (dice)
            {
                case 1:
                    DiceImage.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Alea_1.png"));
                    break;
                case 2:
                    DiceImage.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Alea_2.png"));
                    break;
                case 3:
                    DiceImage.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Alea_3.png"));
                    break;
                case 4:
                    DiceImage.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Alea_4.png"));
                    break;
                case 5:
                    DiceImage.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Alea_5.png"));
                    break;
                case 6:
                    DiceImage.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Alea_6.png"));
                    break;
            }
            int oldCounter = counter;
            counter += dice;

            if (counter > 36)
            {
                counter = 36 + (36 - counter);
            }
           
            //ladders
            if (counter == 2)
            {
                counter = 15;
                   // p15.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
                   // p1.Source = null;
            }
            if (counter == 5)
            {
                counter = 7;
            }
            if (counter == 9)
            {
                counter = 27;
            }
            if (counter == 18)
            {
                counter = 29;
            }
            if (counter == 25)
            {
                counter = 35;
            }
            //snakes
            if (counter == 17)
            {
                counter = 2;
            }
            if (counter == 20)
            {
                counter = 6;
            }
            if (counter == 32)
            {
                counter = 30;
            }
            if (counter == 24)
            {
                counter = 16;
            }
            if (counter == 34)
            {
                counter = 12;
            }

            //Statustext.Text = $"You have rolled {dice}";
            Statustext.Text = $"Player 1 is in position {counter}";
            //Statustext.Text = $"Player 1 is in position {counter2}";

            // TODO counter = 36

            // TODO counter > 36

            // TODO player ends up at ladder or snake

            RemoveCounter(oldCounter);
            AddCounter(counter);

            if (counter == 36)
            {
                MessageBox.Show("Player 1 wins!", "Try again!");
            }
        }

        private void RemoveCounter(int oldCounter)
        {
            if(oldCounter == 1)
            {
                p1.Source = null;
            }
            if (oldCounter == 2)
            {
                p2.Source = null;
            }
            if (oldCounter == 3)
            {
                p3.Source = null;
            }
            if (oldCounter == 4)
            {
                p4.Source = null;
            }
            if (oldCounter == 5)
            {
                p5.Source = null;
            }
            if (oldCounter == 6)
            {
                p6.Source = null;
            }
            if (oldCounter == 7)
            {
                p7.Source = null;
            }
            if (oldCounter == 8)
            {
                p8.Source = null;
            }
            if (oldCounter == 9)
            {
                p9.Source = null;
            }
            if (oldCounter == 10)
            {
                p10.Source = null;
            }
            if (oldCounter == 11)
            {
                p11.Source = null;
            }
            if (oldCounter == 12)
            {
                p12.Source = null;
            }
            if (oldCounter == 13)
            {
                p13.Source = null;
            }
            if (oldCounter == 14)
            {
                p14.Source = null;
            }
            if (oldCounter == 15)
            {
                p15.Source = null;
            }
            if (oldCounter == 16)
            {
                p16.Source = null;
            }
            if (oldCounter == 17)
            {
                p17.Source = null;
            }
            if (oldCounter == 18)
            {
                p18.Source = null;
            }
            if (oldCounter == 19)
            {
                p19.Source = null;
            }
            if (oldCounter == 20)
            {
                p20.Source = null;
            }
            if (oldCounter == 21)
            {
                p21.Source = null;
            }
            if (oldCounter == 22)
            {
                p22.Source = null;
            }
            if (oldCounter == 23)
            {
                p23.Source = null;
            }
            if (oldCounter == 24)
            {
                p24.Source = null;
            }
            if (oldCounter == 25)
            {
                p25.Source = null;
            }
            if (oldCounter == 26)
            {
                p26.Source = null;
            }
            if (oldCounter == 27)
            {
                p27.Source = null;
            }
            if (oldCounter == 28)
            {
                p28.Source = null;
            }
            if (oldCounter == 29)
            {
                p29.Source = null;
            }
            if (oldCounter == 30)
            {
                p30.Source = null;
            }
            if (oldCounter == 31)
            {
                p31.Source = null;
            }
            if (oldCounter == 32)
            {
                p32.Source = null;
            }
            if (oldCounter == 33)
            {
                p33.Source = null;
            }
            if (oldCounter == 34)
            {
                p34.Source = null;
            }
            if (oldCounter == 35)
            {
                p35.Source = null;
            }
            if (oldCounter == 36)
            {
                p36.Source = null;
            }
        }

        private void AddCounter(int c)
        {
            if(c == 1)
            {
                p1.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if(c == 2)
            {
                p2.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if(c == 3)
            {
                p3.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if(c == 4)
            {
                p4.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if(c == 5)
            {
                p5.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if(c == 6)
            {
                p6.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 7)
            {
                p7.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 8)
            {
                p8.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 9)
            {
                p9.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if(c == 10)
            {
                p10.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 11)
            {
                p11.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 12)
            {
                p12.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 13)
            {
                p13.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 14)
            {
                p14.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 15)
            {
                p15.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 16)
            {
                p16.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 17)
            {
                p17.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 18)
            {
                p18.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 19)
            {
                p19.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 20)
            {
                p20.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 21)
            {
                p21.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 22)
            {
                p22.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 23)
            {
                p23.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 24)
            {
                p24.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 25)
            {
                p25.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 26)
            {
                p26.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 27)
            {
                p27.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 28)
            {
                p28.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 29)
            {
                p29.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 30)
            {
                p30.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 31)
            {
                p31.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 32)
            {
                p32.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 33)
            {
                p33.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 34)
            {
                p34.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 35)
            {
                p35.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            if (c == 36)
            {
                p36.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
            }
            
        }

        private void Initialize() 
        {
            Title.Content = "SNAKES AND LADDERS";
            Title.FontSize = 50;
            DiceImage.Source = null;
            startclock();
            counter = 1;
            counter2 = 2;
            Statustext.Text = $"Roll the dice and test your luck! Good luck!";

            p1.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_golf-ball-clipart_318603.png"));
        }

        private void restart_button(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 36; i++)
            {
                RemoveCounter(i);
            }
            //InitializeComponent();
            Initialize();
        }

    }

}
