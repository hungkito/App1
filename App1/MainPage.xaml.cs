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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text_Block.Text = "len rank de";
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Button mybutton = new Button();
            mybutton.Name = "ClickMeButton";
            mybutton.Content = "Click Me";
            mybutton.Width = 200;
            mybutton.Height = 100;
            mybutton.Margin = new Thickness(20, 20, 0, 0);
            mybutton.HorizontalAlignment = HorizontalAlignment.Left;
            mybutton.VerticalAlignment = VerticalAlignment.Top;

            mybutton.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            mybutton.Click += Button_Click;
            LayoutGrind.Children.Add(mybutton);
        }
        private void Text_Block_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
