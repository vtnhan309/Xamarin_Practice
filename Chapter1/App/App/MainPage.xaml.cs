﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    protected void ButtonClicked(object sender, EventArgs e)
    {
      ((Button)sender).Text = "It is so!";
    }

    async protected void ImageTapped(object sender, EventArgs e)
    {
      Image image = ((Image)sender);
      image.Opacity = .5;
      await Task.Delay(200);
      image.Opacity = 1;
    }
  }
}
