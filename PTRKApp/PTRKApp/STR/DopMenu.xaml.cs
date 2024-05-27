using PTRKApp.STR.Dop;
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

namespace PTRKApp.STR
{
    /// <summary>
    /// Логика взаимодействия для DopMenu.xaml
    /// </summary>
    public partial class DopMenu : Page
    {
        public DopMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Matem());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uchet());
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sbor());
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MeinMenu());
        }
    }
}
