using Android.App;
using Android.Content;
using Com.Facetec.Sdk;
using Newtonsoft.Json.Linq;
using SaulFacetec.Droid.Services;
using SaulFacetec.Droid.Services.Processors;
using SaulFacetec.Services;
using System;
using System.Net.Http;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidZoomPlatform))]
namespace SaulFacetec.Droid.Services
{
    public sealed class AndroidZoomPlatform : IZoomSdk
    {
        readonly IZoomScannerAndroidHostActivity _androidHostActivity;

        public AndroidZoomPlatform(IZoomScannerAndroidHostActivity androidHostActivity)
        {
            _androidHostActivity = androidHostActivity;

            var customization = new FaceTecCustomization();
            customization.FrameCustomization.CornerRadius = 20;
            customization.FrameCustomization.BackgroundColor = Android.Graphics.Color.ParseColor("#ffffff");
            FaceTecSDK.SetCustomization(customization);

            var context = Android.App.Application.Context;
            //var prodKey = ObtenerLicenseKey();
            FaceTecSDK.InitializeInDevelopmentMode(context, FacetecConsts.DeviceKeyIdentifier, FacetecConsts.PublicFaceScanEncryptionKey,
                new FacetecInitializeCallback((MainActivity)_androidHostActivity.HostActivity));
            /*FaceTecSDK.InitializeInProductionMode(context, prodKey, FacetecConsts.DeviceKeyIdentifier, FacetecConsts.PublicFaceScanEncryptionKey,
                new FacetecInitializeCallback((MainActivity)_androidHostActivity.HostActivity));*/
        }

        public void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (requestCode == _androidHostActivity.ScanZoomActivityRequestCode)
            {
                if (resultCode == Result.Ok)
                {
                    MessagingCenter.Send(new MessagesZoom.ScanningDoneMessage { ScanningCancelled = false }, MessagesZoom.ScanningDoneMessageId);
                }
                else
                {
                    MessagingCenter.Send(new MessagesZoom.ScanningDoneMessage { ScanningCancelled = true }, MessagesZoom.ScanningDoneMessageId);
                }
            }
        }

        public void Scan()
        {
            //Ir por el token
            var theToken = ObtenerToken();
            _androidHostActivity.ScanningStarted(this, theToken);
        }

        private string ObtenerToken()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Device-Key", FacetecConsts.DeviceKeyIdentifier);
            client.DefaultRequestHeaders.Add("X-User-Agent", FaceTecSDK.CreateFaceTecAPIUserAgentString(""));

            var response = client.GetAsync(FacetecConsts.BaseURL + "/session-token").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            dynamic parsedResponse = JObject.Parse(result);

            return parsedResponse.sessionToken;
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
                var parsedResponse = LicenseModel.FromJson(result);

                return parsedResponse.Data.LicenseText;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return string.Empty;
            }
        }

    }
}