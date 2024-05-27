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

namespace PTRKApp.STR
{
    /// <summary>
    /// Логика взаимодействия для AddGroup.xaml
    /// </summary>
    public partial class AddGroup : Page
    {
        group gro;
        bool checkNew;
        public AddGroup(group c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new group();
                checkNew = true;
            }
            else checkNew = false;
            DataContext = gro = c;
            Update();
        }

        void Update()
        {
            SborDG.ItemsSource = gro.Sbor.ToList();
            AddSborCmb.ItemsSource = Class1.context.Sbor.ToList().Except(gro.Sbor.ToList());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new gr());
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // if (checkNew)
            // {
            //     Class1.context.group.Add(group);
            // }
            // try
            // {
            //     Class1.context.SaveChanges();
            // }
            // catch(Exception ex) 
            // {
            //     MessageBox.Show(ex.Message.ToString(), "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            // }
            //NavigationService.Navigate(new gr());
            if (checkNew)
            {
                Class1.context.group.Add(gro);
            }
            Class1.context.SaveChanges();
            NavigationService.Navigate(new gr());
        }

        private void AddSborBtn_Click(object sender, RoutedEventArgs e)
        {
            gro.Sbor.Add(AddSborCmb.SelectedItem as AppData.Sbor);
            Update();
        }

        private void DelSborBtn_Click(object sender, RoutedEventArgs e)
        {
            var DelSbor = SborDG.SelectedItems.Cast<AppData.Sbor>().ToList();
            foreach(var d in DelSbor)
                gro.Sbor.Remove(d);
            Update();
        }
    }
}
