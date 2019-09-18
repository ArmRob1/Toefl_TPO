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
namespace Toefl_TPO.Pages
{
    public partial class Tests : Page
    {
        public Tests()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DefaultWindow dw = new DefaultWindow();
            Edit edit = new Edit();
            dw.Content = edit.Content;
            dw.Title = edit.Title;
            dw.Owner = Window.GetWindow(this);
            dw.Show();
        }
    }
}