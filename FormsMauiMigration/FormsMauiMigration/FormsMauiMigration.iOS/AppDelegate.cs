using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using FormsMauiMigration.Interfaces;
using FormsMauiMigration.Data;
using FormsMauiMigration.Services;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace FormsMauiMigration.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}

