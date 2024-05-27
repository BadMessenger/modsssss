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
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        public Product()
        {
            InitializeComponent();
            SborTab.ItemsSource = Class1.context.product.ToList();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MeinMenu());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProduct(null));
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            var DelP = SborTab.SelectedItems.Cast<product>().ToList();
            foreach (var q in DelP)
                if (Class1.c.uche_sbora.Any(x => x.id_uchet == q.id_product))
                {
                    MessageBox.Show("Данные используются в таблице Справочная", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {DelP.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Class1.c.product.RemoveRange(DelP);
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
    }
}
