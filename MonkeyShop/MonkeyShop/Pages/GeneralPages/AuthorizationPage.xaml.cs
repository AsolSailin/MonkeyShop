﻿using MonkeyShop.Classes;
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

namespace MonkeyShop.Pages.GeneralPages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void AuthoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text != "" && tbPassword.Password != "")
            {
                var data = App.Connection.Account.Where(x => x.Password == tbPassword.Password
                && x.Login == tbLogin.Text).FirstOrDefault();
                if (data != null)
                {
                    NavClass.NextPage(new NavComponentsClass(new RegistrationPage()));
                }
                else
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill login and password please!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            NavClass.NextPage(new NavComponentsClass(new RegistrationPage()));
        }
    }
}