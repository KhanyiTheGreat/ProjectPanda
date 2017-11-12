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

                                var ProjectPandaUrl = "http://projectpanda.azurewebsites.net";  //still need receptors error handles for authentication but will work on those later

                                client = new MobileServiceClient(ProjectPandaUrl);  

                            var localDeviceDB = "UserDevice.db";        //self discribed, it sets those values on the device

                          //  MobileServiceClient.EnsureFileExists(localDeviceDB); Makes sure to append where the argument is stored, i'll see if i'll need it in the future to come;  

                            var store = new MobileServiceSQLiteStore(localDeviceDB);

                             store.DefineTable<RegisteredPatients> (); //i'll uncomment this later once I understand what james is saying

                             //add more store.defineTable 

                          await client.SyncContext.InitializeAsync(store);

                            //egisteredPatients=client.GetSyncTable<>  //for syncrinization 

                          //  client.GetTable(name of the table that needs syncing, i'll represent it as a % sign in the rest of the code);
                      
                         }


    //The following method is for ensuring that both the online and offline data match
    public async Task SyncPatientInfo() {


           /* 
                await Initialize();

            try{
            
            This will skip becuase it wont be edited and it wont be online
            if(!CrossConncectivity.Current.IsConnected)
            return;
           
            This will execute if online
            await client.SyncContext.PushAsync();
            
            }

            catch(Exception ex){
            
                    debug
            }
             
             */



        }

        


        /*
       
        FOR NOW i AM GOING TO TYPE THE REST OF WHAT i DONT UNDERSTAND IN THIS COOMENT SECTION CAUSE I CANT THINK RIGHT NOW
        //Gets the information on the backend side of things

       
        
        public async Task<IEnumerable<RegisteredPatients>> GetRegisteredPatients() {

            await Initalize();

            await SyncPatientInfo();
                
                var dataFromTable=%;
        
        
                return dataFromTable;
        
        }

      
        //this will simply edit information to be updated to the database if there is any information change 
       public async Task <RegisteredPatients> EditInformation(){
       
        
        await Intitialize();
        
        var patient=new RegisteredPatient{};
        
        return null;
        
        }        
         
        
         
         */


    }
}
