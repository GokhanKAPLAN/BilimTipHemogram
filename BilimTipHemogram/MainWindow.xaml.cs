﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static KullaniciListesi kl = new KullaniciListesi();
        public static LoginControl lc = new LoginControl();
        public static string kullaniciAdi;
        public static Frame fr;
        public MainWindow()
        {
            InitializeComponent();
            fr = mainFrame;
            mainFrame.Navigate(lc);
            
        }
    }
}