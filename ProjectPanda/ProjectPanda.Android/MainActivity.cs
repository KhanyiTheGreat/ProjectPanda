using System;
using Plugin.Permissions;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;
using SQLitePCL.lib;
using System.Threading.Tasks;
namespace ProjectPanda.Droid
{
	[Activity (Label = "ProjectPanda", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity, IAuthenticate
    {
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);

            // Initialization for Azure Mobile Apps
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            // This MobileServiceClient has been configured to communicate with the Azure Mobile App and
            // Azure Gateway using the application url. You're all set to start working with your Mobile App!
            Microsoft.WindowsAzure.MobileServices.MobileServiceClient ProjectPandaClient = new Microsoft.WindowsAzure.MobileServices.MobileServiceClient(
            "https://projectpanda.azurewebsites.net");
           


            //the following is for authentication
            global::Xamarin.Auth.Presenters.XamarinAndroid.AuthenticationConfiguration.Init(this, bundle);


            //the following is for Gps api call location
            Xamarians.GPS.Droid.GPSServiceAndroid.Initialize(this);

            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new ProjectPanda.App ());


           // Initialize the authenticator before loading the app.
            App.Init((IAuthenticate)this);


        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }



                public static MobileServiceClient MobileService =
                             new MobileServiceClient(
                                                "https://projectpandamobileappservice20171016015234.azurewebsites.net"
                                                );


    }



    // Define a authenticated user.
    private MobileServiceUser user;

    public async Task<bool> Authenticate()
    {
        var success = false;
        var message = string.Empty;
        try
        {
            // Sign in with Facebook login using a server-managed flow.
            user = await TodoItemManager.DefaultManager.CurrentClient.LoginAsync(this,
                MobileServiceAuthenticationProvider.Facebook, "{url_scheme_of_your_app}");
            if (user != null)
            {
                message = string.Format("you are now signed-in as {0}.",
                    user.UserId);
                success = true;
            }
        }
        catch (Exception ex)
        {
            message = ex.Message;
        }

        // Display the success or failure message.
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.SetMessage(message);
        builder.SetTitle("Sign-in result");
        builder.Create().Show();

        return success;
    }



}

