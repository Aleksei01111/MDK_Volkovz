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

namespace MDK_Volkov.Practice_3
{
    /// <summary>
    /// Interaction logic for WinMenu.xaml
    /// </summary>
    public partial class WinMenu : Window
    {
        public WinMenu()
        {
            InitializeComponent();
        }

        public WinMenu(Window parent)
        {
            parent.Close();
            InitializeComponent();
        }
    }
}