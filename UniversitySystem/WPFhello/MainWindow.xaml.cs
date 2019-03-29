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

namespace WPFhello
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String userInput = txtName.Text;
            if (userInput.Length > 2)
            {
                MessageBox.Show("Hello, " + txtName.Text + "!!!\nThis is your first VS 2012 program!");
            }
            else { 
                MessageBox.Show("Username must be at least 2 characters long!"); 
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String factorial = factorialInput.Text;
            long factorialValue = long.Parse(factorial);
            long result = calculateFactorial(factorialValue);
            MessageBox.Show("Factorial of "+factorial+" is "+result+"."); 
        }
        long calculateFactorial(long number) 
        {
            long result = 1;
            for (int i = 1; i <= number; i++) 
            {result *= i;}
            return result;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            String baseNumber = factorialInput.Text;
            String power = powerInput.Text;
            long baseValue = long.Parse(baseNumber);
            long powerValue = long.Parse(power);
            double result = Math.Pow(baseValue, powerValue);
            MessageBox.Show(baseValue+"^"+powerValue+" = "+result); 

        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;

            }
            else { e.Cancel = false; }
            base.OnClosing(e);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            StringBuilder messageBuilder = new StringBuilder();
            foreach (var item in MainGrid.Children) 
            {
                if (item is TextBox) 
                {
                    messageBuilder.Append(((TextBox)item).Text).Append(Environment.NewLine);
                }
            }
            messageBuilder.Append("Welcome!");
            MessageBox.Show(messageBuilder.ToString());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, Windows Presentation Foundation!");
            textBlock1.Text = DateTime.Now.ToString();
        }
       
       
    }
}
