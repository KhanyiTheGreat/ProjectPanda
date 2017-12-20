using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    class doctorUser
    {
        public int Id { get; set; } // should make this thier registration number 
        public string Email { get; set; } //Change to Email address
        public string Password { get; set; } //Password

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; } // meant for sync purposes

                                                 /*  [Newtonsoft.Json.JsonIgnore]
                                                   public string Emailaddress { get { return Email } }
                                                   [Newtonsoft.Json.JsonIgnore]
                                                   [Newtonsoft.Json.JsonIgnore]
                                                   **/



        /**        public doctorUser()
                {

                    void doctorUser(string Email, string Password) //storing data to direct location
                    {
                        this.Email = Email;
                        this.Password = Password;
                    }

                    bool CheckInformation()
                    {
                        if (!this.Email.Equals(" ") && !this.Password.Equals(" "))
                            return true;
                        else
                            return false;
                    }

                }*/
    }
}
