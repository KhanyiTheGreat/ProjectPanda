using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace ProjectPanda.Services
{
    public class Authentication
    {




        public void GoogeleAuthFunction()
        {
            OAuth2Authenticator authenticator = new OAuth2Authenticator(
               "655782672996-f7n91tloeocgksh8dogfuijhpfcre2m1.apps.googleusercontent.com",
               null,
               "profile",
               new Uri("https://www.googleapis.com/auth/plus.me"),
               new Uri("http://projectpanda.azurewebsites.net"),
               new Uri("http://projectpanda.azurewebsites.net"),
               null,
               true);







            authenticator.Completed += (sender, EventArgs) =>
            {

                if (EventArgs.IsAuthenticated)
                {
                    //I dont understand the use of using eventArgs.Account yet to do more complex things for now
                }
                else
                {
                    //the code for if the user cancels the authentication process
                }

            };


            //The following code will be for facebook

            /*  void Facebookauthentication() {
                OAuth2Authenticator authenticatorFacebook = new OAuth2Authenticator();
            }
            */










        }




        public void FacebookAuthFunction()
        {
            OAuth2Authenticator authenticator = new OAuth2Authenticator(
               "136133043698809",
               null,
               "profile",
               new Uri("https://m.facebook.com/dialog/oauth/"),
               new Uri("http://www.facebook.com/connect/login_success.html"),
               new Uri("http://projectpanda.azurewebsites.net"),
               null,
               true);







            authenticator.Completed += (sender, EventArgs) =>
            {

                if (EventArgs.IsAuthenticated)
                {
                    //I dont understand the use of using eventArgs.Account yet to do more complex things for now
                }
                else
                {
                    //the code for if the user cancels the authentication process
                }

            };









        }

        public void MicrosoftAuthFunction()
        {
            // the authentication code for microsoft services will go here


        }





    }






}
