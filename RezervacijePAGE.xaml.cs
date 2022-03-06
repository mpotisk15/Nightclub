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
        private void gumb_rezerviraj_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2.Fill = abc;
        }
        private void gumb_rezerviraj1_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy.Fill = abc;
        }
        private void gumb_rezerviraj2_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy1.Fill = abc;
        }
        private void gumb_rezerviraj3_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy2.Fill = abc;
        }
        private void gumb_rezerviraj4_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy3.Fill = abc;
        }
        private void gumb_rezerviraj5_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy4.Fill = abc;
        }
        private void gumb_rezerviraj6_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy5.Fill = abc;
        }
        private void gumb_rezerviraj7_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy6.Fill = abc;
        }
        private void gumb_rezerviraj8_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy7.Fill = abc;
        }
        private void gumb_rezerviraj9_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy8.Fill = abc;
        }
        private void gumb_rezerviraj10_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush abc = new SolidColorBrush();
            abc.Color = Color.FromArgb((byte)255, (byte)255, (byte)0, (byte)0);
            elipsa2_Copy9.Fill = abc;
        }
    }
}
