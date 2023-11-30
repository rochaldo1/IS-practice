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

namespace IS_practise_7.View
{
    /// <summary>
    /// Логика взаимодействия для EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        public EnterWindow()
        {
            InitializeComponent();
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();
        private void Navbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
              if (e.ChangedButton == MouseButton.Left) { this.DragMove(); }
        }

        
    }
}
