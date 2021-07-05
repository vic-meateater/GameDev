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

namespace EX_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r;
        Stack<string> stack = new Stack<string>();
        public MainWindow()
        {
            InitializeComponent();
            btnCommand1.Content = "+1";
            btnCommand2.Content = "x2";
            btnReset.Content = "Сброс";
            btnUndo.Content = "Отменить ход";
            lblNumber.Content = "1";
            lblCount.Content = "0";
            this.Title = "Удвоитель";
            r = new Random();
        }
        int count;
        int random;
        

        private void btnCommand1_Click(object sender, RoutedEventArgs e)
        {
            count++;
            lblCount.Content = Convert.ToString(count);
            stack.Push(lblNumber.Content.ToString());
            lblNumber.Content = (Convert.ToInt32(lblNumber.Content) + 1).ToString();
            if (lblNumber.Content.ToString() == random.ToString()) MessageBox.Show($"ГГ ВП","WINNER!");
        }

        private void btnCommand2_Click(object sender, RoutedEventArgs e)
        {
            count++;
            lblCount.Content = Convert.ToString(count);
            stack.Push(lblNumber.Content.ToString());
            lblNumber.Content = (Convert.ToInt32(lblNumber.Content) * 2).ToString();
            if (lblNumber.Content.ToString() == random.ToString()) MessageBox.Show($"ГГ ВП", "WINNER!");
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lblCount.Content = "0";
            lblNumber.Content = "0";
            count = 0;
        }

        private void NewGameClick(object sender, RoutedEventArgs e)
        {
            random = r.Next(10, 30);
            MessageBox.Show($"{random}","Сыграем?");
            
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            count++;
            lblCount.Content = Convert.ToString(count);
            lblNumber.Content = stack.Peek().ToString();
        }
    }
}
