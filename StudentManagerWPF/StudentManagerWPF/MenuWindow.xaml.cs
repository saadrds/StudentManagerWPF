﻿using System;
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
using System.Windows.Shapes;

namespace StudentManagerWPF
{
    /// <summary>
    /// Logique d'interaction pour MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        //int valueButton = 1;
        public MenuWindow()
        {
            InitializeComponent();
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
            EditWindow edit = new EditWindow();
            edit.Show();
            this.Close();
           
           
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

       

        
    }
}
