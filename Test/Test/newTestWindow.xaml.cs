﻿using System;
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
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// Interaction logic for newTestWindow.xaml
    /// </summary>
    public partial class newTestWindow : Window
    {
        public newTestWindow()
        {
            InitializeComponent();
        }

        private void Creat_clk(object sender, RoutedEventArgs e)
        {
            //создаем куда то сохраняем...
            this.Close();
        }
    }
}
