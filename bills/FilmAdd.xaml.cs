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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Film _film;
        BillDataModel _model;
        public Window2(BillDataModel model, Film film)
        {
            _film = film;
            _model = model;
            InitializeComponent();
            if (film != null) 
            {
                FilmName.Text = film.FilmName.ToString();
                FilmDuration.Text = film.Duration.ToString();
                FilmPath.Text = film.ImagePath.ToString();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int duration = Convert.ToInt32(FilmDuration.Text);
            _film.FilmName = FilmName.Text;
            _film.Duration = duration;
            _film.ImagePath = FilmPath.Text;
            _model.Films.Add(_film);
            _model.SaveChanges();
            Close();
        }
    }
}
