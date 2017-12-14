using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    public class MedicalBuildingDataModel
    {

        #region properties for the hospital/practice bio

        public string HeadTitle { get; set; } //must change naming
        public string HospBio { get; set; } //the amounts of doctors it has and the average num of patients on a weekly basis
        public string HeadLinesDesc { get; set; }
        public string ProfileImage { get; set; } //the actual picture of the hospital 
        #endregion
    }

   
    
    #region The class for setting appointment that 

    public class Practice:MedicalBuildingDataModel
    {
        /*
         This class is for getting the information required for setting appointments that is about the practice like how many patients are there at that given time
         and the location of the practice by gps co-ordinates
             
       */

        private int numOfPatiants; //the number of patients at the location
        private string gpsLocationOfPractice; //the GPs location of the practice


        public int NumOfPatiants
        {
            get { return numOfPatiants; }
            set { value = numOfPatiants; }

        }

        public string LocationOfPractice
        {

            get { return gpsLocationOfPractice; }
            set { value = gpsLocationOfPractice; }
        }


    }
    #endregion

}
