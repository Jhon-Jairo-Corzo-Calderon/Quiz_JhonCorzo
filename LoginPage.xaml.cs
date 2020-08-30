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

namespace QuizJhonCorzo
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

            MainWindow w = (MainWindow)Window.GetWindow(this);

            

            
            {
                txtUsername.Text = "";
                txtPassword.Password = "";
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtUsername.Text=="jhon" && txtPassword.Password=="1234")
                
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.loginFrame.Visibility = Visibility.Hidden;
                w.mainFrame.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        private void Grid_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Password = "";
        }
    }
}
