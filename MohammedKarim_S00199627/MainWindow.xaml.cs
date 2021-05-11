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

namespace MohammedKarim_S00199627
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> AllGames;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = lbxGames.SelectedItem as Game;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GameData db = new GameData();
            var query = from p in db.Games
                        select p;

            AllGames = query.ToList();

            lbxGames.ItemsSource = AllGames;
        }
    }
}
