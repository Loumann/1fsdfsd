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

namespace KFC
{
   
    public partial class ContentMenu : Page
    {
        public ContentMenu()
        {
            InitializeComponent();
        }

        private void BasketButton_Click(object sender, RoutedEventArgs e)
        {// с меню на корзину
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Basket());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//с меню на ЛогонЛист
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new LogonList());
        }
    }
}
