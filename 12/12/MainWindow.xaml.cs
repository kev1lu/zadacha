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

namespace _12
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

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            double[] arr = number.Text.Split(' ').Select(x => double.Parse(x)).ToArray();
            int b = 0;
            double[] brr = new double[arr.Length]; 
            double res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    break;
                } else
                {
                    if(arr[i] < 0)
                    {
                        brr[b] += arr[i];
                        b += 1;
                    }
                }
            }
            for (int a = 0; a < b; a++)
            {
                res += brr[a];
            }
            res = res / b;
            MessageBox.Show("Среднее арефметическое отрицательных чисел до нуля = " + res);
        }
    }
}
