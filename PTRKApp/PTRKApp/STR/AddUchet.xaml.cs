using PTRKApp.AppData;
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
    /// Логика взаимодействия для AddUchet.xaml
    /// </summary>
    public partial class AddUchet : Page
    {
        uche_sbora uch;
        bool checkNew;
        public AddUchet(uche_sbora c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new uche_sbora();
                checkNew = true;
            }
            else checkNew = false;
            DataContext = uch = c;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                Class1.context.uche_sbora.Add(uch);
            }
            Class1.context.SaveChanges();
            NavigationService.Navigate(new uchet());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uchet());
        }
    }
}
