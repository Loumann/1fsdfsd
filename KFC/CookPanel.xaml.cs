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
    /// <summary>
    /// Логика взаимодействия для CookPanel.xaml
    /// </summary>
    public partial class CookPanel : Page
    {


      
        public CookPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { //Переход с страницы повара на ЛогонЛист
            NavigationService nav = NavigationService.GetNavigationService(this);   
            nav.Navigate(new LogonList());
        }
    }
}
