using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginButton : ContentPage
	{

        // Track whether the user has authenticated.
        bool authenticated = false;


        public LoginButton ()
		{
			InitializeComponent ();
		}




        private void loginButton_Clicked(object sender, EventArgs e) {




        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Refresh items only when authenticated.
            if (authenticated == true)
            {
                // Set syncItems to true in order to synchronize the data
                // on startup when running in offline mode.
                await RefreshItems(true, syncItems: false);

                // Hide the Sign-in button.
                this.loginButton.IsVisible = false;
            }
        }


    }
}