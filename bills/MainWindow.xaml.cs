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

namespace bills
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nameCB.ItemsSource = new Cinema[]
            {
                new Cinema{ Name = "Москва", Description = "Some Cinema" },
                new Cinema{ Name = "Заря", Description = "Some Cinema" },
                new Cinema{ Name = "Дружба", Description = "Some Cinema" }, 
            };
            nameCB.SelectedIndex = 0;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (nameCB.SelectedIndex == 0)
            {
                
            }
        }
    }
}
public class Cinema
{
    public string Name { get; set; }
    public string Description { get; set; }
    public override string ToString() => $"{Name} ({Description})";
}
