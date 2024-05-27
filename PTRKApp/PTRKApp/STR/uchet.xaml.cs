using PTRKApp.AppData;
using PTRKApp.STR.PLZ_STR;
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
    /// Логика взаимодействия для uchet.xaml
    /// </summary>
    public partial class uchet : Page
    {
        public uchet()
        {
            InitializeComponent();
            SborTab.ItemsSource = Class1.context.uche_sbora.ToList();

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MeinMenu());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddUchet(null));
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            var DelU = SborTab.SelectedItems.Cast<uche_sbora>().ToList();
            foreach (var q in DelU)
                if (Class1.c.uche_sbora.Any(x => x.id_uchet == q.id_uchet))
                {
                    MessageBox.Show("Данные используются в таблице Справочная", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {DelU.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Class1.c.uche_sbora.RemoveRange(DelU);
            try
            {
                Class1.c.SaveChanges();
                SborTab.ItemsSource = Class1.c.uche_sbora.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
    }
}