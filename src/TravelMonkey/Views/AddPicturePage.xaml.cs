﻿using System;
using TravelMonkey.ViewModels;
using Xamarin.Forms;

namespace TravelMonkey.Views
{
    public partial class AddPicturePage : ContentPage
    {
        public AddPicturePage()
        {
            InitializeComponent();

            BindingContext = new AddPicturePageViewModel();

            MessagingCenter.Subscribe<AddPicturePageViewModel>(this, Constants.PictureAddedMessage, async (vm) => await Navigation.PopModalAsync(true));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}