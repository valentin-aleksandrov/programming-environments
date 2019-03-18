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
using UserLogin;
using StudentRepository;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(var currentChild in mainGrid.Children)
            {
                if(currentChild is TextBox)
                {
                    ((TextBox)currentChild).Text = Environment.NewLine;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Student student = StudentData.TestStudents[0];
            fNameBox.Text = student.FirstName;
            mNameBox.Text = student.MiddleName;
            lNameBox.Text = student.LastName;
            fakNumberBox.Text = student.FacNumber;
            facBox.Text = student.Faculty;
            specBox.Text = student.Speciality;
            degreeBox.Text = student.Degree;
            statusBox.Text = student.status.ToString();
            courseBox.Text = student.Course.ToString();
            flowBox.Text = student.Flow.ToString();
            groupBox.Text = student.Group.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (var currentChild in mainGrid.Children)
            {
                if (currentChild is TextBox)
                {
                    ((TextBox)currentChild).IsEnabled = false;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (var currentChild in mainGrid.Children)
            {
                if (currentChild is TextBox)
                {
                    ((TextBox)currentChild).IsEnabled = true;
                }
            }
        }
    }
}
