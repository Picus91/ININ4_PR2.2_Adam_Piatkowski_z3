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

namespace NET_ININ4_PR2._2_z4
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        public MainWindow()
        {
            DataContext = model;
            InitializeComponent();
        }

        private void Szczegóły(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)this.FindName("ListaOsób");
            Osoba wybrana = (Osoba)lista.SelectedItem;
            if(wybrana!=null)
                new WidokOsoby(wybrana).Show();
        }
    }
}
