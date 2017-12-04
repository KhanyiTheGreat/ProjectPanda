using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

using ProjectPanda.Helpers;
using ProjectPanda.Models;

using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Plugin.Connectivity;

namespace ProjectPanda.Services
{
    class AzureDataStore2 : IDataStore2<DocAvaliable>
    {
        public bool UseAuthentication => false;
        /// <summary>
        /// this is where yuu inable the login feature 
        /// </summary>
        bool isInitialized;
        IMobileServiceSyncTable<DocAvaliable> DoctorOnCallTable;
        public MobileServiceClient MobileServiceClient { get; set; }

        public async Task<IEnumerable<DocAvaliable>> GetDoctorsListAsync(bool forceRefresh = false)
        {
            /// <summary>
            /// Refersh button command for list implementation
            /// </summary>
            await DocInitialize(); 
            if (forceRefresh)
                await DocPullLatestAsync();
            return await DoctorOnCallTable.ToEnumerableAsync(); //suppose to return the database with the doctorlist in it
        }
        public async Task<DocAvaliable> GetDoctorsListAsync(string doctorOnCall)
        {
            await DocInitialize();
            await DocPullLatestAsync();
            var doctors = await DoctorOnCallTable.Where(s => s.Id == doctorOnCall).ToListAsync();

            if (doctors == null || doctors.Count == 0)
                return null;
            //might have to add a else statement when ` 'doctor.count' !=0; `
            return doctors[0];

        }


        public async Task<bool> AddDoctorsListAsync(DocAvaliable doctorOnCall)
        {
           //this function will be used for showing up the doclist after a search is initalized
           // change name from "add.."--> "update.."
            await DocInitialize();
            await DocPullLatestAsync();
            //await DoctorOnCallTable.InsertAsync(doctorOnCall);
            await DocSyncAsync();

            return true;
        }

        public async Task<bool> DeleteDoctorsListAsync(DocAvaliable doctorOnCall)
        {
            //this will change too
            await DocInitialize();
            await DocPullLatestAsync();
            await DoctorOnCallTable.DeleteAsync(doctorOnCall);
            await DocSyncAsync();

            return true;
        }

        public async Task DocInitialize()
        {
            if (isInitialized)
                return;
            // Code is suppose to check if user is logged in or not
            //We do this buy retrieving the URL link using 
            // `MobileServices = new MobileServicesJsonSerializerSettings`

            //#1 do check statement to receieve AuthToken
            //#2 start the database, Define the table and then call GetDoctorSyncTable<Docavalibale>();

            //var store = new MobileServiceSQLLiteStore("main.db");
            //store.DefineTable<DocAvaliable>();
            //await MobileServices.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());
            // DoctorOnCallTable = MobileService.GetSyncTable<DocAvaliable>();
          
            isInitialized = true;

        }

        public async Task<bool> DocPullLatestAsync()
        {
            if (!CrossConnectivity.Current.IsConnected)//James plugin to check if your still connected to the internet
            {
                Debug.WriteLine("Unable to show avalibale doctors, since your offline");
                return false;
            }
            try
            {
                //Tries to pull the list again
               // await DoctorOnCallTable.PullAsync($"all{typeof(DocAvaliable).Name}", DoctorOnCallTable.CreateQuery());
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to pull the Available Doctors, that is alright as we have offline capabilities: " + ex);
                return false;
            }
        }

        public async Task<bool> DocSyncAsync()
        {
            if (!!CrossConnectivity.Current.IsConnected)
            {
                Debug.WriteLine("Unable to pull the Available Doctors");
                return false;
            }
            try
            {

            }
            catch (MobileServicePushFailedException exc)
            {
                if (exc.PushResult == null)
                {

                }
                foreach (var error in exc.PushResult.Errors)
                {
                    if (error.OperationKind == MobileServiceTableOperationKind.Update && error.Result != null)
                    {
                        //Update failed, reverting to server's copy.
                    }
                    else
                    {
                        // Discard local change.
                    }


                }


            }
            return true;
        }




        public Task<bool> UpdateDoctorsListAsync(DocAvaliable doctorOnCall)
        {
            throw new NotImplementedException();
        }
    }
}
