using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VideoGamesStorage_Description_and_list_.Context;
using VideoGamesStorage_Description_and_list_.Model;
using VideoGamesStorage_Description_and_list_.View;

namespace VideoGamesStorage_Description_and_list_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string isolatedStorage;
        public string NameItem { get; set; }
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
        public string Description { get; set; }
        public Games[]? gameList { get; set; }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

            _cbLimits.ItemsSource = new string[] { "G", "PG", "PG-13", "R", "NC-17" };
            _cbPlatforms.ItemsSource = new string[] { "Nintendo Switch", "Playstation 4", "Playstation 5", "PC", "Xbox One", };
            _cbGenre.ItemsSource = new string[] { "Action", "RPG", "Shooter", "Puzzle", "Simulator" };

            if(!Directory.Exists(Directory.GetCurrentDirectory()+"\\CoreData"))
            {
                isolatedStorage = Path.Combine(Directory.GetCurrentDirectory() + "\\CoreData");
                Directory.CreateDirectory(isolatedStorage);
                File.Create(isolatedStorage + "\\games.txt");
                isolatedStorage = Path.Combine(isolatedStorage + "\\games.txt");
            }
              
        }

        private void AddNewGame(object sender, RoutedEventArgs e)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            using (ClassContext context=new ClassContext())
            {
                if(AreAnyValueNullOrEmpty(NameItem, Age, Platforms, Genres))
                {
                    MessageBox.Show("В игру были введены не корректные данные !", "Process failure", MessageBoxButton.OK);
                    return;
                }

                if(!decimal.TryParse(_tbЗPrice.Text, numberFormatInfo, out _price))
                {
                    MessageBox.Show("В поле Price была введена не корректная информация","Price Input Failure",MessageBoxButton.OK);
                    return;
                }

                Games games=new Games() {Name= NameItem, AgeLimit=Age,Genre=Genres,Platform=Platforms,Price=Price,Description=Description };
                context.games.Add(games);
                context.SaveChanges();
            }
            MessageBox.Show("Игра была успешно добавлена", "Success!", MessageBoxButton.OK);
        }

        private bool AreAnyValueNullOrEmpty(params string[]properties)
        {
            foreach (var item in properties)
            {
                if(string.IsNullOrEmpty(item))
                {
                    return true;
                }
            }
            return false;
        }

        private void _cbLimits_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(_cbLimits.SelectedItem is string al)
            Age = al;
        }

        private void _cbPlatforms_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (_cbPlatforms.SelectedItem is string p) 
                Platforms = p;
        }

        private void _cbGenre_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(_cbGenre.SelectedItem is string g) Genres = g;
        }

        private void DeleteGame(object sender, RoutedEventArgs e)
        {
            DeleteGameWindow deleteGameWindow = new DeleteGameWindow(this);
            Opacity = 0.2;
            deleteGameWindow.ShowDialog();
            Opacity = 1;

        }

        private void UpdateInfo(object sender, RoutedEventArgs e)
        { 
          UpdateForm updateForm = new UpdateForm(this);
            Opacity = 0.2;
            updateForm.ShowDialog();
            Opacity = 1;
        }

        private void GetDataInfo(object sender, RoutedEventArgs e)
        {
            GameInfoWindow gameInfoWindow = new GameInfoWindow(this);
            Opacity = 0.2;
            gameInfoWindow.Show();
            Opacity= 1;
        }

        private void SaveData(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile storage = IsolatedStorageFile.GetMachineStoreForAssembly();
            IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(isolatedStorage,FileMode.Open,FileAccess.ReadWrite,storage);
            StreamWriter streamWriter = new StreamWriter(isolatedStorageFileStream);

            ClassContext classContext = new ClassContext();
            gameList = classContext.games.ToArray();

            for (int i = 0; i < gameList.Length; i++)
                streamWriter.WriteLine(gameList[i].ToString());

            streamWriter.Close();
            MessageBox.Show("Данные были успешно сохранены. Нажмите ОК чтобы продолжить!","Success!",MessageBoxButton.OK);
        }
    }
}
