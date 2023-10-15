﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab06AMM2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewDemo());
            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewCode());
            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewSource());
            };
            Item20.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewGroup());
            };
        }
    }
}