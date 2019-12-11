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

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Position> allPositions;
        List<Position> selectedPositions;
        List<Position> filteredPositions;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            allPositions = GetPlayers();
            selectedPositions = new List<Position>();
            filteredPositions = new List<Position>();
            allPositions.Sort();
            lbxPlayers.ItemsSource = allPositions;
        }

        private List<Position> GetPlayers()
        {
            List<Position> allPositions = new List<Position>();

            Player G1 = new Player()
            {
                FirstName = "Adam",
                SurName = "Brennan",
                DateOfBirth = new DateTime(1999, 06, 01),
                PreferredPosition = Position.Goalkeeper,
                Age = new DateTime(20)
            };
            Player G2 = new Player()
            {
                FirstName = "Amelia",
                SurName = "Byrne",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Goalkeeper,
                Age = new DateTime(21)
            };
            Player D1 = new Player()
            {
                FirstName = "Ava",
                SurName = "Daly",
                DateOfBirth = new DateTime(1997, 06, 01),
                PreferredPosition = Position.Defender,
                Age = new DateTime(22)
            };
            Player D2 = new Player()
            {
                FirstName = "Chloe",
                SurName = "Doyle",
                DateOfBirth = new DateTime(1998, 08, 10),
                PreferredPosition = Position.Defender,
                Age = new DateTime(21)
            };
            Player D3 = new Player()
            {
                FirstName = "Conor",
                SurName = "Byrne",
                DateOfBirth = new DateTime(1999, 05, 08),
                PreferredPosition = Position.Defender,
                Age = new DateTime(20)
            };
            Player D4 = new Player()
            {
                FirstName = "Daniel",
                SurName = "Dunne",
                DateOfBirth = new DateTime(1997, 06, 01),
                PreferredPosition = Position.Defender,
                Age = new DateTime(23)
            };
            Player D5 = new Player()
            {
                FirstName = "Emily",
                SurName = "Fitzgerald",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Defender,
                Age = new DateTime(21)
            };
            Player D6 = new Player()
            {
                FirstName = "Emma",
                SurName = "Kavanagh",
                DateOfBirth = new DateTime(1996, 06, 01),
                PreferredPosition = Position.Defender,
                Age = new DateTime(24)
            };
            Player M1 = new Player()
            {
                FirstName = "Grace",
                SurName = "Kelly",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Midfielder,
                Age = new DateTime(21)
            };
            Player M2 = new Player()
            {
                FirstName = "Hannah",
                SurName = "Lynch",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Midfielder,
                Age = new DateTime(21)
            };
            Player M3 = new Player()
            {
                FirstName = "Harry",
                SurName = "McCarthy",
                DateOfBirth = new DateTime(1999, 06, 01),
                PreferredPosition = Position.Midfielder,
                Age = new DateTime(20)
            };
            Player M4 = new Player()
            {
                FirstName = "Jack",
                SurName = "McDonagh",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Midfielder,
                Age = new DateTime(21)
            };
            Player M5 = new Player()
            {
                FirstName = "James",
                SurName = "Murphy",
                DateOfBirth = new DateTime(1996, 06, 01),
                PreferredPosition = Position.Midfielder,
                Age = new DateTime(24)
            };
            Player M6 = new Player()
            {
                FirstName = "Lucy",
                SurName = "Nolan",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Midfielder,
                Age = new DateTime(21)
            };
            Player F1 = new Player()
            {
                FirstName = "Luke",
                SurName = "O'Brien",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Forward,
                Age = new DateTime(21)
            };
            Player F2 = new Player()
            {
                FirstName = "Mia",
                SurName = "O'Connor",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Forward,
                Age = new DateTime(21)
            };
            Player F3 = new Player()
            {
                FirstName = "Michael",
                SurName = "O'Neill",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Forward,
                Age = new DateTime(21)
            };
            Player F4 = new Player()
            {
                FirstName = "Noah",
                SurName = "O'Reilly",
                DateOfBirth = new DateTime(1998, 06, 01),
                PreferredPosition = Position.Forward,
                Age = new DateTime(21)
            };


            /* allPositions.Add(G1);
             allPositions.Add(G2);
             allPositions.Add(D1);

             allPositions.Add(D2);
             allPositions.Add(D3);
             allPositions.Add(D4);
             allPositions.Add(D5);
             allPositions.Add(D6);

             allPositions.Add(M1);
             allPositions.Add(M2);
             allPositions.Add(M3);
             allPositions.Add(M4);
             allPositions.Add(M5);
             allPositions.Add(M6);


             allPositions.Add(F1);
             allPositions.Add(F2);
             allPositions.Add(F3);
             allPositions.Add(F4);*/

            return allPositions;
        }

        private void LbxPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Player selectedPositions = lbxPlayers.SelectedItem as Player;
            if (selectedPositions != null)
                tblkSpaces.Text = selectedPositions.Spaces;
        }





        private void LbxSelectedPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Player selectedPlayers = lbxPlayers.SelectedItem as Player;
            if (selectedPlayers != null)
                tblkSpaces.Text = selectedPositions.Spaces;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Player selectedPlayers = lbxPlayers.SelectedItem as Player;

            if (selectedPlayers != null)
            {
              bool dateConflict = false;
                foreach (var players in selectedPositions)
                {
                    if (selectedPlayers.DateOfBirth == players.Age)
                    {
                        MessageBox.Show("Date conflict");
                        dateConflict = true;
                    }
                }
                if (!dateConflict)
                {
                    allPositions.Remove(selectedPlayers);
                    selectedPositions.Add(selectedPlayers);

                    //reset
                    lbxPlayers.ItemsSource = null;
                    lbxSelectedPlayers.ItemsSource = null;
                    lbxPlayers.ItemsSource = allPositions;

                    

                    selectedPositions.Sort();
                    lbxSelectedPlayers.ItemsSource = selectedPositions;

                  

                }
                else
                {
                    MessageBox.Show("Nothing selected");
                }

            }

            }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Player selectedPositions = lbxSelectedPlayers.SelectedItem as Player;
            if (selectedPositions != null)
            {
                selectedPositions.Remove(selectedPlayers);
                allPositions.Add(selectedPlayers);

                //reset
                lbxPlayers.ItemsSource = null;
                lbxSelectedPlayers.ItemsSource = null;
                allPlayers.Sort();
                
                lbxPlayers.ItemsSource = allPositions;
                lbxSelectedPlayers.ItemsSource = selectedPositions;

                
            }
            else
            {
                MessageBox.Show("Nothing selected");
            }
        }


        private void FilterType(string filterBy)
        {

            filteredPositions.Clear();

            switch (filterBy)
            {
                case "Goalkeepers":

                    //NOTE: You can use the line below instead of the foreach loop - it's quicker
                    //lbxActivities.ItemsSource = allActivities.Where(a => a.TypeOfActivity == ActivityType.Land);

                    foreach (Player player in allPositions)
                    {
                        if (player.PreferredPosition == Position.Goalkeeper)
                            filteredPositions.Add(player);
                    }

                    lbxPlayers.ItemsSource = null;
                    lbxPlayers.ItemsSource = filteredPositions;

                    break;
                case "Defenders":
                    foreach (Player player in allPositions)
                    {
                        if (player.PreferredPosition == Position.Defender)
                            filteredPositions.Add(player);
                    }

                    lbxPlayers.ItemsSource = null;
                    lbxPlayers.ItemsSource = filteredPositions;
                    break;
                case "Midefielders":
                    foreach (Player player in allPositions)
                    {
                        if (player.PreferredPosition == Position.Midfielder)
                            filteredPositions.Add(player);
                    }

                    lbxPlayers.ItemsSource = null;
                    lbxPlayers.ItemsSource = filteredPositions;
                    break;
                case "Forwards":
                    foreach (Player player in allPositions)
                    {
                        if (player.PreferredPosition == Position.Forward)
                            filteredPositions.Add(player);
                    }

                    lbxPlayers.ItemsSource = null;
                    lbxPlayers.ItemsSource = filteredPositions;
                    break;
                default:
                    lbxPlayers.ItemsSource = allPositions;
                    break;

            }
        }

    }
}
