﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImagemAcao
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ImagemAcao.View.Inicio());
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
