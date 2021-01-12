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
using System.Windows.Shapes;

namespace StudentManagerWPF
{
    /// <summary>
    /// Logique d'interaction pour MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {   //data base attributes
        string connString;
        SqlConnection con;
        //data base attributes end
        int valueButton = 1;
        public MenuWindow()
        {
            InitializeComponent();
            //data base connexion code
            string SaadServer = "DESKTOP-SL2AUNJ";
            connString = "Data Source =" + SaadServer + "; Initial Catalog = Gestion_Etudiant; Integrated Security = true;";
            con = new SqlConnection();
            con.ConnectionString = connString;
            con.Open();
            //data base connexion code end
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }
        private void Close(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }
        private void Choix_menu(object sender, System.Windows.RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            //GridCursor.Margin = new Thickness(10 + (326 * index), 0, 0, -40);
            switch (index)
            {
                case 0: // Gestion des etudiants
                    break;
                case 1: // gestion des filieres
                    break;
                case 2: // statistique
                    break;

            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void TabablzControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button1ere_Click(object sender, RoutedEventArgs e)
        {
            valueButton = 1;
            Button1ere.Background = new SolidColorBrush(Color.FromRgb(32, 0, 255));
            Button2eme.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
            Button3eme.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
        }

        private void Button2eme_Click(object sender, RoutedEventArgs e)
        {
            valueButton = 2;
            Button2eme.Background = new SolidColorBrush(Color.FromRgb(32, 0, 255));
            Button1ere.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
            Button3eme.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
        }

        private void Button3eme_Click(object sender, RoutedEventArgs e)
        {
            valueButton = 3;
            Button3eme.Background = new SolidColorBrush(Color.FromRgb(32, 0, 255));
            Button2eme.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
            Button1ere.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand commande = new SqlCommand("Select photo,cne,nom,prenom From Etudiant", con);
            SqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                cards.Children.Add(new StudentCard(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),reader[3].ToString()));

            }
            reader.Close();
        }
    }
}
