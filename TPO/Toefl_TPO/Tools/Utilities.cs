using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Toefl_TPO.Tools
{
    public static class Utilities
    {
        public static void Log<T>(this T value) => MessageBox.Show(value.ToString());

        public static string CreateProjectDirectory(string name)
        {
            var directory = new DirectoryInfo(@".");

            if (directory.Exists)
            {
                directory.CreateSubdirectory($"Resources\\Tests\\{name}");
                directory.CreateSubdirectory($"Resources\\Tests\\{name}\\Reading");
                directory.CreateSubdirectory($"Resources\\Tests\\{name}\\Listening");
                directory.CreateSubdirectory($"Resources\\Tests\\{name}\\Speaking");
                directory.CreateSubdirectory($"Resources\\Tests\\{name}\\Writing");
            }

            return $".\\Resources\\Tests\\{name}";
        }

        public static void CreateTxtFile(string path, string name)
        {
            try
            {
                var file = new FileInfo(path + "\\" + name + ".txt");
                file.CreateText();
            }
            catch (Exception ex)
            {
                ex.Message.Log();
            }
        }



    }
}