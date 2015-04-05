using System;
using System.Collections.Generic;
using System.IO;
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
using WpfParser;

namespace WFW.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string DesignerPath { get; set; }

        public string XamlFile { get; set; }



        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

       

        private void Parse(object sender, RoutedEventArgs e)
        {
            if(CheckoutPaths())
            {
                Wpf.Win2Wpf(DesignerPath,XamlFile);
                WpfText.Text = File.ReadAllText(XamlFile);
            }
        }

        private bool CheckoutPaths()
        {
            if(String.IsNullOrEmpty(DesignerPath) || String.IsNullOrEmpty(XamlFile))
            {
                MessageBox.Show("InvalidPaths");
                return false;
            }
            return true;
        }

        private void BrowseDesigner(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            var result = dlg.ShowDialog();
            if (result == true)
            {
                sender.To<Button>().Content = dlg.FileName;
                DesignerPath = dlg.FileName;
                DesignerText.Text = File.ReadAllText(DesignerPath);
            }
        }

        private void BrowseXaml(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            var result = dlg.ShowDialog();
            if (result == true)
            {
                sender.To<Button>().Content = dlg.FileName;
                XamlFile = dlg.FileName;
            }
        }
    }
}
