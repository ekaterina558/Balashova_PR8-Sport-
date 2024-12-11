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
    /// Логика взаимодействия для Kartochka.xaml
    /// </summary>
    public partial class Kartochka : Page
    {
        public Kartochka()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var MyWindow = Window.GetWindow(this);
            ProSport prosport1 = new ProSport();
            prosport1.Show();
            MyWindow.Close();
        }

        private void Dop_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Favourites());
        }

        private void Dop1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Basket());
        }

        private void Dop2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Zakaz());
        }
    }
}
