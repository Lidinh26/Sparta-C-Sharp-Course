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
        public bool Players; // variable for adding another player
        int counter;
        int counter2;
        BitmapImage blackCounter;
        BitmapImage redCounter;
        BitmapImage bothCounters;
        BitmapImage StartingDice;
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
            DiceImage.Source = StartingDice;
        }
        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer(); //Timer display
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
                Application.Current.Shutdown(); // Exit the application
            }

        }
        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random(); //Random roll generator 
            int dice = r.Next(1, 7); //Between 1-6
            switch (dice) //Switch statement to assign the image of the dice rolled specifically to the value of the dice rolled
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
                Status.Text = "Player 1, it's your turn!";
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
                Status.Text = "Player 2, its your turn!";
                int oldCounter = counter;
                counter += dice; 

                if (counter > 36)
                {
                    counter = 36 + (36 - counter);
                }

                //Statements to make sure the counter moves accordingly to the snakes and ladders
                //ladder
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

                Statustext.Text = $"Player 1, you are in position {counter}";
                
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

            if (Players == true) //To make sure the the players rotate in turn order
            {
                Players = false;
            }
            else Players = true;
        }
        private void RemoveCounter2(int oldCounter2) //Method to remove the player 2 counter from previous position
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
        private void RemoveCounter(int oldCounter) //Method to remove the player 1 counter from previous position
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
        private void AddCounter(int c) //Method to move the counter position //Else statement to make sure right image is used when both counters are in the same position
        {
            if (Players == true)
            {
                if (c == 1)
                {
                    if (p1.Source == null) { p1.Source = blackCounter; } else p1.Source = bothCounters;
                }
                if (c == 2)
                {
                    if (p2.Source == null) { p2.Source = blackCounter; } else p2.Source = bothCounters;
                }
                if (c == 3)
                {
                    if (p3.Source == null) { p3.Source = blackCounter; } else p3.Source = bothCounters;
                }
                if (c == 4)
                {
                    if (p4.Source == null) { p4.Source = blackCounter; } else p4.Source = bothCounters;
                }
                if (c == 5)
                {
                    if (p5.Source == null) { p5.Source = blackCounter; } else p5.Source = bothCounters;
                }
                if (c == 6)
                {
                    if (p6.Source == null) { p6.Source = blackCounter; } else p6.Source = bothCounters;
                }
                if (c == 7)
                {
                    if (p7.Source == null) { p7.Source = blackCounter; } else p7.Source = bothCounters;
                }
                if (c == 8)
                {
                    if (p8.Source == null) { p8.Source = blackCounter; } else p8.Source = bothCounters;
                }
                if (c == 9)
                {
                    if (p9.Source == null) { p9.Source = blackCounter; } else p9.Source = bothCounters;
                }
                if (c == 10)
                {
                    if (p10.Source == null) { p10.Source = blackCounter; } else p10.Source = bothCounters;
                }
                if (c == 11)
                {
                    if (p11.Source == null) { p11.Source = blackCounter; } else p11.Source = bothCounters;
                }
                if (c == 12)
                {
                    if (p12.Source == null) { p12.Source = blackCounter; } else p12.Source = bothCounters;
                }
                if (c == 13)
                {
                    if (p13.Source == null) { p13.Source = blackCounter; } else p13.Source = bothCounters;
                }
                if (c == 14)
                {
                    if (p14.Source == null) { p14.Source = blackCounter; } else p14.Source = bothCounters;
                }
                if (c == 15)
                {
                    if (p15.Source == null) { p15.Source = blackCounter; } else p15.Source = bothCounters;
                }
                if (c == 16)
                {
                    if (p16.Source == null) { p16.Source = blackCounter; } else p16.Source = bothCounters;
                }
                if (c == 17)
                {
                    if (p17.Source == null) { p17.Source = blackCounter; } else p17.Source = bothCounters;
                }
                if (c == 18)
                {
                    if (p18.Source == null) { p18.Source = blackCounter; } else p18.Source = bothCounters;
                }
                if (c == 19)
                {
                    if (p19.Source == null) { p19.Source = blackCounter; } else p19.Source = bothCounters;
                }
                if (c == 20)
                {
                    if (p20.Source == null) { p20.Source = blackCounter; } else p20.Source = bothCounters;
                }
                if (c == 21)
                {
                    if (p21.Source == null) { p21.Source = blackCounter; } else p21.Source = bothCounters;
                }
                if (c == 22)
                {
                    if (p22.Source == null) { p22.Source = blackCounter; } else p22.Source = bothCounters;
                }
                if (c == 23)
                {
                    if (p23.Source == null) { p23.Source = blackCounter; } else p23.Source = bothCounters;
                }
                if (c == 24)
                {
                    if (p24.Source == null) { p24.Source = blackCounter; } else p24.Source = bothCounters;
                }
                if (c == 25)
                {
                    if (p25.Source == null) { p25.Source = blackCounter; } else p25.Source = bothCounters;
                }
                if (c == 26)
                {
                    if (p26.Source == null) { p26.Source = blackCounter; } else p26.Source = bothCounters;
                }
                if (c == 27)
                {
                    if (p27.Source == null) { p27.Source = blackCounter; } else p27.Source = bothCounters;
                }
                if (c == 28)
                {
                    if (p28.Source == null) { p28.Source = blackCounter; } else p28.Source = bothCounters;
                }
                if (c == 29)
                {
                    if (p29.Source == null) { p29.Source = blackCounter; } else p29.Source = bothCounters;
                }
                if (c == 30)
                {
                    if (p30.Source == null) { p30.Source = blackCounter; } else p30.Source = bothCounters;
                }
                if (c == 31)
                {
                    if (p31.Source == null) { p31.Source = blackCounter; } else p31.Source = bothCounters;
                }
                if (c == 32)
                {
                    if (p32.Source == null) { p32.Source = blackCounter; } else p32.Source = bothCounters;
                }
                if (c == 33)
                {
                    if (p33.Source == null) { p33.Source = blackCounter; } else p33.Source = bothCounters;
                }
                if (c == 34)
                {
                    if (p34.Source == null) { p34.Source = blackCounter; } else p34.Source = bothCounters;
                }
                if (c == 35)
                {
                    if (p35.Source == null) { p35.Source = blackCounter; } else p35.Source = bothCounters;
                }
                if (c == 36)
                {
                    if (p36.Source == null) { p36.Source = blackCounter; } else p36.Source = bothCounters;
                }

            }

            else if (Players == false)
            {
                if (c == 1)
                {
                    if (p1.Source == null) { p1.Source = redCounter; } else p1.Source = bothCounters;
                }
                if (c == 2)
                {
                    if (p2.Source == null) { p2.Source = redCounter; } else p2.Source = bothCounters;
                }
                if (c == 3)
                {
                    if (p3.Source == null) { p3.Source = redCounter; } else p3.Source = bothCounters;
                }
                if (c == 4)
                {
                    if (p4.Source == null) { p4.Source = redCounter; } else p4.Source = bothCounters;
                }
                if (c == 5)
                {
                    if (p5.Source == null) { p5.Source = redCounter; } else p5.Source = bothCounters;
                }
                if (c == 6)
                {
                    if (p6.Source == null) { p6.Source = redCounter; } else p6.Source = bothCounters;
                }
                if (c == 7)
                {
                    if (p7.Source == null) { p7.Source = redCounter; } else p7.Source = bothCounters;
                }
                if (c == 8)
                {
                    if (p8.Source == null) { p8.Source = redCounter; } else p8.Source = bothCounters;
                }
                if (c == 9)
                {
                    if (p9.Source == null) { p9.Source = redCounter; } else p9.Source = bothCounters;
                }
                if (c == 10)
                {
                    if (p10.Source == null) { p10.Source = redCounter; } else p10.Source = bothCounters;
                }
                if (c == 11)
                {
                    if (p11.Source == null) { p11.Source = redCounter; } else p11.Source = bothCounters;
                }
                if (c == 12)
                {
                    if (p12.Source == null) { p12.Source = redCounter; } else p12.Source = bothCounters;
                }
                if (c == 13)
                {
                    if (p13.Source == null) { p13.Source = redCounter; } else p13.Source = bothCounters;
                }
                if (c == 14)
                {
                    if (p14.Source == null) { p14.Source = redCounter; } else p14.Source = bothCounters;
                }
                if (c == 15)
                {
                    if (p15.Source == null) { p15.Source = redCounter; } else p15.Source = bothCounters;
                }
                if (c == 16)
                {
                    if (p16.Source == null) { p16.Source = redCounter; } else p16.Source = bothCounters;
                }
                if (c == 17)
                {
                    if (p17.Source == null) { p17.Source = redCounter; } else p17.Source = bothCounters;
                }
                if (c == 18)
                {
                    if (p18.Source == null) { p18.Source = redCounter; } else p18.Source = bothCounters;
                }
                if (c == 19)
                {
                    if (p19.Source == null) { p19.Source = redCounter; } else p19.Source = bothCounters;
                }
                if (c == 20)
                {
                    if (p20.Source == null) { p20.Source = redCounter; } else p20.Source = bothCounters;
                }
                if (c == 21)
                {
                    if (p21.Source == null) { p21.Source = redCounter; } else p21.Source = bothCounters;
                }
                if (c == 22)
                {
                    if (p22.Source == null) { p22.Source = redCounter; } else p22.Source = bothCounters;
                }
                if (c == 23)
                {
                    if (p23.Source == null) { p23.Source = redCounter; } else p23.Source = bothCounters;
                }
                if (c == 24)
                {
                    if (p24.Source == null) { p24.Source = redCounter; } else p24.Source = bothCounters;
                }
                if (c == 25)
                {
                    if (p25.Source == null) { p25.Source = redCounter; } else p25.Source = bothCounters;
                }
                if (c == 26)
                {
                    if (p26.Source == null) { p26.Source = redCounter; } else p26.Source = bothCounters;
                }
                if (c == 27)
                {
                    if (p27.Source == null) { p27.Source = redCounter; } else p27.Source = bothCounters;
                }
                if (c == 28)
                {
                    if (p28.Source == null) { p28.Source = redCounter; } else p28.Source = bothCounters;
                }
                if (c == 29)
                {
                    if (p29.Source == null) { p29.Source = redCounter; } else p29.Source = bothCounters;
                }
                if (c == 30)
                {
                    if (p30.Source == null) { p30.Source = redCounter; } else p30.Source = bothCounters;
                }
                if (c == 31)
                {
                    if (p31.Source == null) { p31.Source = redCounter; } else p31.Source = bothCounters;
                }
                if (c == 32)
                {
                    if (p32.Source == null) { p32.Source = redCounter; } else p32.Source = bothCounters;
                }
                if (c == 33)
                {
                    if (p33.Source == null) { p33.Source = redCounter; } else p33.Source = bothCounters;
                }
                if (c == 34)
                {
                    if (p34.Source == null) { p34.Source = redCounter; } else p34.Source = bothCounters;
                }
                if (c == 35)
                {
                    if (p35.Source == null) { p35.Source = redCounter; } else p35.Source = bothCounters;
                }
                if (c == 36)
                {
                    if (p36.Source == null) { p36.Source = redCounter; } else p36.Source = bothCounters;
                }

            }
        }
        private void Initialize()
        {
            DiceImage.Source = StartingDice;
            Players = true;
            Status.Text = "You start Player 1\nRoll the dice!";
            Title.Content = "SNAKES AND LADDERS";
            Title.FontSize = 50;
            startclock();
            counter = 1;
            counter2 = 1; 
            //Assigning the images to the counter variable
            blackCounter = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Black.png"));
            redCounter = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\red.png"));
            bothCounters = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\Blackred.png"));
            StartingDice = new BitmapImage(new Uri("C:\\Sparta-C-Sharp-Course\\Snakes_and_ladders\\Images\\dice_noun_002_10624.jpg"));
            p1.Source = bothCounters;

        }
        private void restart_button(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 36; i++)  // For loop to remove the counters from the board. 
            {
                RemoveCounter(i);
                RemoveCounter2(i);
            }
            Initialize();
            Statustext.Text = null;
        }
    }
}