using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Data;
using FormsMauiMigration.Services;
using Microsoft.Maui;

namespace FormsMauiMigration.Droid
{
    [Activity(Label = "FormsMauiMigration", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
		{
			// this.TabLayoutResource = Resource.Layout.Tabbar;
			// this.ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);
		}
    }
}
