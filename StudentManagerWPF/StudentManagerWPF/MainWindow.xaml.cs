using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace StudentManagerWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text == "admin" && mdp.Password == "123456" )
            {
                error.Content = "*Done";
            }
            else
            {
                error.Content = "*Username or Password INCORRECT ! ";
            }
        }
    }
}
