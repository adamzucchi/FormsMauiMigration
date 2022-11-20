using Microsoft.Extensions.DependencyInjection;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Services;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using FormsMauiMigration.Pages;
using FormsMauiMigration.PageModels;
using FormsMauiMigration.Data;
using FreshMvvm.Maui.Extensions;

namespace FormsMauiMigration
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>();

            builder.Services.Add(ServiceDescriptor.Singleton<ICloudService, CloudService>());

            builder.Services.Add(ServiceDescriptor.Transient<MainPage, MainPage>());
            builder.Services.Add(ServiceDescriptor.Transient<DetailPage, DetailPage>());

            builder.Services.Add(ServiceDescriptor.Transient<MainPageModel, MainPageModel>());
            builder.Services.Add(ServiceDescriptor.Transient<DetailPageModel, DetailPageModel>());

            //FreshIOC.Container.Register<ICloudService, CloudService>().AsSingleton();

            var mauiApp = builder.Build();
            mauiApp.UseFreshMvvm();

            return mauiApp;

        }
	}
}