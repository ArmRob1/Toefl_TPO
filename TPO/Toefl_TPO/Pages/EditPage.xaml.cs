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

        private void File_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();



            //ofd.InitialDirectory = "c:\\";
            //ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //ofd.FilterIndex = 2;
            //ofd.RestoreDirectory = true;

            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    filePath = ofd.FileName;

            //    var fileStream = ofd.OpenFile();

            //    using (StreamReader reader = new StreamReader(fileStream))
            //    {
            //        fileContent = reader.ReadToEnd();
            //    }
            //}
        }
    }
}