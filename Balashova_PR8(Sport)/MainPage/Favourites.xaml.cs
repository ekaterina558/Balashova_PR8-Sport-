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

namespace Balashova_PR8_Sport_.MainPage
{
    /// <summary>
    /// Логика взаимодействия для Favourites.xaml
    /// </summary>
    public partial class Favourites : Page
    {
        public Favourites()
        {
            InitializeComponent();
        }

        private void Kross1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Kartochka());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var MyWindow = Window.GetWindow(this);
            ProSport prosport1 = new ProSport();
            prosport1.Show();
            MyWindow.Close();
        }

        private void Buy1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Basket());
        }
    }
}
