using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Namordnick
{
    public partial class basket
    {

        public string СountBooksInBasket
        {
            get
            {
                return Const.BD.basket.Count().ToString();
            }
        }
    }
}
