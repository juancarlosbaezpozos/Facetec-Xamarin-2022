using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Foundation;
using Newtonsoft.Json.Linq;
using SaulFacetec.iOS.Services;
using SaulFacetec.iOS.Services.Processors;
using UIKit;
using Xminder;

namespace SaulFacetec.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate, IZoomScannerHostController
    {
        public iOSZoomPlatform CurrentZoomImplementation;

        public IProcessor latestProcessor;

        public AppDelegate()
        {
            ZoomScannerFactoryImplementation.IOSHostController = this;
        }

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        //public void OnComplete()
        //{
        //    if (latestProcessor.isSuccess())
        //    {
        //        //enviar a forms
        //    }
        //}

        private string ObtenerToken()
        {
            try
            {
                //Permisos para wifi
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Device-Key", FacetecConsts.DeviceKeyIdentifier);

                var response = client.GetAsync(FacetecConsts.BaseURL + "/session-token").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                dynamic parsedResponse = JObject.Parse(result);

                return parsedResponse.sessionToken;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return string.Empty;
            }
        }

        public void ScanningStarted(iOSZoomPlatform implementation)
        {
            CurrentZoomImplementation = implementation;

            var theToken = ObtenerToken();
            if (string.IsNullOrEmpty(theToken))
            {
                return;
            }

            UIViewController currentController = UIApplication.SharedApplication.KeyWindow.RootViewController;
            //latestProcessor = new LivenessCheckProcessor(theToken, currentController);
            latestProcessor = new PhotoIDMatchProcessor(theToken, currentController);
        }

    }
}
