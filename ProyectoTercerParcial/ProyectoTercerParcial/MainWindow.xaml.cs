using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProyectoTercerParcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

        }

        private void CbSEPE_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdagregar.Children.Clear();
        }

        private void Btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            switch(cbSEPE.SelectedIndex)
            {
                case 0:
                    grdagregar.Children.Add(new Serie());
                    break;
                case 1:
                    grdagregar.Children.Add(new Pelicula());
                    break;
                default:
                    break;
            }                   
        }

        private void Listdatos_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
           
        }
    }
}
