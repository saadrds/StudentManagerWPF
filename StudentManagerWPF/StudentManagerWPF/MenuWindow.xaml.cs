using System;
using System.Collections.Generic;
using System.Data;
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
    {
        int filiere;
        string connString;
        public static MenuWindow currentWindow;
        SqlConnection con;
        public MenuWindow()
        {
            InitializeComponent();
            currentWindow = this;
            radGridView.Visibility = Visibility.Hidden;
            infoFiliere.Visibility = Visibility.Hidden;
            string SaadServer = "DESKTOP-SL2AUNJ";
            connString = "Data Source =" + SaadServer + "; Initial Catalog = Gestion_Etudiant; Integrated Security = true;";
            con = new SqlConnection();
            con.ConnectionString = connString;
            con.Open();
            SqlCommand commande = new SqlCommand("Select * From Filiere", con);
            SqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                ComboBox1.Items.Add(reader.GetString(1));
            }
            reader.Close();
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
        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            ButtonEdit.Background = new SolidColorBrush(Color.FromRgb(32, 0, 255));
            EditWindow edit = new EditWindow(filiere);
            edit.Show();
            this.Hide();
            
           
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
            if(!radGridView.IsVisible)
                radGridView.Visibility = Visibility.Visible;
            radGridView.ItemsSource = null;
            filiere = Convert.ToInt32(ComboBox1.SelectedIndex) + 1;
            SqlParameter para = new SqlParameter("@filiere", filiere);
            SqlParameter para2 = new SqlParameter("@filiere", filiere);
            SqlCommand commande = new SqlCommand("Select * From Etudiant where id_fil = @filiere", con);
            commande.Parameters.Add(para);
            SqlDataReader reader = commande.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cne", typeof(string));
            dt.Columns.Add("image", typeof(ImageSource));
            dt.Columns.Add("nom", typeof(string));
            dt.Columns.Add("prenom", typeof(string));
            dt.Columns.Add("sexe", typeof(string));
            dt.Columns.Add("date", typeof(string));
            dt.Columns.Add("email", typeof(string));
            dt.Columns.Add("idFiliere", typeof(int));
            dt.Columns.Add("annee", typeof(int));
            //List < Image > = new List() < Image >;
            while (reader.Read())
            {
                Image img = new Image();
                img.Source = new ImageSourceConverter().ConvertFromString(reader.GetString(5)) as ImageSource;
                dt.Rows.Add(reader.GetString(0), img.Source, reader.GetString(1), reader.GetString(2), reader[3].ToString(), reader.GetDateTime(4).Date.ToString("d"), reader.GetString(6), Convert.ToInt32(reader[7].ToString()), Convert.ToInt32(reader[8].ToString()));
                radGridView.ItemsSource = dt.DefaultView;

            }
            reader.Close();
            SqlCommand commande2 = new SqlCommand("Select * From Filiere where Id_filiere = @filiere", con);
            if (!infoFiliere.IsVisible)
                infoFiliere.Visibility = Visibility.Visible;
            commande2.Parameters.Add(para2);
            reader = commande2.ExecuteReader();
            reader.Read();
            nomFiliere.Text = reader.GetString(1);
            respo.Text = reader.GetString(2);
            reader.Close();
        }
    }
}
