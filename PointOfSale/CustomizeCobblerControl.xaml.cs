using ExamTwoCodeQuestions.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void PeachButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler c)
            {
                c.Fruit = FruitFilling.Peach;
                PeachButton.IsEnabled = false;
                CherryButton.IsEnabled = true;
                BlueBerryButton.IsEnabled = true;
            }
        }

        private void CherryButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler c)
            {
                c.Fruit = FruitFilling.Cherry;
                PeachButton.IsEnabled = true;
                CherryButton.IsEnabled = false;
                BlueBerryButton.IsEnabled = true;
            }
        }

        private void BlueBerryButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler c)
            {
                c.Fruit = FruitFilling.Blueberry;
                PeachButton.IsEnabled = true;
                CherryButton.IsEnabled = true;
                BlueBerryButton.IsEnabled = false;
            }
        }

        private void WithIceCream_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler c)
            {
                c.WithIceCream = !(c.WithIceCream);
            }
        }
    }
}
