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
using UniversitySystem;
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (var currentChild in mainGrid.Children) 
            {
                if (currentChild is TextBox) 
                {
                    ((TextBox)currentChild).Text = Environment.NewLine;
                
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Student student = StudentData.TestStudents[0];
            firstNameText.Text = student.FirstName;
            middleNameText.Text = student.MiddleName;
            lastNameText.Text = student.LastName;
            facultyText.Text = student.Faculty;
            specialtyText.Text = student.Specialty;
            degreeText.Text = student.Degree;
            statusText.Text = student.status.ToString();
            facultyNumberText.Text = student.FacultyNumber;
            courseText.Text = student.Course.ToString();
            flowText.Text = student.Flow.ToString();
            groupText.Text = student.Group.ToString();
            

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (var currentChild in mainGrid.Children)
            {
                if (currentChild is TextBox)
                {
                    ((TextBox)currentChild).IsEnabled = false;

                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
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
