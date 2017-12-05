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

       #region EventHandlers

        private void schedule(object sender, EventArgs e)
        {
            //code should then book the appointment
            Appointment.BookAppointment();
        }

        private void Cancel(object sender, EventArgs e) {

            //Code for cancelling appointments
            Appointment.CancelAppointment();

        }



        private void PickDateForAppointment(object sender, DateChangedEventArgs e) {

            //This event handler will return the selected date for appointments
            TheDateForAppointment.Text = e.NewDate.ToString();


            //This should also have a method for sending the time picked to the

        }



        //Might have to create a custom timepicker cause it seems that xamarin forms has not event handler for time

      

    }
   
    
    
    
    
    #endregion







}