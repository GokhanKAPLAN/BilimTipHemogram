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
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.kullaniciAdi = txtKullaniciAdi.Text;
            // Could you remove this line please
            //this.Visibility = Visibility.Hidden;
            MainWindow.kl.lblDeneme.Content = txtKullaniciAdi.Text;
            //MainWindow.fr.Navigate(MainWindow.kl);

            //Sonuc Listesi icin
            MainWindow.fr.Navigate(MainWindow.sonucList);
        }
    }
}
