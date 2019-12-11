using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace S00189364_FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> allPlayers = new List<Player>();
        List<Player> selectedPlayers = new List<Player>();
        Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AllPlayersLbx_Loaded(object sender, RoutedEventArgs e)
        {
            ////create list items
            Player p1 = new Player("James", "McGill", Position.Defender, new DateTime(1999, 2, 2), 21);
            Player p2 = new Player("Brad", "Tully", Position.Defender, new DateTime(2001, 2, 2), 21);
            Player p3 = new Player("Luke", "Bowen", Position.Goalkeeper, new DateTime(1998, 2, 2), 21);
            Player p4 = new Player("Fred", "Flanders", Position.Forward, new DateTime(1996, 2, 2), 21);
            Player p5 = new Player("Bill", "Evans", Position.Forward, new DateTime(2003, 2, 2), 21);
            Player p6 = new Player("Roger", "Flute", Position.Midfielder, new DateTime(1992, 2, 2), 21);
            Player p7 = new Player("Andy", "Flatherty", Position.Midfielder, new DateTime(1996, 2, 2), 21);

            //Could not get code working so here is a different way just to show that the listbox is working 
            Player p8 = new Player("Andy", "Flatherty", "Position.Midfielder", new DateTime(1996, 2, 2), 21);


            //addtolist
            allPlayers.Add(p1);
            allPlayers.Add(p2);
            allPlayers.Add(p3);
            allPlayers.Add(p4);
            allPlayers.Add(p5);
            allPlayers.Add(p6);
            allPlayers.Add(p7);
            allPlayers.Add(p8);


            allPlayersLbx.ItemsSource = allPlayers;

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Player selectedPlayer = allPlayersLbx.SelectedItem as Player;
            //null check 
            if (selectedPlayer != null)
            { ////move item from left to right
                allPlayers.Remove(selectedPlayer);
                selectedPlayers.Add(selectedPlayer);

                //refresh screeen
                allPlayersLbx.ItemsSource = null;
                allPlayersLbx.ItemsSource = allPlayers;

                selectedPlayersLbx.ItemsSource = null;
                selectedPlayersLbx.ItemsSource = selectedPlayers;
            }
        }
        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            //figure which item selected
            Player selectedPlayer = selectedPlayersLbx.SelectedItem as Player;
            //null check 
            if (selectedPlayer != null)
            { ////move item from left to right
                selectedPlayers.Remove(selectedPlayer);
                allPlayers.Add(selectedPlayer);

                //refresh screeen
                allPlayersLbx.ItemsSource = null;
                allPlayersLbx.ItemsSource = allPlayers;

                selectedPlayersLbx.ItemsSource = null;
                selectedPlayersLbx.ItemsSource = selectedPlayers;

                
            }


            //Randomiser Method
            private void Player GetRandomPlayer()


        
                {
            //get rndom FirstName
            string[] randomfirstnames = { "John, Ryan, Dylan, Michael" };
            int randomNumber = rng.Next(0, 4);
            string firstname = randomfirstnames[randomNumber];
            //get rndom SurName
            string[] randomsurnames = { "McCarthy, Fitzpatrick, Cooney, Walsh" };
            int randomNumber2 = rng.Next(0, 4);
            string surname = randomsurnames[randomNumber];
            //get rndom postion
            string[] randompositions = { "Goalkeeper, Defender, Midfielder, Forward" };
            int randomNumber3 = rng.Next(0, 4);
            string preferedPosition = randompositions[randomNumber];
            //get random age
            //get rndom FirstName
            int[] randomages = { 20, 25, 28, 30 };
            int randomNumber4 = rng.Next(0, 4);
            int age = randomages[randomNumber];
            //get rndom datetime
            randomNumber = rng.Next(0, 31);
            DateTime randomDate = DateTime.Now.AddDays(-randomNumber);
            //create expense object with randominfo 
            Player p1 = new Player(firstname, surname, preferedPosition, randomDate, age);

            //return 
            return p1;


             }


    }
    } }
