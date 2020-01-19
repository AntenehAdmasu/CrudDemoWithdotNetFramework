using EnkuDesigns.Pages;
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

namespace EnkuDesigns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadDefault();
        }

        private void LoadDefault()
        {

            WorkingArea.Children.Clear();
            WorkingArea.Children.Add(new Closet());
        }

        private void InfoButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        private void ClosetButtonClicked(object sender, RoutedEventArgs e)
        {
            WorkingArea.Children.Clear();
            WorkingArea.Children.Add(new Closet());
        }

        private void AppointmentButtonClicked(object sender, RoutedEventArgs e)
        {
            WorkingArea.Children.Clear();
            WorkingArea.Children.Add(new Appointments());
        }

        private void DailyTransactionButtonClicked(object sender, RoutedEventArgs e)
        {
            WorkingArea.Children.Clear();
            WorkingArea.Children.Add(new DailyTransaction());
        }

        private void NotesButtonClicked(object sender, RoutedEventArgs e)
        {
            WorkingArea.Children.Clear();
            WorkingArea.Children.Add(new MyNotes());
        }

        private void Appointments_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void logout(object sender, RoutedEventArgs e)
        {
            Window ll = new Login();
            ll.Show();
            this.Close();
        }
    }
}
