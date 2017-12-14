using System;
using System.Collections.Generic;
using System.Text;


namespace ProjectPanda.Models
{
    class patientUser:GpsLocator
    {
        //this class must caluculate the distance between the user and the doctor/practice
        //1 it must get the gps location from the medicalbuildingdatamodel
        //2 it must get the user current location
        //3 it must then do the conversions from the location from gps format to int


    }



    public class DistanceAlgorithm
    {
        //this method uses the haversine algorithim

        #region distance calculator 
        //method for calulating distance between user and location
        public double DistanceCalculator(double latitude1, double latitude2, double longitude1, double longitude2)
        {
            /*
                latitude1 and longitude1-user current location 
                
                latitude2 and longitude2-practice location
             
             */

            const double kilo = 6372.8; //in kilometeres this the radius of the earth

            var lat = toRadians(latitude2 - latitude1); //converts the cordinates to radians 
            var longi = toRadians(longitude2 - longitude1); //converts the cordinates to radians 

            latitude1 = toRadians(latitude1);
            latitude2 = toRadians(latitude2);

            var a = (Math.Sin(lat / 2) * Math.Sin(lat / 2)) + (Math.Sin(longi / 2) * Math.Sin(longi / 2) * Math.Cos(latitude1) * Math.Cos(latitude2)); //calculates the distance I think from the formula I worked out 2rarcsin

            var c = 2 * Math.Asin(Math.Sqrt(a));


            return kilo * 2 * Math.Asin(Math.Sqrt(a));




        }
        #endregion


        #region Calculates the radians of the degree 
        //the c# libaray does not allow you to have parameters as degrees and radians are more accurate
        public static double toRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        #endregion


    }

}