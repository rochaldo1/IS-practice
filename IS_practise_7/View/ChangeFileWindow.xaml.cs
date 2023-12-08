using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
using IS_practise_7.ViewModel;
using IS_practise_7.ViewModel.DataManager;

namespace IS_practise_7.View
{
    /// <summary>
    /// Логика взаимодействия для ChangeFileWindow.xaml
    /// </summary>
    public partial class ChangeFileWindow : Window
    {
        private IDataManager dataManager;
        public ChangeFileWindow(IDataManager dataManager,string path, string text)
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            DataContext = new ChangeFileVM(this.dataManager = dataManager, path, text);
            InformationFile.Text = text;
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();
        private void RollUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
