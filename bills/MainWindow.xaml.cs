using bills.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace bills
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BillDataModel model = new BillDataModel();
        public MainWindow()
        {
            InitializeComponent();

            model.Films.ToArray();
            
            CinemasCB.ItemsSource= model.Cinemas.ToArray();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            int FID = FilmCB.SelectedIndex;
            int Zal = LB.SelectedIndex;
            var Sseans = model.Seanses.Where(s => s.ZalId == Zal && s.FilmId == FID);

            
            dgRas.ItemsSource = Sseans.ToArray();
            


        }

        private void CinemasCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilmCB.ItemsSource = model.Films.ToArray();
            
            //var FImage = (Film)FilmCB.SelectedItem;


            //var Seans = SSeans.Where(s => s.)

            //tbr.Text = ;

            //for (int i = 0; i < SZals.Length; i++) 
            //{

            //    LB.Items.Add(SZals[i]);

            //}
            //int ID = LB.SelectedIndex;

            //var Seanses = model.Seanses.Where(s => s.ZalId == ID).ToArray();


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FilmCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow(model, null);
            addWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow(model, _selectedSeans);
            addWindow.Show();
        }

        Seans _selectedSeans;
        private void dgRas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedSeans = dgRas.SelectedItem as Seans;
        }
    }
}
