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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Calc();
        }

        private void Sabiranje(object sender, RoutedEventArgs e)
        {
            if (DataContext is Calc c)
            {
                c.Sabiranje();
                MessageBox.Show(c.Rezultat.ToString());
            }
        }
        private void Oduzimanje(object sender, RoutedEventArgs e)
        {
            if (DataContext is Calc c)
            {
                c.Oduzimanje();
                MessageBox.Show(c.Rezultat.ToString());
            }
        }
        private void Mnozenje(object sender, RoutedEventArgs e)
        {
            if (DataContext is Calc c)
            {
                c.Mnozenje();
                MessageBox.Show(c.Rezultat.ToString());
            }
        }
        private void Deljenje(object sender, RoutedEventArgs e)
        {
            if (DataContext is Calc c)
            {
                c.Deljenje();
                MessageBox.Show(c.Rezultat.ToString());
            }
        }
        private void Modul(object sender, RoutedEventArgs e)
        {
            if (DataContext is Calc c)
            {
                c.Modul();
                MessageBox.Show(c.Rezultat.ToString());
            }
        }
    }
}
