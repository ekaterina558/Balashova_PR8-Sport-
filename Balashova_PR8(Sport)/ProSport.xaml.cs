using Balashova_PR8_Sport_.MainPage;
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

namespace Balashova_PR8_Sport_
{
    /// <summary>
    /// Логика взаимодействия для ProSport.xaml
    /// </summary>
    public partial class ProSport : Window
    {
        public ProSport()
        {
            InitializeComponent();
        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Catalog());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Basket());
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Favourites());
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            var MyWindow = Window.GetWindow(this);
            ProSport prosport1 = new ProSport();
            prosport1.Show();
            MyWindow.Close();

        }

        private void Tovar_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Tovar());
        }
    }
}
