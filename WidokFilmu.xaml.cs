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

namespace NET_ININ4_PR2._2_z4
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
