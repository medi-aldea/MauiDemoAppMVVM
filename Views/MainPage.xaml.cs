using MauiDemoAppMVVM.ViewModels;

namespace MauiDemoAppMVVM.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}

