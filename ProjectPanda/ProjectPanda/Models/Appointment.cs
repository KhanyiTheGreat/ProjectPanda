﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public class Appointment

    {
      //  public int numberOfBookedAppoinements;
      //  public int patientsAtPractice;



        public void BookAppointment()
        {
           //the code here should push that information over to the cloud for syncrinization so the doctor can refresh to see who is next.

        }

        public  void CancelAppointment()
        {
            //This method is for cancelling the already booked appointment
            //this method will have to be overid by the BookAppiontment method


        }


        public void BookingBypicker() {

            /*
                    if((doctor) || (date) || (time)|| (location) !SelectedItem){ BookAppointment(); }
             
             */


        }


        public void BookingByLocation() {

            /*

                   if(Maxdistance =< currentUserLocation ){return DocAvlaible;}

                   if((numberOfBookedAppoinements<patientsAtPractice) && (currentUserLocation =< Maxdistance)){return true;}


            */

        }

    }
}