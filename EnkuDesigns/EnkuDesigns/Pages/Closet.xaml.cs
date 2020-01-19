using EnkuDesigns.Models;
using EnkuDesigns.Utility;
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

namespace EnkuDesigns.Pages
{
    /// <summary>
    /// Interaction logic for Closet.xaml
    /// </summary>
    public partial class Closet : UserControl
    {
        String picturelocation;
        EnkuDesignDBContext mydb = new EnkuDesignDBContext();
        public Closet()
        {

            InitializeComponent();
            LoadData();
        }

        private void AddDressButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Dress dress = new Dress
                {
                    Id = Int32.Parse(dresscode.Text.ToString()),
                    Price = Double.Parse(price.Text.ToString()),
                    Amount = Int32.Parse(Amount.Text.ToString()),
                    Description = Description.Text.ToString(),
                    PicLocation = picturelocation.ToString()
                };
                mydb.Dresses.Add(dress);
                mydb.SaveChanges();
                LoadData();
            }
            catch (Exception) { }
        }

        private void FileChooserClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.DefaultExt = ".png";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                Nullable<bool> result = dlg.ShowDialog();
                String filename = dlg.InitialDirectory + dlg.FileName;

                picturelocation = filename;
                ImageLocationTextBox.Text = filename;
            }
            catch (Exception) { }

        }

        public void LoadData()
        {
            try
            {
                using (EnkuDesignDBContext endb = new EnkuDesignDBContext())
                {
                    Thelistbox.ItemsSource = null;
                    Thelistbox.ItemsSource = endb.Dresses.ToList();
                }
            }
            catch (Exception) { }
        }

        private void DressClicked(object sender, MouseButtonEventArgs e)
        {
            DressCardUserControl selectedDress = (DressCardUserControl)sender;
            String dresspiclocation = selectedDress.dresspic.Source.ToString();
            Console.WriteLine($"{selectedDress.dresspic.Source.ToString()}");
            Window w = new DressView(dresspiclocation);
            w.Show();
            w.Topmost = true;
        }
    }
}
