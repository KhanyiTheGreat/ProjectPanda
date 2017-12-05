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
	public partial class MainProfilePage : MasterDetailPage
	{
		public MainProfilePage ()
		{
			InitializeComponent ();
		}


        private void Menu_btn2_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Settings());

            IsPresented = false;
        }

        private void Menu_btn4_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SupportPagae());
            IsPresented = false;
        }

        private void Menu_btn3_Clicked(object sender, EventArgs e)
        {
            // This button is for payment history
            Detail = new NavigationPage(new PaymentHistory());
            IsPresented = false;
        }




        private void Button_Clicked(object sender, EventArgs e)
            => new NavigationPage(new DoctorList());



        private void Logout(object sender, EventArgs e)
        {
            //code that will allow for logging out.
            
        }

        

    }

}
