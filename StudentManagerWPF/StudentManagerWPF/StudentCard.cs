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
    class StudentCard:WrapPanel
    {
        //Image img;
        TextBlock cne = new TextBlock();
        TextBlock nom = new TextBlock();
        TextBlock prenom = new TextBlock();

        public StudentCard(String cne, String nom, String prenom)
        {
            this.Height = 200;
            this.Width = 100;
            //this.img = img;
            this.cne.Text = cne;
            this.nom.Text = nom;
            this.prenom.Text = prenom;

            //image
            //img.Height = 50;
            //img.Width = 30;

            //cne
            this.cne.Width = 50;

            //nom
            this.nom.Width = 50;

            //prenom
            this.prenom.Width = 50;



            //WrapPanel for image and StackedPanel of informations
            WrapPanel wPanel = new WrapPanel();
            wPanel.Height = 100;
            wPanel.Width = 50;
            wPanel.Background = Brushes.Red;

            StackPanel sPanel = new StackPanel();
            
            //wPanel.Children.Add(img);
            sPanel.Children.Add(this.cne);
            sPanel.Children.Add(this.prenom);
         
            this.Children.Add(wPanel);
            this.Children.Add(sPanel);
        }
    }
}
