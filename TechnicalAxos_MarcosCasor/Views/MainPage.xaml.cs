
using Microsoft.Maui.Controls;
using System;
using TechnicalAxos_MarcosCasor.ViewModels;

namespace TechnicalAxos_MarcosCasor.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}



