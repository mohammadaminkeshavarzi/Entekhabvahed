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

namespace Entekhab_Vahed_Wpf
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

        private void btnProff_Click(object sender, RoutedEventArgs e)
        {
            new Professor().ShowDialog();
        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            new Student().ShowDialog();
        }

        private void btnLesson_Click(object sender, RoutedEventArgs e)
        {
            new Lesson().ShowDialog();
        }

        private void btnClass_Click(object sender, RoutedEventArgs e)
        {
            new Classes().ShowDialog();
        }

        private void btnField_Click(object sender, RoutedEventArgs e)
        {
            new Field().ShowDialog();
        }

        private void btnScore_Click(object sender, RoutedEventArgs e)
        {
            new Scores().ShowDialog();
        }

        private void btnChU_Click(object sender, RoutedEventArgs e)
        {
            new ChUnit().ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
