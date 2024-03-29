﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FirstApi.Services;
using FirstApi.Views;

namespace FirstApi
{
    public partial class App : Application
    {
        public static TodoManager TodoManager { get; set; }
        public App()
        {
            InitializeComponent();
            TodoManager = new TodoManager(new RestService());
            MainPage = new NavigationPage(new TodoListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
