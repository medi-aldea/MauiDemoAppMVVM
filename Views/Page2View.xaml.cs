using MauiDemoAppMVVM.ViewModels;

namespace MauiDemoAppMVVM.Views;

public partial class Page2View : ContentPage
{
	public Page2View(Page2ViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}