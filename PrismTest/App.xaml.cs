﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DryIoc;
using Prism.DryIoc;
using PrismTest.Services;
using PrismTest.Views;
using Xamarin.Forms;

namespace PrismTest
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Enter%20text%20below%20to%20generate%20PDF");
        }

        protected override void RegisterTypes()
        {
            
            Container.Register<IPdfHelper, PdfHelper>();

            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SecondPage>();
        }
    }
}

