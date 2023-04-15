using bills.Models;
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

namespace bills
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        BillDataModel _model;
        Seans _seans;

        public AddWindow(BillDataModel model, Seans editedSeans)
        {
            
            InitializeComponent();
            _model = model;
            _seans = editedSeans;

            Zal.SelectedItem = _seans.Zal;
            FilmCB.SelectedIndex = _seans.FilmId;
            tbCost.Text = _seans.Cost.ToString();
            DatePicker.SelectedDate = _seans.Date;


            FilmCB.ItemsSource = model.Films.ToArray();
            Zal.ItemsSource = model.Zals.ToArray();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(_seans == null)
            {
                Add();
            }
            else
            {
                Update();
            }
            Close();
        }

        private void Update()
        {
           
            var seansToUpdate = _model.Seanses.Find(_seans.Id);
            seansToUpdate.Zal = (Zal)Zal.SelectedItem;
            seansToUpdate.Cost = int.Parse(tbCost.Text);
            seansToUpdate.Film = (Film)FilmCB.SelectedItem;
            seansToUpdate.Date = (DateTime)DatePicker.SelectedDate;
            _model.SaveChanges();
        }
        private void Add()
        {
            _seans = new Seans();

            _seans.Zal = (Zal)Zal.SelectedItem;
            _seans.Cost = int.Parse(tbCost.Text);
            _seans.Film = (Film)FilmCB.SelectedItem;
            _seans.Date = (DateTime)DatePicker.SelectedDate;
            _model.Seanses.Add(_seans);
            _model.SaveChanges();
        }
    }


}
