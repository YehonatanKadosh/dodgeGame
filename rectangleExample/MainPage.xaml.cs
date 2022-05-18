using rectangleExample.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
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
        GameBoard gameBoard;
        Ellipse pini;
        Ellipse[] enemies;
        
        public MainPage()
        {
            this.InitializeComponent();
            
            Rect windowRectangle = ApplicationView.GetForCurrentView().VisibleBounds;
            gameBoard = new GameBoard(windowRectangle.Width, windowRectangle.Height);

            pini = addNewEllipse(gameBoard.pini);
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;

            enemies = new Ellipse[10];
            for(int i = 0; i < gameBoard.enemies.Length; i++)
            {
                Enemy currentEnemy = gameBoard.enemies[i];
                enemies[i] = addNewEllipse(currentEnemy);
            }
        }

        private void CoreWindow_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {
                case VirtualKey.Left:
                    Canvas.SetLeft(pini, Canvas.GetLeft(pini) - 10);
                    gameBoard.pini._x = (int)Canvas.GetLeft(pini) - 10;
                    break;
                case VirtualKey.Right:
                    Canvas.SetLeft(pini, Canvas.GetLeft(pini) + 10);
                    gameBoard.pini._x = (int)Canvas.GetLeft(pini) + 10;
                    break;
                case VirtualKey.Up:
                    Canvas.SetTop(pini, Canvas.GetTop(pini) - 10);
                    gameBoard.pini._y = (int)Canvas.GetTop(pini) - 10;
                    break;
                case VirtualKey.Down:
                    Canvas.SetTop(pini, Canvas.GetTop(pini) + 10);
                    gameBoard.pini._y = (int)Canvas.GetTop(pini) + 10;
                    break;
            }

        }

        public Ellipse addNewEllipse(Piece piece)
        {
            Ellipse exampleEllipse = new Ellipse();

            if(piece is Player)
                exampleEllipse.Fill = new SolidColorBrush(Windows.UI.Colors.SteelBlue);
            else 
                exampleEllipse.Fill = new SolidColorBrush(Windows.UI.Colors.OrangeRed);

            exampleEllipse.Width = piece._width;
            exampleEllipse.Height = piece._height;

            Canvas.SetLeft(exampleEllipse, piece._x);
            Canvas.SetTop(exampleEllipse, piece._y);

            myCanvas.Children.Add(exampleEllipse);

            return exampleEllipse;
        }

    }
}
