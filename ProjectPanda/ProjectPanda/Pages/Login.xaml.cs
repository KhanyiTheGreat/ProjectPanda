﻿using System;
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

        }

        private void FacebookSignIn(object sender, EventArgs e)
        {
            AuthenticationFacebook facebook = new AuthenticationFacebook();
            facebook.OnLoginClicked();
        }

        private void OutlookSignIn(object sender, EventArgs e)
        {
            AuthenticationMicrosoft microsoft = new AuthenticationMicrosoft();
            microsoft.OnLoginClicked();
        }

        private void OurSignIn(object sender, EventArgs e)
        {

        }
    }
}