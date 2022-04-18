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
using Word = Microsoft.Office.Interop.Word;

namespace Namordnick
{
    /// <summary>
    /// Логика взаимодействия для ServiceList.xaml
    /// </summary>
    public partial class ServiceList : Page
    {
        PageChange pc = new PageChange(Const.BD.Product.ToList().Count);
        public ServiceList()
        {
            InitializeComponent();
            LVCelebration.ItemsSource = Const.BD.books.ToList();

            List<basket> lBasket = Const.BD.basket.ToList();
            int countBooks = Const.BD.basket.Count();
            int sale = 0;
            int cost = 0;
            if (countBooks >= 3)
            {
                sale = 5;
            }
            if (countBooks >= 5)
            {
                sale = 10;
            }
            if (countBooks >= 10)
            {
                sale = 15;
            }
            foreach (basket b in lBasket)
            {
                cost += b.books.cost.Value;
            }
            if (sale > 0)
            {
                booksCostWithSale.Text = (cost - (cost * sale / 100)).ToString() + ' ';
            }
            booksCount.Text = countBooks.ToString();
            booksCost.Text = cost.ToString() + ' ';
            Sale.Text = sale.ToString();
        }

        private void Badd_click(object sender, RoutedEventArgs e)
        {
            basket bask = new basket();
            books book = (books) LVCelebration.SelectedItem;
            bask.bookId = book.id;
            Const.BD.basket.Add(bask);
            Const.BD.SaveChanges();
            List<basket> lBasket = Const.BD.basket.ToList();
            int countBooks = Const.BD.basket.Count();
            int sale = 0;
            int cost = 0;
            if (countBooks >= 3)
            {
                sale = 5;
            }
            if (countBooks >= 5)
            {
                sale = 10;
            }
            if (countBooks >= 10)
            {
                sale = 15;
            }
            foreach (basket b in lBasket)
            {
                cost += b.books.cost.Value;
            }
            if (sale > 0)
            {
                booksCostWithSale.Text = (cost - (cost * sale / 100)).ToString() + ' ';
            }
            booksCount.Text = countBooks.ToString();
            booksCost.Text = cost.ToString() + ' ';
            Sale.Text = sale.ToString();
        }
        private void Bopen_click(object sender, RoutedEventArgs e)
        {
            Const.frame.Navigate(new basketList());
        }
    }
}
