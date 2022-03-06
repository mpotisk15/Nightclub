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
using Windows.Media;
using Windows.UI;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nightclub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RezervacijeRESET : Page
    {
        public RezervacijeRESET()
        {
            this.InitializeComponent();
            elipsa2load();
            elipsa2_Copyload();
            elipsa2_Copy1load();
            elipsa2_Copy2load();
            elipsa2_Copy3load();
            elipsa2_Copy4load();
            elipsa2_Copy5load();
            elipsa2_Copy6load();
            elipsa2_Copy7load();
            elipsa2_Copy8load();
            elipsa2_Copy9load();

        }
        private string imerezervacije(string imestola)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values[imestola] as string;
            if (localValue == null)
            {
                return " ";
            }
            return localValue;
        }
        private void imerezervacije(string imestola, string ime)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values[imestola] = ime;
        }
        private void elipsa2_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void elipsa2_Copy_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy1_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy2_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy3_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy4_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy5_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy6_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy7_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy8_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2_Copy9_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void elipsa2load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2.Fill = abc;
            }
            elipsa2stol.Text = imerezervacije("elipsa2" + "ime");
        }
        private void elipsa2_Copyload()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy.Fill = abc;
            }
            elipsa2stol_Copy.Text = imerezervacije("elipsa2_Copy" + "ime");
        }
        private void elipsa2_Copy1load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy1"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy1.Fill = abc;
            }
            elipsa2stol_Copy1.Text = imerezervacije("elipsa2_Copy1" + "ime");
        }
        private void elipsa2_Copy2load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy2"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy2.Fill = abc;
            }
            elipsa2stol_Copy2.Text = imerezervacije("elipsa2_Copy2" + "ime");
        }
        private void elipsa2_Copy3load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy3"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy3.Fill = abc;
            }
            elipsa2stol_Copy3.Text = imerezervacije("elipsa2_Copy3" + "ime");
        }
        private void elipsa2_Copy4load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy4"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy4.Fill = abc;
            }
            elipsa2stol_Copy4.Text = imerezervacije("elipsa2_Copy4" + "ime");
        }
        private void elipsa2_Copy5load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy5"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy5.Fill = abc;
            }
            elipsa2stol_Copy5.Text = imerezervacije("elipsa2_Copy5" + "ime");
        }
        private void elipsa2_Copy6load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy6"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy6.Fill = abc;
            }
            elipsa2stol_Copy6.Text = imerezervacije("elipsa2_Copy6" + "ime");
        }
        private void elipsa2_Copy7load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy7"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy7.Fill = abc;
            }
            elipsa2stol_Copy7.Text = imerezervacije("elipsa2_Copy7" + "ime");
        }
        private void elipsa2_Copy8load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy8"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy8.Fill = abc;
            }
            elipsa2stol_Copy8.Text = imerezervacije("elipsa2_Copy8" + "ime");
        }
        private void elipsa2_Copy9load()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            String localValue = localSettings.Values["elipsa2_Copy9"] as string;
            if (localValue == "true")
            {
                SolidColorBrush abc = new SolidColorBrush();
                abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
                elipsa2_Copy9.Fill = abc;
            }
            elipsa2stol_Copy9.Text = imerezervacije("elipsa2_Copy9" + "ime");
        }

        private void gumb_rezerviraj_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2.Fill = abc;
            imerezervacije("elipsa2" + "ime", null);
            elipsa2stol.Text = " ";
        }
        private void gumb_rezerviraj1_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy.Fill = abc;
            imerezervacije("elipsa2_Copy" + "ime", null);
            elipsa2stol_Copy.Text = " ";
        }
        private void gumb_rezerviraj2_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy1"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy1.Fill = abc;
            imerezervacije("elipsa2_Copy1" + "ime", null);
            elipsa2stol_Copy1.Text = " ";
        }
        private void gumb_rezerviraj3_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy2"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy2.Fill = abc;
            imerezervacije("elipsa2_Copy2" + "ime", null);
            elipsa2stol_Copy2.Text = " ";
        }
        private void gumb_rezerviraj4_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy3"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy3.Fill = abc;
            imerezervacije("elipsa2_Copy3" + "ime", null);
            elipsa2stol_Copy3.Text = " ";
        }
        private void gumb_rezerviraj5_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy4"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy4.Fill = abc;
            imerezervacije("elipsa2_Copy4" + "ime", null);
            elipsa2stol_Copy4.Text = " ";
        }
        private void gumb_rezerviraj6_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy5"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy5.Fill = abc;
            imerezervacije("elipsa2_Copy5" + "ime", null);
            elipsa2stol_Copy5.Text = " ";
        }
        private void gumb_rezerviraj7_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy6"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy6.Fill = abc;
            imerezervacije("elipsa2_Copy6" + "ime", null);
            elipsa2stol_Copy6.Text = " ";
        }
        private void gumb_rezerviraj8_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy7"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy7.Fill = abc;
            imerezervacije("elipsa2_Copy7" + "ime", null);
            elipsa2stol_Copy7.Text = " ";
        }
        private void gumb_rezerviraj9_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy8"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy8.Fill = abc;
            imerezervacije("elipsa2_Copy8" + "ime", null);
            elipsa2stol_Copy8.Text = " ";
        }
        private void gumb_rezerviraj10_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["elipsa2_Copy9"] = "false";
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)255, (byte)0);
            elipsa2_Copy9.Fill = abc;
            imerezervacije("elipsa2_Copy9" + "ime", null);
            elipsa2stol_Copy9.Text = " ";
        }

        private void povratak_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RezervacijePAGE));
        }
    }
}
