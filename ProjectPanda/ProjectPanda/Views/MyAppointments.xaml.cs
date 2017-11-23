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
    public partial class MyAppointments : ContentPage
    {
            public Appointment Appointment { get; set; }

        

        public MyAppointments()
        {
            InitializeComponent();

            Appointment = new Appointment
            {
                
            };
            BindingContext = this;


        }

        private void schedule(object sender, EventArgs e)
        {
            //code should then book the appointment
            Appointment.BookAppointment();
        }

        private void Cancel(object sender, EventArgs e) {

            //Code for cancelling appointments
            Appointment.CancelAppointment();

        }


    }

}