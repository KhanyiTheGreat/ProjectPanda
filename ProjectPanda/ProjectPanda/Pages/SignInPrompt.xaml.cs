using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignInPrompt : ContentPage
	{
		public SignInPrompt ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Code should check if the credentials entered are true and stored in the database before going to the mainprofile page
        }

        async void prompt(object sender, EventArgs e) {

            await Navigation.PushAsync(new Login());
        }


        async void ContactUs(object sender, EventArgs e) {

           await Navigation.PushAsync(new SupportPagae());
        }
    }
}