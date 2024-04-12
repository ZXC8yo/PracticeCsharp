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

namespace Task2
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double y = int.Parse(TextBox2.Text);
            double x = int.Parse(TextBox1.Text);
            double z = int.Parse(TextBox3.Text);

            TextBox4.Text = Solution(x, y, z).ToString();


        }


        private double Solution(double x, double y, double q)
        {
            double answer = 0;
            if (Math.Abs(x * q) > 10)
                answer = Math.Log(Math.Abs(F(x) + Math.Abs(q)));
            if (Math.Abs(x * q) < 10)
                answer = Math.Pow(Math.E, F(x) + 9);
            if (Math.Abs(x * q) == 10)
                answer = F(x) + q;
            return answer;
        }

        private double F(double x)
        {
            return (Math.Cos(x));
        }

       
    }
}
