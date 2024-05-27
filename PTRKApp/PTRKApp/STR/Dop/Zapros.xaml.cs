using PTRKApp.AppData;
using PTRKApp.STR.PLZ_STR;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace PTRKApp.STR.Dop
{
    /// <summary>
    /// Логика взаимодействия для Zapros.xaml
    /// </summary>
    public partial class Zapros : Page
    {
       
        public Zapros()
        {
            InitializeComponent();
            SborTab.ItemsSource = Class1.context.Sbor.ToList();

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sbor());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            FIO.Visibility = Visibility.Hidden;
            DATA.Visibility = Visibility.Hidden;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ID.Visibility = Visibility.Hidden;
            DATA.Visibility = Visibility.Hidden;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            FIO.Visibility = Visibility.Hidden;
            ID.Visibility = Visibility.Hidden;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            ID.Visibility = Visibility.Visible;
            DATA.Visibility = Visibility.Visible;
            FIO.Visibility = Visibility.Visible;
        }
    }
}
