using BilimTipHemogram.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static KullaniciListesi kl = new KullaniciListesi();
        public static LoginControl lc = new LoginControl();
        public static string kullaniciAdi;
        public static Frame fr;

        //Sonuc Listesi sayfalari
        public static SonucListesi sonucList = new SonucListesi();
        public static OlcumSonuc olcumSonuc = new OlcumSonuc();
       // public static 

        public MainWindow()
        {
            InitializeComponent();

            //clsOlcumSonucDbContext Veri = new clsOlcumSonucDbContext();
            //Veri.Database.Create();

            fr = mainFrame;
            mainFrame.Navigate(lc);

        }
    }
}
