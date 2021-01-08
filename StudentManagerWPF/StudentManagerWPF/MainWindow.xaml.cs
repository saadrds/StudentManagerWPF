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
        string connString;
        SqlConnection con;
        public MainWindow()
        {
            connString = " Data Source = DESKTOP-SL2AUNJ; Initial Catalog = Gestion_Etudiant;";
            con = new SqlConnection();
            con.ConnectionString = connString;
            con.Open();
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand commande = new SqlCommand("Select * From Filiere", con);
            SqlDataReader reader = commande.ExecuteReader();
        }
    }
}
