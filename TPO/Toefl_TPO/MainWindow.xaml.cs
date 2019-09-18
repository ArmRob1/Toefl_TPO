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
using Toefl_TPO.Pages;
using Toefl_TPO.Tools;
namespace Toefl_TPO
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            DefaultWindow dw = new DefaultWindow();
            Tests tests = new Tests();
            dw.Content = tests;
            dw.Title = tests.Title;
            dw.Owner = this;
            dw.Show();
        }
    }
}