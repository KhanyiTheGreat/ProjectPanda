using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using System.Collections;
using ProjectPanda.Models;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Microsoft.WindowsAzure.MobileServices.Query;
using Plugin.Connectivity;
namespace ProjectPanda.AzureService
{
    /*
    public class RegistredPatientsBackEnd
    {
        public MobileServiceClient MobileService { get; set; }
        IMobileServiceClient RegistredPatientUser;


        public async Task Initialize()
        {
            //Create our client
            MobileService = new MobileServiceClient("https://projectpanda.azurewebsites.net");

            const string deviceStorage = "syncdeviceStorage.db";

            //setup our local sqlite store and intialize our table
            var store = new MobileServiceSQLiteStore(deviceStorage);

            store.DefineTable<Models.RegisteredPatients>();

            await MobileService.SyncContext.InitializeAsync(store);

            //Get the  table that will call out to azure

        
        }

        public async Task<Models.RegisteredPatients>  GetRegistredPatientInfo()
        {

            
            await SyncPateintInfo();

            var dataFromTable = RegistredPatientUser;
            return null;
        }

        public async Task SyncPateintInfo()
        {
            //pulls down all latest changes and then pushs current info up
            await RegistredPatientUser.SyncContext.PushAsync();

           
         
        }

        public async Task AddPatient()
        {
            //Create and insert Patient
            var patientUser = new Models.RegisteredPatients() {

                //Put code to auto fill from the token here as well so that it auto fills some fields

                First_Name = "khanyisani",
                Surname = "Buthelezi",
                ChronicDisease = "xyphulus",
                PhoneNumber = "06098887758",
                BloddType = "A+",
                MedicalAid = "sizwe",
                MedicineTaken = "crow bar",
                Alergies = "None",
                Email = "khanyisani.buthelezi@gmail.com",
                DosagePerDay = "3 per day",
                AzureCreated="june 18",
                AzureDeleted="none",
                AzureUpdated="none",
                AzureVersion="nope",
                Id="00000000000000000001"


                


            };


        }


    }
    */
}
