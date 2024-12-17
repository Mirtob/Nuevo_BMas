using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using NuevoBmas;
using NuevoBmas_Datos;

namespace NuevoBmas
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Navigate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cajas());
        }
    }
}
