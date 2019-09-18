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
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow nw = new NavigationWindow();
            nw.Content = new AnswerEditPage().Content;
            nw.ShowsNavigationUI = false;
            nw.Show();
        }
    }
}