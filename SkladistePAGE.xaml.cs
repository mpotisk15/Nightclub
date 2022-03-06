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
    public sealed partial class SkladistePAGE : Page
    {
        public SkladistePAGE()
        {
            this.InitializeComponent();
            Skladiste_baza.izbrisi();
            pica.ItemsSource = Skladiste_baza.GetRecords();
        }

        private void button_back_Click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Skladiste_baza.izbrisi();
            Skladiste_baza.addRecord(ime.Text, Convert.ToInt64(sifra.Text), Convert.ToInt64 (kolicina.Text));
            pica.ItemsSource = Skladiste_baza.GetRecords();
        }
    }
}
