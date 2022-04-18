using System.Windows;

namespace KFC
{
    public partial class MainWindow : Window
    {
       


        LogonList logonList = new LogonList();
        public MainWindow()
        {
            InitializeComponent();
           MainFrame.Content = logonList;

        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
