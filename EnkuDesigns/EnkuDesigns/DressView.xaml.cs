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

namespace EnkuDesigns
{
    /// <summary>
    /// Interaction logic for DressView.xaml
    /// </summary>
    public partial class DressView : Window
    {
        public DressView(String piclocation)
        {
            InitializeComponent();
            
            dpic.Source = new BitmapImage(new Uri(piclocation)); 
                
        }
    }
}
