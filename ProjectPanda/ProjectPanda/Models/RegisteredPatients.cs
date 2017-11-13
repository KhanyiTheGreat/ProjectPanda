using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace ProjectPanda.Models
{
    class RegisteredPatients
    {

        //Used to locally display information on the users device


        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("First Name")]
        public string First_Name { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("MedicalAid")]
        public string MedicalAid { get; set; }


        [JsonProperty("BloodType")]
        public string BloddType { get; set; }

        [JsonProperty("FrequentDoctor")]
        public string ChronicDisease { get; set; }

        [JsonProperty("DosagePerDay")]                  //The dosage per day will just be concatinated with the medicine taken on a line by line basis.
        public string DosagePerDay { get; set; }


        [JsonProperty("MedicineTaken")]
        public string MedicineTaken { get; set; }

        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Alergies")]
        public string Alergies { get; set; }

        [Microsoft.WindowsAzure.MobileServices.CreatedAt]
        public string AzureCreated { get; set; }

        [Microsoft.WindowsAzure.MobileServices.UpdatedAt]
        public string AzureUpdated { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Deleted]
        public string AzureDeleted { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }






    }
}
