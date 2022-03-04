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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nightclub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RezervacijePAGE : Page
    {
        public RezervacijePAGE()
        {
            this.InitializeComponent();
        }

        private void elipsa1_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)0, (byte)0, (byte)1);
            elipsa1.Fill = abc;
        }
    }
}
