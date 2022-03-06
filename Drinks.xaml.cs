﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nightclub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Drinks : Page
    {
        public Drinks()
        {
            this.InitializeComponent();
            
        }

       

        public void JD05_Click(object sender, RoutedEventArgs e)
        {
            JD.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(25);
            Suma.Text = Convert.ToString(zbroj);

        }

        private void Jam_Click(object sender, RoutedEventArgs e)
        {
            jam.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(25);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void Beluga_Click(object sender, RoutedEventArgs e)
        {
            beluga.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(20);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void Dubliner_Click(object sender, RoutedEventArgs e)
        {
            dubliner.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(16);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void Žuja_Click(object sender, RoutedEventArgs e)
        {
            žuja.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(15);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void Heineken_Click(object sender, RoutedEventArgs e)
        {
            heineken.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(19);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void Stella_Click(object sender, RoutedEventArgs e)
        {
            stella.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(19);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void Leff_Click(object sender, RoutedEventArgs e)
        {
            leff.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(20);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            Suma.Text = "0";
            stella.Text = " ";
            leff.Text = " ";
            heineken.Text = " ";
            žuja.Text = " ";
            dubliner.Text = " ";
            beluga.Text = " ";
            jam.Text = " ";
            JD.Text = " ";
        }
    }
}
