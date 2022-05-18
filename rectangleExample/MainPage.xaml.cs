using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace rectangleExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Ellipse exampleEllipse;
        public MainPage()
        {
            this.InitializeComponent();

            Ellipse player = addNewEllipse();
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
        }

        public Ellipse addNewEllipse()
        {
            exampleEllipse = new Ellipse();
            exampleEllipse.Fill = new SolidColorBrush(Windows.UI.Colors.SteelBlue);
            exampleEllipse.Width = 50;
            exampleEllipse.Height = 50;
            Canvas.SetLeft(exampleEllipse, 200);
            Canvas.SetTop(exampleEllipse, 200);


            // When you create a XAML element in code, you have to add
            // it to the XAML visual tree. This example assumes you have
            // a panel named 'layoutRoot' in your XAML file, like this:
            // <Grid x:Name="layoutRoot>
            layoutRoot.Children.Add(exampleEllipse);
            return exampleEllipse;
        }

        private void CoreWindow_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            if (args.VirtualKey == Windows.System.VirtualKey.Left)
            {
                Canvas.SetLeft(exampleEllipse, Canvas.GetLeft(exampleEllipse) - 1); 
            }
        }
    }
}
