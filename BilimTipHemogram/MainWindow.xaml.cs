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
using System.IO.Ports;
using System.Threading;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;

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
        public SerialPort mySerialPort;        



        public MainWindow()
        {
            InitializeComponent();
            mySerialPort = new SerialPort(SerialPort.GetPortNames()[0]);
            CihazYoneticisi yonetici = new CihazYoneticisi(mySerialPort);
        }
    }     
}
