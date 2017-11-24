using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CamPage : ContentPage
	{
		public CamPage ()
		{
			InitializeComponent ();

            //  Camera cameraShot = new Camera(); Not sure if we will really need this for now cause 
            QrcodeReader qrcode = new QrcodeReader();
            qrcode.ReadQrCode();
         
        }
	}
}