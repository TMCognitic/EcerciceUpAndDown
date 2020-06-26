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

namespace ExerciceUpAndDown
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Value { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Value = 1;
            TBValue.Text = Value.ToString();
        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            if (!DecrementButton.IsEnabled)
                DecrementButton.IsEnabled = true;

            if (Value < 9)
            {
                Value++;
                TBValue.Text = Value.ToString();
            }

            if (Value == 9)
                IncrementButton.IsEnabled = false;

        }

        private void DecrementButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IncrementButton.IsEnabled)
                IncrementButton.IsEnabled = true;

            if (Value > 0)
            {
                Value--;
                TBValue.Text = Value.ToString();
            }

            if (Value == 0)
                DecrementButton.IsEnabled = false;
        }
    }
}
