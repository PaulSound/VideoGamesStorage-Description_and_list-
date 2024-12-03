using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для UpdateForm.xaml
    /// </summary>
    public partial class UpdateForm : Window
    {
        private static ClassContext context = new ClassContext();
        public Games? Games { get; set; }

        public string NameGame { get; set; }
        public string Age { get; set; }
        public string Platforms { get; set; }
        public string Genres { get; set; }
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }
        private decimal _price;
        public string? Description { get; set; }




        public UpdateForm(Window parent)
        {
            DataContext = this;
            Owner = parent;
            InitializeComponent();
            _cbLimits.ItemsSource = new string[]{"G","PG","PG-13", "R","NC-17"};
            _cbPlatforms.ItemsSource = new string[]{"Nintendo Switch","Playstation 4","Playstation 5","PC","Xbox One",};
            _cbGenre.ItemsSource = new string[]{"Action","RPG" ,"Shooter","Puzzle","Simulator"};
        }

        private void SearchGame(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameGame))
            {
                var item = context.games.Where(i => i.Name.ToLower() == NameGame.ToLower()).FirstOrDefault();
                Games = item;
            }
            if (Games != null)
            {
                {
                    _cbLimits.IsEnabled = true;
                    _cbGenre.IsEnabled = true;
                    _cbPlatforms.IsEnabled = true;
                    _tbЗPrice.IsEnabled = true;
                    _tbDescription.IsEnabled = true;
                    _saveButton.IsEnabled = true;
                }
                NameGame = Games.Name;
                _cbLimits.SelectedItem = Age = Games.AgeLimit;
                _cbPlatforms.SelectedItem = Platforms = Games.Platform;
                _cbGenre.SelectedItem = Genres = Games.Genre;


                Price = Games.Price;
                _tbЗPrice.Text = Price.ToString();

                _tbDescription.Text= Description = Games.Description;
                return;
            }
            else
            {
                MessageBox.Show("Искомая игра не была найдена, попробуйте снова", "Search failure", MessageBoxButton.OK);
                return;
            }
        }

        private void CloseForm(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UpdateData(object sender, RoutedEventArgs e)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };

            if (!decimal.TryParse(_tbЗPrice.Text, numberFormatInfo, out _price))
            {
                MessageBox.Show("В поле Price была введена не корректная информация", "Price Input Failure", MessageBoxButton.OK);
                return;
            }
            else  Games.Price = Price;
           
            Games.Description = Description;
            Games.Name = NameGame;


            ClassContext context = new ClassContext();

            context.games.Update(Games);
            context.SaveChanges();
            MessageBox.Show("Элемент был успешно обновлен","Success!",MessageBoxButton.OK);
        }

        private void _cbLimits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_cbLimits.SelectedItem is string al)
            {
                Age = al;
                Games.AgeLimit = Age;
            }

        }

        private void _cbPlatforms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_cbPlatforms.SelectedItem is string p)
            {
                Platforms = p;
                Games.Platform = Platforms;
            }
        }

        private void _cbGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_cbGenre.SelectedItem is string genre)
            {
                Genres = genre;
                Games.Genre = Genres;
            }
        }
    }
}
