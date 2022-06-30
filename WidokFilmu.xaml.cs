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

namespace Zadanie3_Adam_Piatkowski
{
    /// <summary>
    /// Interaction logic for WidokFilmu.xaml
    /// </summary>
    public partial class WidokFilmu : Window
    {
        public WidokFilmu(Film film)
        {
            DataContext = film;
            InitializeComponent();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
