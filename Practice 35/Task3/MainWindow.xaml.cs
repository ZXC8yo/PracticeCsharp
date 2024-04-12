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

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const double b = 3.2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = int.Parse(TextBox2.Text);
            double x = int.Parse(TextBox1.Text);

            TextBox4.Text = FindY(x, a).ToString();


        }


        private double FindY(double x, double b)
        {
            return  x * Math.Sin(Math.Sqrt(x + b - 0.0084));
        }

       
    }
}
