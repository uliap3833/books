using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Namordnick
{
    public partial class books
    {

        public string СountInShop
        {
            get
            {
                if (countInShop > 5) { return "Много"; }
                else if(countInShop == 0) { return "Нет"; } else
                {
                    return countInShop.ToString();
                }
            }
        }

        public string CountInSklad
        {
            get
            {
                if (countInSklad > 5) { return "Много"; }
                else if (countInSklad == 0) { return "Нет"; }
                else
                {
                    return countInSklad.ToString();
                }
            }
        }
    }
}
