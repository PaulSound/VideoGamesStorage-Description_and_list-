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
using System.Windows.Shapes;
using VideoGamesStorage_Description_and_list_.Context;
using VideoGamesStorage_Description_and_list_.Model;

namespace VideoGamesStorage_Description_and_list_.View
{
    /// <summary>
    /// Логика взаимодействия для GameInfoWindow.xaml
    /// </summary>
    public partial class GameInfoWindow : Window
    {
        private static ClassContext context = new ClassContext();
        private static Games[] gameArr;
        public Games? Game { get; set; }
        public string Description { get; set; }

        public GameInfoWindow(Window parent)
        {
            DataContext = this;
            InitializeComponent();

            gameArr=context.games.ToArray();
            _gameList.ItemsSource=GetStringArrValues(gameArr);
            _tbDisplayInfo.Text = gameArr[_gameList.SelectedIndex].ToString();
        }
        static string[] GetStringArrValues(Games[]arr)
        {
            string[] titles = new string[arr.Length];
            for (int i = 0; i < titles.Length; i++) titles[i] = arr[i].Name;
            return titles;
        }

        private void _gameList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _tbDisplayInfo.Text = gameArr[_gameList.SelectedIndex].ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
