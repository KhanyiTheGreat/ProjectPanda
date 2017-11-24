using System;
using System.Collections.Generic;
using System.Text;
using QRCoder;

namespace ProjectPanda.Models
{
    class QrcodeReader {

        async public void ReadQrCode() {

           var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            scanner.UseCustomOverlay = false;

            var result = await scanner.Scan();

        }
   

    }

}