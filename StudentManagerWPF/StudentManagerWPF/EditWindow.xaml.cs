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
using System.Windows.Shapes;

namespace StudentManagerWPF
{
    /// <summary>
    /// Logique d'interaction pour EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            menu.Show();
            this.Close();

        }
        private void Close(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }
        
        private void TabablzControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button1ere_Click(object sender, RoutedEventArgs e)
        {
           // valueButton = 1;
            Button1ere.Background = new SolidColorBrush(Color.FromRgb(32, 0, 255));
            Button2eme.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
            Button3eme.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
        }

        private void Button2eme_Click(object sender, RoutedEventArgs e)
        {
            //valueButton = 2;
            Button2eme.Background = new SolidColorBrush(Color.FromRgb(32, 0, 255));
            Button1ere.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
            Button3eme.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
        }

        private void Button3eme_Click(object sender, RoutedEventArgs e)
        {
         //   valueButton = 3;
            Button3eme.Background = new SolidColorBrush(Color.FromRgb(32, 0, 255));
            Button2eme.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
            Button1ere.Background = new SolidColorBrush(Color.FromRgb(114, 167, 218));
        }

    }
}
