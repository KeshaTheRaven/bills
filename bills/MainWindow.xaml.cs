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
            
        }

        private void CinemasCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Cinema = (Cinema)CinemasCB.SelectedItem;

            var result = model.Zals.Where(s => s.CinemaId == Cinema.Id).ToArray();
            tbr.Text = result.ToString();


        }
    }
}
