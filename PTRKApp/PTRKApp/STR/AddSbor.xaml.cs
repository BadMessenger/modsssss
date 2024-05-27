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
using PTRKApp.STR;

namespace PTRKApp.STR.PLZ_STR
{
    /// <summary>
    /// Логика взаимодействия для AddSbor.xaml
    /// </summary>
    public partial class AddSbor : Page
    {
        AppData.Sbor sbor;
        bool checkNew;

        

        public AddSbor(AppData.Sbor c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new AppData.Sbor();
                checkNew = true;
            }
            else checkNew = false;
            DataContext = sbor = c;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sbor());
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                Class1.context.Sbor.Add(sbor);
            }
            Class1.context.SaveChanges();
            NavigationService.Navigate(new Sbor());
        }
    }
}
