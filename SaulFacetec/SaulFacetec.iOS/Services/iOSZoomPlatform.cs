using Newtonsoft.Json.Linq;
using SaulFacetec.iOS.Services;
using SaulFacetec.iOS.Services.Processors;
using SaulFacetec.Services;
using System;
using System.Net.Http;
using UIKit;
using Xamarin.Forms;
using Xminder;

[assembly: Dependency(typeof(iOSZoomPlatform))]
namespace SaulFacetec.iOS.Services
{
    public sealed class iOSZoomPlatform : IZoomSdk
    {
        readonly IZoomScannerHostController _iosHostController;

        public iOSZoomPlatform(IZoomScannerHostController iosHostController)
        {
            _iosHostController = iosHostController;

            var customization = FaceTecCustomization.New();
            customization.FrameCustomization.CornerRadius = 20;
            customization.FrameCustomization.BackgroundColor = UIColor.White;
            FaceTec.Sdk.SetCustomization(customization);

            //FaceTec.Sdk.InitializeInDevelopmentMode(FacetecConsts.DeviceKeyIdentifier, 
            //    FacetecConsts.PublicFaceScanEncryptionKey, x => NotifyStatus(x));
            var prodKey = ObtenerLicenseKey();
            FaceTec.Sdk.InitializeInProductionMode(prodKey,
                FacetecConsts.DeviceKeyIdentifier,
                FacetecConsts.PublicFaceScanEncryptionKey, x => NotifyStatus(x));
        }

        private string ObtenerLicenseKey()
        {
            try
            {
                //Permisos para wifi
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Device-Key", FacetecConsts.DeviceKeyIdentifier);

                var response = client.GetAsync(FacetecConsts.BaseURL + "/getInitString").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                //dynamic parsedResponse = JObject.Parse(result);
                var parsedResponse = LicenseModel.FromJson(result);

                return parsedResponse.Data.LicenseText;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return string.Empty;
            }
        }

        public void Scan()
        {
            _iosHostController.ScanningStarted(this);
        }

        public void NotifyStatus(bool result)
        {
            if (result)
            {
                MessagingCenter.Send(new MessagesZoom.ScannerStatusMessage { ScannerReady = result }, MessagesZoom.ScannerSetup);
            }
        }
    }
}