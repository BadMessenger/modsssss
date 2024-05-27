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
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string password = "123";
            string texxt = Convert.ToString(TextBox2.Password);
            if(password == texxt)
            {
                AppData.Class2.adminNoadmin = 1;
                
                NavigationService.Navigate(new MeinMenu());
            }
            else
            {
                MessageBox.Show("Пароль не верный, уходите!");
            }
        }

       
    }
}
