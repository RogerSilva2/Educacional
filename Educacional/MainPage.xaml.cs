﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace Educacional
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        User user;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Rules));
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Profile));
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Users));
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.user = e.Parameter as User;

            LoginManager.currentUser = user;

            if (user != null)
                wellcome.Text = String.Format("Bem vindo {0}", user.Name);
        }
    }
}
