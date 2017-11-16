using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        bool authenticatedGoogleSucessfully = false;
        bool authenticatedFacebookSucessfully =false;
        bool authenticatedMicrosoftSucessfully = false;

        public Login ()
		{
			InitializeComponent ();
		}

        private void SignUpPromp(object sender, EventArgs e)
        {

            
        }

         private void GoogleSignIn(object sender, EventArgs e) {

            

       
            
                AuthenticationGoogle google = new AuthenticationGoogle();
                google.OnLoginClicked();

            if (authenticatedGoogleSucessfully == true) {

                Navigation.PushAsync(new DetailPageForFilling()); //sends the user to the detailpage to be filled out
            }

        }

        private void FacebookSignIn(object sender, EventArgs e)
        {
            AuthenticationFacebook facebook = new AuthenticationFacebook();
            facebook.OnLoginClicked();

            if (authenticatedFacebookSucessfully == true) {

                Navigation.PushAsync(new DetailPageForFilling()); //sends the user to the detailpage to be filled out
            }
        }

        private void OutlookSignIn(object sender, EventArgs e)
        {
            AuthenticationMicrosoft microsoft = new AuthenticationMicrosoft();
            microsoft.OnLoginClicked();

            if (authenticatedMicrosoftSucessfully == true) {

                Navigation.PushAsync(new DetailPageForFilling());
            }
        }

        private void OurSignIn(object sender, EventArgs e)
        {
            //sends them to a custom enter email, password and re-enter password page for 
        }
    }
}