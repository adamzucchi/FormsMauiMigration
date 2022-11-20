using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using FreshMvvm.Maui;
using FormsMauiMigration.PageModels;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Services;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace FormsMauiMigration
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            Page page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            FreshNavigationContainer freshNavigationContainer = new FreshNavigationContainer(page);

            MainPage = freshNavigationContainer;
        }

        protected override void OnStart ()
        {
            AppCenter.Start("ios=1a7cdabe-8b83-4692-88d5-98a954335f43;" + "android=4ca485e7-b276-43b4-a2eb-4cddabf2c0c5;", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}