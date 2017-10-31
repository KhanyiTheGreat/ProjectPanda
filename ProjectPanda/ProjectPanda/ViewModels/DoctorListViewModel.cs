using System;
using System.Diagnostics;
using System.Threading.Tasks;
using ProjectPanda.Helpers;
using ProjectPanda.Models;
using ProjectPanda.Views;

using Xamarin.Forms;

namespace ProjectPanda.ViewModels
{
    public class DoctorListViewModel : BaseViewModel
    {
        public ObservableRangeCollection<DocAvaliable> DoctorsOnCall { get; set; }

        public Command LoadDoctorList { get; set; }

        public DoctorListViewModel()
        {
            Title = "Doctors In your Area";
            DoctorsOnCall = new ObservableRangeCollection<DocAvaliable>();
            LoadDoctorList = new Command(async () => await ExecuteLoadDoctorList());

            MessagingCenter.Subscribe<NewDoctorList, DocAvaliable>(this, "ShowDoctorsAvaliable", async (obj, doctorOnCall) =>
            {
                var _doctorsOnCall = doctorOnCall as DocAvaliable;
                DoctorsOnCall.Add(_doctorsOnCall);
                await DataStore2.AddDoctorsListAsync(_doctorsOnCall);

            });

        }

        async Task ExecuteLoadDoctorList()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                DoctorsOnCall.Clear();
                var doctorOnCall = await DataStore2.GetDoctorsListAsync(true);
                DoctorsOnCall.ReplaceRange(doctorOnCall);
            }


            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessagingCenter.Send(new MessagingCenterAlert
                {
                    Title = "Error",
                    Message = "Unable to load avaliable Doctors.",
                    Cancel = "OK"
                }, "message");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}