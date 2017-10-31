using System;
using ProjectPanda.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewDoctorList : ContentPage
    {
        public DocAvaliable DocAvaliable { get; set; }
        public NewDoctorList()
        {
            InitializeComponent();

            DocAvaliable = new DocAvaliable
            {
                Name = "Doctors Name",
                DocVarsity = "Varsity",
                DocsImageUrl = "ImageLink"
            };
            BindingContext = this;
        }

    }
}