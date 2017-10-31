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
            await DocInitialize();
            if (forceRefresh)
                await DocPullLatestAsync();
            return await DoctorOnCallTable.ToEnumerableAsync();
        }
        public async Task<DocAvaliable> GetDoctorsListAsync(string doctorOnCall)
        {
            await DocInitialize();
            await DocPullLatestAsync();
            var doctors = await DoctorOnCallTable.Where(s => s.Id == doctorOnCall).ToListAsync();

            if (doctors == null || doctors.Count == 0)
                return null;

            return doctors[0];

        }


        public Task<bool> AddDoctorsListAsync(DocAvaliable doctorOnCall)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDoctorsListAsync(DocAvaliable doctorOnCall)
        {
            throw new NotImplementedException();
        }

        public Task DocInitialize()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DocPullLatestAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DocSyncAsync()
        {
            throw new NotImplementedException();
        }




        public Task<bool> UpdateDoctorsListAsync(DocAvaliable doctorOnCall)
        {
            throw new NotImplementedException();
        }
    }
}
