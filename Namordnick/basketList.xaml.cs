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

namespace Namordnick
{
    /// <summary>
    /// Логика взаимодействия для basketList.xaml
    /// </summary>
    public partial class basketList : Page
    {
            PageChange pc = new PageChange(Const.BD.Product.ToList().Count);
            public basketList()
            {
                InitializeComponent();
                LVBasket.ItemsSource = Const.BD.basket.ToList();
            }

        private void Lback_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            Const.frame.Navigate(new ServiceList());
        }
        private void Bdelete_click(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int ind = Convert.ToInt32(B.Uid);
            basket Delete = Const.BD.basket.FirstOrDefault(y => y.id == ind);
            Const.BD.basket.Remove(Delete);
            Const.BD.SaveChanges();
            Const.frame.Navigate(new basketList());
            MessageBox.Show("Книга удалена", "", MessageBoxButton.OK);
        }
    }
}
