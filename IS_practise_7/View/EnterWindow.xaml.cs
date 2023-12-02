using IS_practise_7.ViewModel;
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
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
           
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        int CountClick = 0; //Для показа пароля!
        private void Watch_Password_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((e.ChangedButton == MouseButton.Left) && ((CountClick % 2) == 0))
            {
                CountClick += 1;
                Form_Input_Password_TB.Text = Form_Input_Password_PB.Password;
                Form_Input_Password_TB.Visibility = Visibility.Visible;
                Form_Input_Password_PB.Visibility = Visibility.Hidden;
                Form_Input_Password_TB.Select(Form_Input_Password_TB.Text.Length, 0);

            }
            else
            {
                CountClick += 1;
                Form_Input_Password_PB.Password = Form_Input_Password_TB.Text;
                Form_Input_Password_PB.Visibility = Visibility.Visible;
                Form_Input_Password_TB.Visibility = Visibility.Hidden;
            }
        }

        private void RollUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }

        private void Form_Input_Password_PB_PasswordChanged(object sender, RoutedEventArgs e)
        {
            EnterViewModel enterViewModel = new EnterViewModel();
            enterViewModel.Password = Form_Input_Password_PB.Password;
        }
    }
}
