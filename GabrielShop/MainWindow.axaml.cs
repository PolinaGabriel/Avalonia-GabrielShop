using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GabrielShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// ¬ход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenShop(object sender, RoutedEventArgs e)
        {
            if (authorize.Text == "admin")
            {
                AdminListWindow AdminList = new AdminListWindow();
                this.Close();
            }
            else if (authorize.Text == "user")
            {
                UserListWindow UserList = new UserListWindow();
                this.Close();
            }
            else
            {
                authorize.Text = "";
            }
        }
    }
}