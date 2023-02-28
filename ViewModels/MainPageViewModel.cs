using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MauiDemoAppMVVM.ViewModels
{
    public partial class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            Text = "Click here!";
        }

        int count = 0;

        [ObservableProperty]
        private string text;

        [RelayCommand]
        private void CounterClicked()
        {
            count++;

            if (count == 1)
                Text = $"Clicked {count} time";
            else
                Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(Text);
        }
    }
}
