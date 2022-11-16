using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FreshMvvm;
using FormsMauiMigration.PageModels;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Services;

namespace FormsMauiMigration
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            RegisterIoc();

            Page page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            FreshNavigationContainer freshNavigationContainer = new FreshNavigationContainer(page);

            MainPage = freshNavigationContainer;
        }

        private void RegisterIoc()
        {
            FreshIOC.Container.Register<ICloudService, CloudService>().AsSingleton();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

