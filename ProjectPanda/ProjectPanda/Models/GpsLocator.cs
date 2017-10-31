using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xamarians.GPS;

namespace ProjectPanda.Models
{
    public class GpsLocator
    {
        //code to find the precise location

        public void GpsAccurecySet()
        {

            //this sets how accurate the gps is
            GPSService.Instance.DesiredAccuracy = 100;

        }


        public async void GpsCurrentLocation()
        {

            //give the location at that particular point
            var postion = await GPSService.Instance.GetPositionAsync(CancellationToken.None);
        }

        public void PostionListen()
        {

            //listens to the current postion
            GPSService.Instance.StartListening(1000, 5);
        }

        public void StopListeningToGpsLocation()
        {


            //stops listening for the location. maybe the method in stoplistning has a time interval
            GPSService.Instance.StopListening();
        }

        public void PostionChangeOfGps()
        {


            //This will need a bit of polishing cause I did a auto code generation to actually create that, 
            //event handler of which I am not 100% sure is suppose to do besides initialise a value of some sort.

            EventHandler<PositionEventArgs> Instance_PositionChanged = null;
            GPSService.Instance.PositionChanged += Instance_PositionChanged;
        }


    }
}