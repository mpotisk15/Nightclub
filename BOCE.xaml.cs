using System;
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
    public sealed partial class BOCE : Page
    {
        public BOCE()
        {
            this.InitializeComponent();
        }
        public void JD05_Click(object sender, RoutedEventArgs e)
        {
            JD.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(440);
            Suma.Text = Convert.ToString(zbroj);

        }

        private void Jam_Click(object sender, RoutedEventArgs e)
        {
            jam.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(500);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void Beluga_Click(object sender, RoutedEventArgs e)
        {
            beluga.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(290);
            Suma.Text = Convert.ToString(zbroj);
        }

        private void Dubliner_Click(object sender, RoutedEventArgs e)
        {
            dubliner.Text = "x";
            Int64 zbroj = Convert.ToInt64(Suma.Text) + Convert.ToInt64(300);
            Suma.Text = Convert.ToString(zbroj);
        }
        private void pay_Click(object sender, RoutedEventArgs e)
        {
            Suma.Text = "0";
            dubliner.Text = " ";
            beluga.Text = " ";
            jam.Text = " ";
            JD.Text = " ";
        }
    }


}

