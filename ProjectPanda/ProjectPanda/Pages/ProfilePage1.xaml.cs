using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage1 : MasterDetailPage
	{
		public ProfilePage1 ()
		{
			InitializeComponent ();
		}

        #region Event handlers for the side menu
        void Menu_btn2_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Settings());

            IsPresented = false;
        }

        void Menu_btn4_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SupportPagae());
            IsPresented = false;
        }

        void Menu_btn3_Clicked(object sender, EventArgs e)
        {
            // This button is for payment history
            Detail = new NavigationPage(new PaymentHistory());
            IsPresented = false;
        }




        void Button_Clicked(object sender, EventArgs e)
           => new NavigationPage();//doctorlist



        void Logout(object sender, EventArgs e)
        {
            //code that will allow for logging out.
            new NavigationPage(new SignInPrompt());


        }
        #endregion



        #region Event handelers for the tabbed pages

        void TapGestureRecognizerProfile(object sender, EventArgs e)
        {

            var page = new ProfilePage();

            PlaceHolder.Content = page.Content;


        }

        void TapGestureRecognizerDelivery(object sender, EventArgs e)
        {
            var page = new Delivery();

            PlaceHolder.Content = page.Content;
        }

     
        void TapGestureRecognizerAppointment(object sender, EventArgs e)
        {
            var page = new MyAppointments();
            PlaceHolder.Content = page.Content;
        }

        void TapGestureRecognizerCamera(object sender, EventArgs e)
        {
            var page = new CamPage();
            PlaceHolder.Content = page.Content;
        }


        #endregion


    }
}