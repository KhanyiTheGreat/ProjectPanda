using System;
using System.Collections.Generic;
using System.Text;
using QRCoder;

namespace ProjectPanda.Models
{
    class QrcodeReader {

        async public void ReadQrCode() {

           var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            //I think I'll have to change the scanner.UseCustomeOverlay to true then set,
            //scanner.CustomOverlay = Models.Camera instance;
            scanner.UseCustomOverlay = false;

            var result = await scanner.Scan();

        }
   

    }

}