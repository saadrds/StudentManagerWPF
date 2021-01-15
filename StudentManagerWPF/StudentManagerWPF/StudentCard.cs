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
<<<<<<< HEAD
    class StudentCard:WrapPanel
    {
        //Image img;
=======
    class StudentCard : WrapPanel
    {
        Image img;
>>>>>>> main
        TextBlock cne = new TextBlock();
        TextBlock nom = new TextBlock();
        TextBlock prenom = new TextBlock();

<<<<<<< HEAD
        public StudentCard(String cne, String nom, String prenom)
        {
            this.Height = 200;
            this.Width = 100;
            //this.img = img;
=======
        public StudentCard(String imgSource, String cne, String nom, String prenom)
        {
            Thickness currentMargin = this.Margin;
            currentMargin.Left = 15;
            this.Margin = currentMargin;
            this.Height = 180;
            this.Width = 150;
            this.img = new Image();
>>>>>>> main
            this.cne.Text = cne;
            this.nom.Text = nom;
            this.prenom.Text = prenom;

            //image
<<<<<<< HEAD
            //img.Height = 50;
            //img.Width = 30;

            //cne
            this.cne.Width = 50;

            //nom
            this.nom.Width = 50;

            //prenom
            this.prenom.Width = 50;
=======
            img.Height = 80;
            img.Width = 80;
            img.Source = new ImageSourceConverter().ConvertFromString(imgSource) as ImageSource;

            //cne
            //this.cne.Width = 80;
            this.cne.FontSize = 10;
            TextBlock lcne = new TextBlock();
            lcne.Text = "cne : ";
            lcne.FontSize = 9;



            //nom
            //this.nom.Width = 80;
            this.nom.FontSize = 10;
            TextBlock lnom = new TextBlock();
            lnom.Text = "nom : ";
            lnom.FontSize = 9;
            



            //prenom
            //this.prenom.Width = 80;
            this.prenom.FontSize = 10;
            TextBlock lprenom = new TextBlock();
            lprenom.Text = "prenom :";
            lprenom.FontSize = 9;
>>>>>>> main



            //WrapPanel for image and StackedPanel of informations
            WrapPanel wPanel = new WrapPanel();
            wPanel.Height = 100;
<<<<<<< HEAD
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
=======
            wPanel.Width = 100;


            //definitions
            StackPanel definitions = new StackPanel();
            definitions.Children.Add(lcne);
            definitions.Children.Add(lprenom);
            definitions.Children.Add(lnom);

            //Values
            StackPanel values = new StackPanel();
            values.Children.Add(this.cne);
            values.Children.Add(this.prenom);
            values.Children.Add(this.nom);

            //adding informations and values to the wrapPanel
            WrapPanel wPanel2 = new WrapPanel();
            wPanel2.Children.Add(definitions);
            wPanel2.Children.Add(values);
            Thickness valuesMargin = values.Margin;
            valuesMargin.Left= 5;
            values.Margin = valuesMargin;

            //adding image
            wPanel.Children.Add(img);
            
           
            

            this.Children.Add(wPanel);
            this.Children.Add(wPanel2);

            
        }
    }
}
>>>>>>> main
