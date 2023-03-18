using MauiDemoAppMVVM.Views;

namespace MauiDemoAppMVVM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
		Routing.RegisterRoute(nameof(Page2View), typeof(Page2View));
	}
}
