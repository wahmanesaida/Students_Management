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

namespace projectExam
{
    /// <summary>
    /// Logique d'interaction pour GestionEtudiantsAccueil.xaml
    /// </summary>
    public partial class GestionEtudiantsAccueil : Window
    {
        public GestionEtudiantsAccueil()
        {
            InitializeComponent();
        }
        private void Button_click(object sender, RoutedEventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            myframe.Navigate(userControl1);
        }

        private void Button_click1(object sender, RoutedEventArgs e)
        {
            Carousel2 carousel2 = new Carousel2();
            myframe.Navigate(carousel2);
        }

        private void Button_click2(object sender, RoutedEventArgs e)
        {
            Statistique st = new Statistique();
            myframe.Navigate(st);
        }
    }
}
