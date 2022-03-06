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
    public sealed partial class BlagajnaMP : Page
    {
        public BlagajnaMP()
        {
            this.InitializeComponent();
        }
        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {

            this.CFrame.Navigate(typeof(Drinks));

            
        }
        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem item = args.SelectedItem as NavigationViewItem;

            switch (item.Name.ToString())
            {
                case "Piće":

                    this.CFrame.Navigate(typeof(Drinks));
                    break;

                case "Boce":
                    this.CFrame.Navigate(typeof(BOCE));
                    break;
                default:
                    break;
            }
        }

        private void navView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
