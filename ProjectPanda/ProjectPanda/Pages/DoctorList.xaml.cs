using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectPanda.ViewModels;
using ProjectPanda.Models;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorList : ContentPage
	{

        DoctorListViewModel viewModel;
        public DoctorList ()
		{
			InitializeComponent ();
            //ListView.ItemsSource =DoctorList.DocList;
            BindingContext = viewModel = new DoctorListViewModel();
        }

        protected override void OnAppearing()
        {
            LoadListAsync();
            base.OnAppearing();
        }


        public static ObservableCollection<DocAvaliable> DocList = new ObservableCollection<DocAvaliable>
        {
            new DocAvaliable {ID=1,Name="Dr Zulu", Varsity="MBchB(Ukzn)" },
            new DocAvaliable {ID=2,Name="Dr Naidoo", Varsity="MBchB(Wits)" },
            new DocAvaliable {ID=3,Name="Dr Duma", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)" },
            new DocAvaliable {ID=4,Name="Dr McGhee", Varsity="MBchB(UCT)" },
            new DocAvaliable {ID=5,Name="Dr Nobody", Varsity="MBchB(UL)" },
            new DocAvaliable {ID=6,Name="Dr 50Cent", Varsity="MBchB(Stellenbosch)" }

        };

        private void LoadListAsync() //there were errors so ill sort them out later when we start doing databases
        {
            /* var DoctorOnCall = await DocAvaliable.getList();
             *
             *this.BindingContext = DocAvaliable;   
             * */

        }

        async void Doctor_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Selection = e.SelectedItem as DocAvaliable;
            if (Selection == null)
                return;

            await Navigation.PushAsync(new DoctorList());
            // if (e.SelectedItem != null) // it makes sure something is selected 
            //{

            //  var Selection = e.SelectedItem as DoctorList;
            // DisplayAlert("You Selected", "", "Ok");

            //Selection.Name still needs to be re added becuase the app must be more personal

            /* #region DisableSelectionHighlighting
             *{ (ListView)sender}.SelectedItem = null;
             *
              #endregion
              **/
        }


        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

    }
}