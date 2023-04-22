using System;
using bills.Models;
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
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;


namespace bills
{
    
    public partial class Window1 : Window
    {   
        
        BillDataModel _model;
        Cinema cinema;
        ObservableCollection<Zal> names;


        public Window1(BillDataModel model)
        {
            _model = model;

            InitializeComponent();
            cinema = new Cinema();
            names = new ObservableCollection<Zal>();
            ZalsLB.ItemsSource = names;
        }
        
        private void AddZal(object sender, RoutedEventArgs e)
        {

            var str= Interaction.InputBox("введи что-то", "заголовок");
            Zal zal = new Zal()
            {
                ZalName = str,
            };

            names.Add(zal);
            


        }

        private void Save(object sender, RoutedEventArgs e)
        {
            
            ZalsLB.ItemsSource = cinema.Zals;
            cinema.CinemaName = Nametb.Text;
            cinema.Adresse = Adressetb.Text;

            _model.Cinemas.Add(cinema);
            _model.SaveChanges();
            Close();
        }

        private void ZalsLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Del(object sender, RoutedEventArgs e)
        {
            var a = ZalsLB.SelectedIndex;
            names.RemoveAt(a);
            
        }
    }
}
