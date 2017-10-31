using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Models
{
    class token
    {


        public int Id { get; set; } // user ID
        public string access_token { get; set; }  // 
        public DateTime expire_date { get; set; }  // session expiry

        public token() { }
    }
}