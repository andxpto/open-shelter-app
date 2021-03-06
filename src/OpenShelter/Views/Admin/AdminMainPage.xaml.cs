﻿using System;
using Xamarin.Forms;

namespace OpenShelter.Views.Admin
{
    public partial class AdminMainPage : ContentPage
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        async void OnManageVolunteersPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminVolunteersPage());
        }

        async void OnDownloadPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminDownloadPage());
        }
    }
}
