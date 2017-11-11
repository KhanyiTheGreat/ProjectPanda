using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    class RegisteredPatients
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }






    }
}
