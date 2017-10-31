using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;

namespace ProjectPanda.Models
{
    public class Delivery
    {

        public void ShowMeds()
        {

            //This method will display the meds the users uses and display it on the profile tab in mainProfilePage

        }


        public void DeleteMedsFromBasket()
        {

            //This method will delete medicine requested into the basket
        }

        public void AddMedsToBasket()
        {

            //This method will add the medicine reqested into the basket
        }

        public void OrderMedicine()
        {
            //This method will send a order request to us,as to what the customer requires
            bool orderedMedicine = true;

            if ((orderedMedicine == true))
            {

                //Code logic that will add the medicine ordered to the list in the main profile page
                //As well as send the list to us for processing
            }
        }


        public void GenerateQrCode()
        {
            //This method is suppose to generate the QR code for the user as they send out an order  

        }

    }
}