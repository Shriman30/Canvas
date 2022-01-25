using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Boolean draw = false;
        public static double x_coordinate, y_coordinate = 0; // represents the point from where we would like to draw
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cnv_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            draw = !draw; // we can flip the value of draw at every click
            x_coordinate = e.GetPosition(cnv).X;
            y_coordinate = e.GetPosition(cnv).Y;
        }

        private void cnv_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Line line = new Line();
                line.X1 = x_coordinate;
                line.Y1 = y_coordinate;
                line.X2 = e.GetPosition(cnv).X;
                line.Y2= e.GetPosition(cnv).Y;
                line.StrokeThickness = 2;
                line.Stroke = Brushes.Brown;
                cnv.Children.Add(line);
            }
        }
    }
}
