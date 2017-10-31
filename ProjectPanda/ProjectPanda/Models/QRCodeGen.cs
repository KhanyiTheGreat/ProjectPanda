using System;
using System.Collections.Generic;
using System.Text;
using QRCoder;

namespace ProjectPanda.Models
{




    public class Bitmap
    {


    }

    public class QRCode
    {

        private QRCodeData qrCodeData;

        public QRCode(QRCodeData qrCodeData)
        {
            this.qrCodeData = qrCodeData;
        }




        //code for this class, not sure what it does yet.

        internal Bitmap GetGraphic()
        {
            throw new NotImplementedException();
        }
    }


    public class QRCodeGen
    {




        public void displayCode()
        {

            //code to geenrate QR codes that are generated from delivery request
            // Random QrCode = new Random();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic();


        }



    }
}