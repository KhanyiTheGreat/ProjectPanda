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
	public partial class DetailPageForFilling : ContentPage
	{
		public DetailPageForFilling ()
		{
			InitializeComponent ();
		}

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            //code to reveal the dependency form to be filled 
        }
    }
}