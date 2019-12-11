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
            //create list items
            Player firstplayer = new Player(GetRandomPlayer());
            Player secondplayer = new Player(GetRandomPlayer());
            Player thirdplayer = new Player(GetRandomPlayer());
            Player fourthplayer = new Player(GetRandomPlayer());
            
            //addtolist
            allPlayers.Add(firstplayer);
            allPlayers.Add(secondplayer);
            allPlayers.Add(thirdplayer);
            allPlayers.Add(fourthplayer);


            allPlayersLbx.ItemsSource = allPlayers;

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }


        //Randomiser Method
        private Player GetRandomPlayer()
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
}
