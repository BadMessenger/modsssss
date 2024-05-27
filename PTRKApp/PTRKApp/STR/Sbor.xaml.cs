using PTRKApp.AppData;
using PTRKApp.STR.Dop;
using PTRKApp.STR.PLZ_STR;
using System;
using System.Collections.Generic;
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

namespace PTRKApp
{
    /// <summary>
    /// Логика взаимодействия для Sbor.xaml
    /// </summary>
    public partial class Sbor : Page
    {
        public Sbor()
        {
            InitializeComponent();
            SborTab.ItemsSource = Class1.context.Sbor.ToList();
            if (AppData.Class2.adminNoadmin != 1)
            {
                Button6.Visibility = Visibility.Collapsed;
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MeinMenu());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddSbor(null));
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            var DelSbor = SborTab.SelectedItems.Cast<AppData.Sbor>().ToList();
            foreach (var dsbor in DelSbor)
                if (Class1.c.uche_sbora.Any(x => x.id_uchet == dsbor.id_Sbor))
                {
                    MessageBox.Show("Данные используются в таблице Справочная", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {DelSbor.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Class1.c.Sbor.RemoveRange(DelSbor);
            try
            {
                Class1.c.SaveChanges();
                SborTab.ItemsSource = Class1.c.Sbor.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Zapros());
        }
    }
}
