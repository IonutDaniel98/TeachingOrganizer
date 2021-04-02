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
using TeachingOrganizerDesktopApp.ViewModels;

namespace TeachingOrganizerDesktopApp.Views
{
    /// <summary>
    /// Interaction logic for CoursesView.xaml
    /// </summary>
    public partial class CoursesView : UserControl
    {
        public CoursesView()
        {
            InitializeComponent();
        }

        private void UpdateCourseButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new CoursesViewModel();
        }

        private void DeleteCourseButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new CoursesViewModel();
        }
    }
}
