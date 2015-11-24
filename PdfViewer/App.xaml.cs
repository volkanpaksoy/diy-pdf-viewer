using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PdfViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            if (e.Args.Length > 0)
            {
                // mainWindow.FilePath = e.Args[0];
                MessageBox.Show(mainWindow.FilePath);
            }
            
            mainWindow.Show();
        }
    }
}
