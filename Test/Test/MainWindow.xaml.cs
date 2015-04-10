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
using System.IO;
using Microsoft.Win32;

namespace Test
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

        private void NewTest_clk(object sender, RoutedEventArgs e)
        {
            newTestWindow newTestW = new newTestWindow();
            newTestW.ShowDialog();
        }

        private void Save_as_clk(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
        }

        private void Open_clk(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() ==true)
            {
                ofd.OpenFile();
                (new passWindow()).ShowDialog();
            }
        }

        private void Exit_clk(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
