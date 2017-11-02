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


        }

        private void FacebookSignIn(object sender, EventArgs e)
        {

        }

        private void OutlookSignIn(object sender, EventArgs e)
        {

        }

        private void OurSignIn(object sender, EventArgs e)
        {

        }
    }
}