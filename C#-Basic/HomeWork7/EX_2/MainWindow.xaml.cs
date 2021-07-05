/*
 2. Используя Windows Forms, разработать игру «Угадай число». 
Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
Компьютер говорит, больше или меньше загаданное число введенного.
 */

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

namespace EX_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r;
        public MainWindow()
        {
            InitializeComponent();
            r = new Random();
        }
        int count;
        int random;
        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            random = r.Next(1, 100);
            lblCount.Content = "0";
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            string txtBoxValue = txtBoxDigit.Text;
            if (txtBoxValue == random.ToString()) MessageBox.Show("Угадали!");
            if (Convert.ToInt32(txtBoxValue) > Convert.ToInt32(random))
                MessageBox.Show("Загаданное число меньше");
            else if (Convert.ToInt32(txtBoxValue) < Convert.ToInt32(random))
                MessageBox.Show("Загаданное число больше");
            count++;
            lblCount.Content = count.ToString();
        }

        private void txtBoxDigit_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
