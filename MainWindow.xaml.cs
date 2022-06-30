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

namespace Zadanie3_Adam_Piatkowski
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

       private void Edytuj(object sender, RoutedEventArgs e)
       {
           ListBox lista = (ListBox)this.FindName("ListaFilmów");
           Film wybranyFilm = (Film)lista.SelectedItem;
           if(wybranyFilm != null)
               new WidokFilmu(wybranyFilm).Show();
       }

       private void Dodaj(object sender, RoutedEventArgs e)
       {
           new WidokFilmu(model.NowyFilm()).Show();
       }
    }
}
