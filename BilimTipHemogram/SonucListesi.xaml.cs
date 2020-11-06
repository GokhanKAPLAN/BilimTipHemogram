using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BilimTipHemogram
{
    /// <summary>
    /// Interaction logic for KullaniciListesi.xaml
    /// </summary>
    public partial class SonucListesi : UserControl
    {
        public SonucListesi()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.fr.GoBack();
        }

        private void btnYeni_Click(object sender, RoutedEventArgs e)
        {
          MainWindow.fr.Navigate(MainWindow.olcumSonuc);
        }
    }
}
