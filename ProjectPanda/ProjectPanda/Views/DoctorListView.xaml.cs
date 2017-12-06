using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorListView : ContentPage
	{
        DoctorListViewModel viewModel;
        public DoctorListView ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new DoctorListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


    }
}