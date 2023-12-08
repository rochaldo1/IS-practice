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
using System.Windows.Shapes;
using IS_practise_7.ViewModel;
using IS_practise_7.ViewModel.DataManager;

namespace IS_practise_7.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDataManager dataManager;
        public MainWindow(IDataManager dataManager)
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            DataContext = new MainVM(this.dataManager = dataManager);

            if(DataContext is MainVM mainVM){
                mainVM.FileReader += OpenReadFileWindow;
            }
        }

        private void OpenReadFileWindow(string text)
        {
            ReadFileWindow readFileWindow = new ReadFileWindow(text);
            readFileWindow.Show();
        }

        private void RollUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();
        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();
    }
}
