using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using ProjectPanda.Models;

namespace ProjectPanda.AzureService
{

    

    public class RegisteredPatients
    {

        //This is going to help syncronize the back end with the front when it comes to updating the users settings, especially the personal information section


        MobileServiceClient client = null;      //will help the syncronization between what is on our servers and what is being displayed on the customers screen

        IMobileServiceTable<RegisteredPatients> patientInfo;

                        public async Task Initalize() {

                                if (client?.SyncContext?.IsInitialized ?? false) { return; }

                                var ProjectPandaUrl = "http://projectpanda.azurewebsites.net";

                                client = new MobileServiceClient(ProjectPandaUrl);

                            var localDeviceDB = "UserDevice.Db";

                            var store = new MobileServiceSQLiteStore(localDeviceDB);

                             store.DefineTable<RegisteredPatients> (); //i'll uncomment this later once I understand what james is saying

                            

                        }




             


    }
}
