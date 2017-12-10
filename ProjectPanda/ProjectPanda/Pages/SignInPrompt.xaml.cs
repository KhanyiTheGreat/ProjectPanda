using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Pages;
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

        




         async void  Button_Clicked(object sender, EventArgs e)
        {


            /*
             
                    if(EmailAddress && Password && (isAuthenticated==true) == those in the databse )    {Navigation.PushAsync(new MainProfilePage());}
             
             */




           await Navigation.PushModalAsync(new MainProfile());
           // Navigation.PushAsync(new DetailPageForFilling());
     
        }

        async void prompt(object sender, EventArgs e) {

            await Navigation.PushAsync(new Login());
        }


        async void ContactUs(object sender, EventArgs e) {

           await Navigation.PushAsync(new SupportPagae());
        }


    }
}