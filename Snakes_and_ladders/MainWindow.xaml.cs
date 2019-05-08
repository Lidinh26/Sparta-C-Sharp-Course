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
using System.Media;

namespace Snakes_and_ladders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool Players;
        int counter;
        int counter2;

        BitmapImage imagePlayer1;
        BitmapImage imagePlayer2;
        BitmapImage imagePlayer12;


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
            Random r = new Random();
            int dice = r.Next(1, 7);
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

            #region Player 2 false


            if (Players == false)
            {
                testing.Text = "Player 1, it's your turn!";
                int oldCounter2 = counter2;
                counter2 += dice;

                if (counter2 > 36)
                {
                    counter2 = 36 + (36 - counter2);
                }

                //ladders
                if (counter2 == 2)
                {
                    counter2 = 15;
                }
                if (counter2 == 5)
                {
                    counter2 = 7;
                }
                if (counter2 == 9)
                {
                    counter2 = 27;
                }
                if (counter2 == 18)
                {
                    counter2 = 29;
                }
                if (counter2 == 25)
                {
                    counter2 = 35;
                }
                //snakes
                if (counter2 == 17)
                {
                    counter2 = 4;
                }
                if (counter2 == 20)
                {
                    counter2 = 6;
                }
                if (counter2 == 32)
                {
                    counter2 = 30;
                }
                if (counter2 == 24)
                {
                    counter2 = 16;
                }
                if (counter2 == 34)
                {
                    counter2 = 12;
                }

                //Statustext.Text = $"You have rolled {dice}";
                Statustext.Text = $"Player 2, you are on position {counter2}";

                RemoveCounter2(oldCounter2);
                RemoveCounter(counter);

                AddCounter(counter2);
                Players = !Players;
                AddCounter(counter);
                Players = !Players;

                if (counter2 == 36)
                {
                    MessageBox.Show("Well done Player 2, you won!", "Play again?");
                    for (int i = 0; i <= 36; i++)
                    {
                        RemoveCounter2(i);
                    }
                    Initialize();
                    Statustext.Text = null;

                }
            }
            #endregion

            #region Player 1 true

            else if (Players == true)
            {
                testing.Text = "Player 2, its your turn!";
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
                    counter = 4;
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
                Statustext.Text = $"Player 1, you are in position {counter}";
                //Statustext.Text = $"Player 1 is in position {counter2}";

                // TODO counter = 36

                // TODO counter > 36

                // TODO player ends up at ladder or snake

                RemoveCounter(oldCounter);
                RemoveCounter2(counter2);

                AddCounter(counter);
                Players = !Players;
                AddCounter(counter2);
                Players = !Players;

                if (counter == 36)
                {
                    MessageBox.Show("Well done Player 1, you won!", "Play again?");
                    for (int i = 0; i <= 36; i++)
                    {
                        RemoveCounter(i);
                    }
                    //InitializeComponent();
                    Initialize();
                    Statustext.Text = null;
                    Players = true;
                }
            }
            #endregion

            if (Players == true)
            {
                Players = false;
            }
            else Players = true;
        }
        private void RemoveCounter2(int oldCounter2)
        {
            if (oldCounter2 == 1)
            {
                p1.Source = null;
            }
            if (oldCounter2 == 2)
            {
                p2.Source = null;
            }
            if (oldCounter2 == 3)
            {
                p3.Source = null;
            }
            if (oldCounter2 == 4)
            {
                p4.Source = null;
            }
            if (oldCounter2 == 5)
            {
                p5.Source = null;
            }
            if (oldCounter2 == 6)
            {
                p6.Source = null;
            }
            if (oldCounter2 == 7)
            {
                p7.Source = null;
            }
            if (oldCounter2 == 8)
            {
                p8.Source = null;
            }
            if (oldCounter2 == 9)
            {
                p9.Source = null;
            }
            if (oldCounter2 == 10)
            {
                p10.Source = null;
            }
            if (oldCounter2 == 11)
            {
                p11.Source = null;
            }
            if (oldCounter2 == 12)
            {
                p12.Source = null;
            }
            if (oldCounter2 == 13)
            {
                p13.Source = null;
            }
            if (oldCounter2 == 14)
            {
                p14.Source = null;
            }
            if (oldCounter2 == 15)
            {
                p15.Source = null;
            }
            if (oldCounter2 == 16)
            {
                p16.Source = null;
            }
            if (oldCounter2 == 17)
            {
                p17.Source = null;
            }
            if (oldCounter2 == 18)
            {
                p18.Source = null;
            }
            if (oldCounter2 == 19)
            {
                p19.Source = null;
            }
            if (oldCounter2 == 20)
            {
                p20.Source = null;
            }
            if (oldCounter2 == 21)
            {
                p21.Source = null;
            }
            if (oldCounter2 == 22)
            {
                p22.Source = null;
            }
            if (oldCounter2 == 23)
            {
                p23.Source = null;
            }
            if (oldCounter2 == 24)
            {
                p24.Source = null;
            }
            if (oldCounter2 == 25)
            {
                p25.Source = null;
            }
            if (oldCounter2 == 26)
            {
                p26.Source = null;
            }
            if (oldCounter2 == 27)
            {
                p27.Source = null;
            }
            if (oldCounter2 == 28)
            {
                p28.Source = null;
            }
            if (oldCounter2 == 29)
            {
                p29.Source = null;
            }
            if (oldCounter2 == 30)
            {
                p30.Source = null;
            }
            if (oldCounter2 == 31)
            {
                p31.Source = null;
            }
            if (oldCounter2 == 32)
            {
                p32.Source = null;
            }
            if (oldCounter2 == 33)
            {
                p33.Source = null;
            }
            if (oldCounter2 == 34)
            {
                p34.Source = null;
            }
            if (oldCounter2 == 35)
            {
                p35.Source = null;
            }
            if (oldCounter2 == 36)
            {
                p36.Source = null;
            }

        }
        private void RemoveCounter(int oldCounter)
        {
            if (oldCounter == 1)
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
            if (Players == true)
            {
                if (c == 1)
                {
                    if (p1.Source == null) { p1.Source = imagePlayer1; } else p1.Source = imagePlayer12;
                }
                if (c == 2)
                {
                    if (p2.Source == null) { p2.Source = imagePlayer1; } else p2.Source = imagePlayer12;
                }
                if (c == 3)
                {
                    if (p3.Source == null) { p3.Source = imagePlayer1; } else p3.Source = imagePlayer12;
                }
                if (c == 4)
                {
                    if (p4.Source == null) { p4.Source = imagePlayer1; } else p4.Source = imagePlayer12;
                }
                if (c == 5)
                {
                    if (p5.Source == null) { p5.Source = imagePlayer1; } else p5.Source = imagePlayer12;
                }
                if (c == 6)
                {
                    if (p6.Source == null) { p6.Source = imagePlayer1; } else p6.Source = imagePlayer12;
                }
                if (c == 7)
                {
                    if (p7.Source == null) { p7.Source = imagePlayer1; } else p7.Source = imagePlayer12;
                }
                if (c == 8)
                {
                    if (p8.Source == null) { p8.Source = imagePlayer1; } else p8.Source = imagePlayer12;
                }
                if (c == 9)
                {
                    if (p9.Source == null) { p9.Source = imagePlayer1; } else p9.Source = imagePlayer12;
                }
                if (c == 10)
                {
                    if (p10.Source == null) { p10.Source = imagePlayer1; } else p10.Source = imagePlayer12;
                }
                if (c == 11)
                {
                    if (p11.Source == null) { p11.Source = imagePlayer1; } else p11.Source = imagePlayer12;
                }
                if (c == 12)
                {
                    if (p12.Source == null) { p12.Source = imagePlayer1; } else p12.Source = imagePlayer12;
                }
                if (c == 13)
                {
                    if (p13.Source == null) { p13.Source = imagePlayer1; } else p13.Source = imagePlayer12;
                }
                if (c == 14)
                {
                    if (p14.Source == null) { p14.Source = imagePlayer1; } else p14.Source = imagePlayer12;
                }
                if (c == 15)
                {
                    if (p15.Source == null) { p15.Source = imagePlayer1; } else p15.Source = imagePlayer12;
                }
                if (c == 16)
                {
                    if (p16.Source == null) { p16.Source = imagePlayer1; } else p16.Source = imagePlayer12;
                }
                if (c == 17)
                {
                    if (p17.Source == null) { p17.Source = imagePlayer1; } else p17.Source = imagePlayer12;
                }
                if (c == 18)
                {
                    if (p18.Source == null) { p18.Source = imagePlayer1; } else p18.Source = imagePlayer12;
                }
                if (c == 19)
                {
                    if (p19.Source == null) { p19.Source = imagePlayer1; } else p19.Source = imagePlayer12;
                }
                if (c == 20)
                {
                    if (p20.Source == null) { p20.Source = imagePlayer1; } else p20.Source = imagePlayer12;
                }
                if (c == 21)
                {
                    if (p21.Source == null) { p21.Source = imagePlayer1; } else p21.Source = imagePlayer12;
                }
                if (c == 22)
                {
                    if (p22.Source == null) { p22.Source = imagePlayer1; } else p22.Source = imagePlayer12;
                }
                if (c == 23)
                {
                    if (p23.Source == null) { p23.Source = imagePlayer1; } else p23.Source = imagePlayer12;
                }
                if (c == 24)
                {
                    if (p24.Source == null) { p24.Source = imagePlayer1; } else p24.Source = imagePlayer12;
                }
                if (c == 25)
                {
                    if (p25.Source == null) { p25.Source = imagePlayer1; } else p25.Source = imagePlayer12;
                }
                if (c == 26)
                {
                    if (p26.Source == null) { p26.Source = imagePlayer1; } else p26.Source = imagePlayer12;
                }
                if (c == 27)
                {
                    if (p27.Source == null) { p27.Source = imagePlayer1; } else p27.Source = imagePlayer12;
                }
                if (c == 28)
                {
                    if (p28.Source == null) { p28.Source = imagePlayer1; } else p28.Source = imagePlayer12;
                }
                if (c == 29)
                {
                    if (p29.Source == null) { p29.Source = imagePlayer1; } else p29.Source = imagePlayer12;
                }
                if (c == 30)
                {
                    if (p30.Source == null) { p30.Source = imagePlayer1; } else p30.Source = imagePlayer12;
                }
                if (c == 31)
                {
                    if (p31.Source == null) { p31.Source = imagePlayer1; } else p31.Source = imagePlayer12;
                }
                if (c == 32)
                {
                    if (p32.Source == null) { p32.Source = imagePlayer1; } else p32.Source = imagePlayer12;
                }
                if (c == 33)
                {
                    if (p33.Source == null) { p33.Source = imagePlayer1; } else p33.Source = imagePlayer12;
                }
                if (c == 34)
                {
                    if (p34.Source == null) { p34.Source = imagePlayer1; } else p34.Source = imagePlayer12;
                }
                if (c == 35)
                {
                    if (p35.Source == null) { p35.Source = imagePlayer1; } else p35.Source = imagePlayer12;
                }
                if (c == 36)
                {
                    if (p36.Source == null) { p36.Source = imagePlayer1; } else p36.Source = imagePlayer12;
                }

            }

            else if (Players == false)
            {
                if (c == 1)
                {
                    if (p1.Source == null) { p1.Source = imagePlayer2; } else p1.Source = imagePlayer12;
                }
                if (c == 2)
                {
                    if (p2.Source == null) { p2.Source = imagePlayer2; } else p2.Source = imagePlayer12;
                }
                if (c == 3)
                {
                    if (p3.Source == null) { p3.Source = imagePlayer2; } else p3.Source = imagePlayer12;
                }
                if (c == 4)
                {
                    if (p4.Source == null) { p4.Source = imagePlayer2; } else p4.Source = imagePlayer12;
                }
                if (c == 5)
                {
                    if (p5.Source == null) { p5.Source = imagePlayer2; } else p5.Source = imagePlayer12;
                }
                if (c == 6)
                {
                    if (p6.Source == null) { p6.Source = imagePlayer2; } else p6.Source = imagePlayer12;
                }
                if (c == 7)
                {
                    if (p7.Source == null) { p7.Source = imagePlayer2; } else p7.Source = imagePlayer12;
                }
                if (c == 8)
                {
                    if (p8.Source == null) { p8.Source = imagePlayer2; } else p8.Source = imagePlayer12;
                }
                if (c == 9)
                {
                    if (p9.Source == null) { p9.Source = imagePlayer2; } else p9.Source = imagePlayer12;
                }
                if (c == 10)
                {
                    if (p10.Source == null) { p10.Source = imagePlayer2; } else p10.Source = imagePlayer12;
                }
                if (c == 11)
                {
                    if (p11.Source == null) { p11.Source = imagePlayer2; } else p11.Source = imagePlayer12;
                }
                if (c == 12)
                {
                    if (p12.Source == null) { p12.Source = imagePlayer2; } else p12.Source = imagePlayer12;
                }
                if (c == 13)
                {
                    if (p13.Source == null) { p13.Source = imagePlayer2; } else p13.Source = imagePlayer12;
                }
                if (c == 14)
                {
                    if (p14.Source == null) { p14.Source = imagePlayer2; } else p14.Source = imagePlayer12;
                }
                if (c == 15)
                {
                    if (p15.Source == null) { p15.Source = imagePlayer2; } else p15.Source = imagePlayer12;
                }
                if (c == 16)
                {
                    if (p16.Source == null) { p16.Source = imagePlayer2; } else p16.Source = imagePlayer12;
                }
                if (c == 17)
                {
                    if (p17.Source == null) { p17.Source = imagePlayer2; } else p17.Source = imagePlayer12;
                }
                if (c == 18)
                {
                    if (p18.Source == null) { p18.Source = imagePlayer2; } else p18.Source = imagePlayer12;
                }
                if (c == 19)
                {
                    if (p19.Source == null) { p19.Source = imagePlayer2; } else p19.Source = imagePlayer12;
                }
                if (c == 20)
                {
                    if (p20.Source == null) { p20.Source = imagePlayer2; } else p20.Source = imagePlayer12;
                }
                if (c == 21)
                {
                    if (p21.Source == null) { p21.Source = imagePlayer2; } else p21.Source = imagePlayer12;
                }
                if (c == 22)
                {
                    if (p22.Source == null) { p22.Source = imagePlayer2; } else p22.Source = imagePlayer12;
                }
                if (c == 23)
                {
                    if (p23.Source == null) { p23.Source = imagePlayer2; } else p23.Source = imagePlayer12;
                }
                if (c == 24)
                {
                    if (p24.Source == null) { p24.Source = imagePlayer2; } else p24.Source = imagePlayer12;
                }
                if (c == 25)
                {
                    if (p25.Source == null) { p25.Source = imagePlayer2; } else p25.Source = imagePlayer12;
                }
                if (c == 26)
                {
                    if (p26.Source == null) { p26.Source = imagePlayer2; } else p26.Source = imagePlayer12;
                }
                if (c == 27)
                {
                    if (p27.Source == null) { p27.Source = imagePlayer2; } else p27.Source = imagePlayer12;
                }
                if (c == 28)
                {
                    if (p28.Source == null) { p28.Source = imagePlayer2; } else p28.Source = imagePlayer12;
                }
                if (c == 29)
                {
                    if (p29.Source == null) { p29.Source = imagePlayer2; } else p29.Source = imagePlayer12;
                }
                if (c == 30)
                {
                    if (p30.Source == null) { p30.Source = imagePlayer2; } else p30.Source = imagePlayer12;
                }
                if (c == 31)
                {
                    if (p31.Source == null) { p31.Source = imagePlayer2; } else p31.Source = imagePlayer12;
                }
                if (c == 32)
                {
                    if (p32.Source == null) { p32.Source = imagePlayer2; } else p32.Source = imagePlayer12;
                }
                if (c == 33)
                {
                    if (p33.Source == null) { p33.Source = imagePlayer2; } else p33.Source = imagePlayer12;
                }
                if (c == 34)
                {
                    if (p34.Source == null) { p34.Source = imagePlayer2; } else p34.Source = imagePlayer12;
                }
                if (c == 35)
                {
                    if (p35.Source == null) { p35.Source = imagePlayer2; } else p35.Source = imagePlayer12;
                }
                if (c == 36)
                {
                    if (p36.Source == null) { p36.Source = imagePlayer2; } else p36.Source = imagePlayer12;
                }

            }
        }
        private void Initialize()
        {
            //if (Players == true)
            //{
            //    testing.Text = "You start Player 1\nRoll the dice!";
            //}
            //else if (Players == false)
            //{
            //    testing.Text = "You start Player 2\nRoll the dice!";
            //}
            Players = true;
            testing.Text = "You start Player 1\nRoll the dice!";
            Title.Content = "SNAKES AND LADDERS";
            Title.FontSize = 50;
            DiceImage.Source = null;
            startclock();
            counter = 1;
            counter2 = 1; 
            //p1.Source = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\PinClipart.com_strawberry-clipart_2471339.png"));
            imagePlayer1 = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Black.png"));
            imagePlayer2 = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\red.png"));
            imagePlayer12 = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Blackred.png"));
            p1.Source = imagePlayer12;

        }
        private void restart_button(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 36; i++)
            {
                RemoveCounter(i);
            }
            //InitializeComponent();
            Initialize();
           // Players = true;
            Statustext.Text = null;
        }
    }

}
