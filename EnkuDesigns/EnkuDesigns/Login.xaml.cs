using EnkuDesigns.Models;
using EnkuDesigns.Utility;
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

namespace EnkuDesigns
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginn(object sender, RoutedEventArgs e)
        {
            using (EnkuDesignDBContext context = new EnkuDesignDBContext())
            {
                List<User> users = context.Users.ToList();
                bool userFound = false;

                foreach (User userData in users)
                {
                    if (userData.username.ToString().Equals(UserNameTextBlock.Text.ToString()) && userData.password.ToString().Equals(passwordTextBlock.Password.ToString()))
                    {
                        userFound = true;
                        Window MainWindow = new MainWindow();
                        MainWindow.Show();
                        this.Close();
                        UserNameValidateTextBlock.Text = "";
                        PasswordValidateTextBlock.Text = "";
                        break;
                    }
                }

                if (userFound.Equals(false))
                {
                    UserNameValidateTextBlock.Text = "Incorrect Input!!";
                    PasswordValidateTextBlock.Text = "Incorrect Input!!";
                }
            }
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
