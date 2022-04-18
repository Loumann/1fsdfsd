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
 
    public partial class LogonList : Page
    {
        Db.user_06Entities _con = new Db.user_06Entities();
        ContentMenu _contentMenu = new ContentMenu();

        public LogonList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//проверка логина и пароля на наличие символов

            string RoleLogin = LoginTextBox.Text;
            string RolePass = LoginTextBox.Text;

            if (LoginTextBox.Text.Length != 0)
            {
                if (PasstextBox.Text.Length != 0 )
                {
                    Db.Employee basa = (Db.Employee)_con.Employee.Where(a => a.Phone == LoginTextBox.Text && a.Password == PasstextBox.Text).FirstOrDefault();
                    if (basa != null)
                    {
                        NavigationService nav = NavigationService.GetNavigationService(this);
                        nav.Navigate(new CookPanel());
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Все хуйня переделывай");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели пароль");
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели логин");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//с ЛогонЛист в меню для клиента
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new ContentMenu());
        }

        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
