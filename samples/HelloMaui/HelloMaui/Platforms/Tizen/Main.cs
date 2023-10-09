using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using DeviceInfo = Mosa.UIExtensions.Common.DeviceInfo;
using DisplayResolutionUnit = Mosa.UIExtensions.Common.DisplayResolutionUnit;

namespace HelloMaui;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
        DeviceInfo.DisplayResolutionUnit = DisplayResolutionUnit.VP;
        DeviceInfo.ViewPortWidth = 1024;
		app.Run(args);
	}
}
