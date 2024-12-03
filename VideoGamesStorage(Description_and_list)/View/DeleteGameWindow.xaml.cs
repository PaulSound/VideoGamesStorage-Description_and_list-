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
    /// Логика взаимодействия для DeleteGameWindow.xaml
    /// </summary>
    public partial class DeleteGameWindow : Window
    {
        private string _name;
        private Games _game;
        public string? Name { get => _name; }
        public Games? Game {get=>_game;set=>_game=value;}

        public DeleteGameWindow(Window parent)
        {
            Owner= parent;
            InitializeComponent();
        }

        private void _search_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(_gameToSearch.Text))
            {
                MessageBox.Show("Вы не ввели название игры для поиска. Попробуйте снова.", "SearchError!", MessageBoxButton.OK,MessageBoxImage.Hand);
                Close();
                return;
            }
            _name= _gameToSearch.Text;

            ClassContext classContext =new ClassContext();
            var item = classContext.games.Where(i => i.Name.ToLower() == Name.ToLower()).FirstOrDefault();
            if(item!=null)
            {
                _delete.IsEnabled = true;
                Game=item;
                MessageBox.Show("Искомая игра найдена","Success!",MessageBoxButton.OK);
                classContext.Dispose();
                return;
            }
            else
            {
                MessageBox.Show("Указанное иры нет. Попробуйте снова!","Not found!",MessageBoxButton.OK);
                classContext.Dispose();
                return;
            }
            
        }

        private void _cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void _delete_Click(object sender, RoutedEventArgs e)
        {
            ClassContext classContext=new ClassContext();
            classContext.games.Remove(Game);
            
            MessageBoxResult result=MessageBox.Show("Игра удалена из из базы данных! Уверены что хотите удалить? ","Success",MessageBoxButton.OKCancel,MessageBoxImage.Question);
            if (result == MessageBoxResult.OK) {
                classContext.SaveChanges();
                Close();
            } 
            else
            {
                Game = null;
                _delete.IsEnabled = false;
                classContext.Dispose();
                Close();
            }
        }
    }
}
