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

namespace PTRKApp
{

    /// <summary>
    /// Логика взаимодействия для login_admin_not.xaml
    /// </summary>
    public partial class login_admin_not : Page
    {
        

        public login_admin_not()
        {
            InitializeComponent();
        }

        private void Btn_No_Admin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MeinMenu());
            
        }

        private void Btn_Admin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new login());
            
        }
    }
}
