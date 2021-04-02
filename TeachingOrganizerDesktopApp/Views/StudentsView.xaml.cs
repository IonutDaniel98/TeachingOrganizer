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
using TeachingOrganizerDesktopApp.Service;
using TeachingOrganizerDesktopApp.ViewModels;

namespace TeachingOrganizerDesktopApp.Views
{
    /// <summary>
    /// Interaction logic for StudentsView.xaml
    /// </summary>
    public partial class StudentsView : UserControl
    {
        public StudentsView()
        {
            InitializeComponent();
        }

        private void UpdateStudentButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new StudentsViewModel();
        }

        private void DeleteStudentButton_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", "My App", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    StudentService.DeleteStudent(1);
                    MessageBox.Show("The student was deleted!");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("The student was not deleted!");
                    break;
            }
            DataContext = new StudentsViewModel();
        }
    }
}
