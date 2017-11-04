using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Media;
using Xamarin.Forms;
using Plugin.Media.Abstractions;


namespace ProjectPanda.Models
{
    public class Camera
    {



        //Code for getting into the camera via the xaml code located in the mainProfilePage  



        public void SavingImages()
        {
            //doubt we will need this function

        }







        async public void DefaultCamera()
        {


            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Rear
            });

        }
    }

}