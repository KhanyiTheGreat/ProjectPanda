﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPrompt : ContentPage
	{
		public SignUpPrompt ()
		{
			InitializeComponent ();
		}

        private async void backbutton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}