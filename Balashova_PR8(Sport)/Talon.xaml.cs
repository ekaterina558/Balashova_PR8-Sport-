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
    /// Логика взаимодействия для Talon.xaml
    /// </summary>
    public partial class Talon : Window
    {
        public Talon()
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
    }
}
