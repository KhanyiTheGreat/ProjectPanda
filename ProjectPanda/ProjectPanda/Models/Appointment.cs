using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public class Appointment

    {
        public int numberOfBookedAppoinements { get; set; }
        public int patientsAtPractice { get; set; }

        //  numberOfBookeAppoinments=numberOfAppointmentsFromTheCloud;

        public void BookAppointment()
        {
            //the code here should push that information over to the cloud for syncrinization so the doctor can refresh to see who is next

            if (BookingBypicker().Equals(!BookingByLocation())) 
            {

                BookingBypicker();
            }
            else {
                BookingByLocation();
            }

        }

        public  void CancelAppointment()
        {
            //This method is for cancelling the already booked appointment
            //this method will have to be overid by the BookAppiontment method
            

        }


        protected bool BookingBypicker() {

            /*
                    if((doctor) || (date) || (time)|| (location) !SelectedItem) { return false; }
             
             */

            return false;
        }


        protected bool BookingByLocation() {

            /*

                   if((Maxdistance =< currentUserLocation )&&(numberOfAppointmentsFromTheCloud<patientsAtPractice))
                   {return DocAvlaible;} 

                  


            */

            return true;
        }

    }
}