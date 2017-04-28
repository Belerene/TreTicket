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
using System.Windows.Shapes;

namespace TreTicket
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MinimalisticWindow : Window
    {
        public double bottomMargin = 149.196;
        public MinimalisticWindow()
        {
            InitializeComponent();
        }

        private void buttonGER_Click(object sender, RoutedEventArgs e)
        {
            TextBlock txtBl = null;
            foreach (UIElement child in gridResizing.Children)
            {
                if (child is TextBlock)
                {
                    txtBl = child as TextBlock;
                    Thickness originalMargin = txtBl.Margin;
                    
                }
                else if(child is Grid)
                {
                    Grid grd = child as Grid;
                }
            }
            txtBl.TranslatePoint(new Point(0, 50), gridResizing);
        }

        private void buttonMUC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSWE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonCEE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonMEA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonNWE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonFinish_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
