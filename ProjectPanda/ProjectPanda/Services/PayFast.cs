using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;



namespace ProjectPanda.Services
{
    public class PayFast
    {
        public string paymentMode;
        private string amount;


        public async Task OrderPaymentAsync(string amount)
        {

            // string name = "My Website, Order #" + orderId;
            string description = "Order description";

            string PaymentEngineSite = "https://www.payfast.co.za/eng/process";
            string merchant_id = "12292781"; //Real Values
            string merchant_key = "knzhyd8wedh08"; //RealValues
            bool Success = false;

            // Check if we are using the test or live system
            // string paymentMode = System.Configuration.ConfigurationManager.AppSettings["PaymentMode"];

            if (paymentMode == "test")
            {
                PaymentEngineSite = "https://sandbox.payfast.co.za/eng/process?";
                merchant_id = "10000100";
                merchant_key = "46f0cd694581a";
            }
            else if (paymentMode == "live")
            {
                PaymentEngineSite = "https://www.payfast.co.za/eng/process?";
                // merchant_id = System.Configuration.ConfigurationManager.AppSettings["PF_MerchantID"];
                // merchant_key = System.Configuration.ConfigurationManager.AppSettings["PF_MerchantKey"];
            }
            else
            {
                throw new InvalidOperationException("Cannot process payment if PaymentMode (in web.config) value is unknown.");
            }

            // Build the query string for payment site

            // if ( paymentMode=="live" && Success == true)
            //   return amount;



        }

    }
}

