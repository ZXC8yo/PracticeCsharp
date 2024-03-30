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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwapButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            int i = int.Parse(iTextBox.Text);
            int j = int.Parse(jTextBox.Text);

            string output = SwapCharacters(input, i, j);

            outputTextBox.Text = output;
        }

        private string SwapCharacters(string input, int i, int j)
        {
            if (i < 0 || i >= input.Length || j < 0 || j >= input.Length)
            {
                MessageBox.Show("Ошибка: некорректные значения i и j.");
                return input;
            }

            char[] charArray = input.ToCharArray();

            // Меняем местами буквы
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;

            return new string(charArray);
        }
    }
}