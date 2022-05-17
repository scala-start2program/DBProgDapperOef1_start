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


namespace Scala.Dapper1.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulatePersonen();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ActivateLeft();
        }
        private void ActivateLeft()
        {
            grpLeft.IsEnabled = true;
            grpRight.IsEnabled = false;
            btnBewaren.Visibility = Visibility.Hidden;
            btnAnnuleren.Visibility = Visibility.Hidden;
        }
        private void ActivateRight()
        {
            grpLeft.IsEnabled = false;
            grpRight.IsEnabled = true;
            btnBewaren.Visibility = Visibility.Visible;
            btnAnnuleren.Visibility = Visibility.Visible;
        }
        private void PopulatePersonen()
        {
        }
        private void ClearControls()
        {
            txtAdres.Text = "";
            txtEmail.Text = "";
            txtGemeente.Text = "";
            txtLand.Text = "";
            txtNaam.Text = "";
            txtTelefoon.Text = "";
            txtVoornaam.Text = "";
        }
        private void LstPersonen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWijzigen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBewaren_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAnnuleren_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
