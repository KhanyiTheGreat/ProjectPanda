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

       
        


    }
}
