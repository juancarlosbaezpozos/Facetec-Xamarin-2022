using Foundation;
using Newtonsoft.Json.Linq;
using SaulFacetec.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xminder;

namespace SaulFacetec.iOS.Services.Processors
{
    public class LivenessCheckProcessor : NSObject, IFaceTecFaceScanProcessorDelegate, IProcessor
    {
        private bool success = false;
        private readonly UIViewController _fromViewController;

        public LivenessCheckProcessor(string sessionToken, UIViewController fromViewController)
        {
            _fromViewController = fromViewController;

            var newController = FaceTec.Sdk.CreateSessionVCWithFaceScanProcessor(this, sessionToken);
            _fromViewController.PresentViewController(newController, false, null);
        }

        public void OnFaceTecSDKCompletelyDone()
        {
            if (success)
            {
                MessagingCenter.Send(new MessagesZoom.ScanningDoneMessage { ScanningCancelled = false }, MessagesZoom.ScanningDoneMessageId);
            }
            else
            {
                MessagingCenter.Send(new MessagesZoom.ScanningDoneMessage { ScanningCancelled = true }, MessagesZoom.ScanningDoneMessageId);
            }
        }

        public void ProcessSessionWhileFaceTecSDKWaits(FaceTecSessionResult sessionResult,
            FaceTecFaceScanResultCallback faceScanResultCallback)
        {
            if (sessionResult.Status != FaceTecSessionStatus.SessionCompletedSuccessfully)
            {
                faceScanResultCallback.OnFaceScanResultCancel();
                return;
            }

            try
            {
                var parameters = new JObject(
                                            new JProperty("faceScan", sessionResult.FaceScanBase64),
                                            new JProperty("auditTrailImage", sessionResult.GetAuditTrailCompressedBase64()[0]),
                                            new JProperty("lowQualityAuditTrailImage", sessionResult.GetLowQualityAuditTrailCompressedBase64()[0]));

                //subir aqui
                var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/json");
                var info_session = sessionResult.SessionId;
                var info_agent = $"facetec|sdk|ios|com.desarrollo.saulfacetec|{FacetecConsts.DeviceKeyIdentifier}|E4E6E227FB1CBFDA|iPhone SE|15.4.1|es_US|es|{info_session}";

                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Device-Key", FacetecConsts.DeviceKeyIdentifier);
                client.DefaultRequestHeaders.Add("X-User-Agent", info_agent);

                var response = client.PostAsync(FacetecConsts.BaseURL + "/liveness-3d", content).Result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    dynamic parsedResponse = JObject.Parse(result);

                    bool wasProcessed = parsedResponse.wasProcessed;
                    string scanResultBlob = parsedResponse.scanResultBlob;

                    if (wasProcessed)
                    {
                        FaceTecCustomization.OverrideResultScreenSuccessMessage = "Simon, estas vivo!";

                        success = faceScanResultCallback.OnFaceScanResultProceedToNextStep(scanResultBlob);
                    }
                    else
                    {
                        faceScanResultCallback.OnFaceScanResultCancel();
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                faceScanResultCallback.OnFaceScanResultCancel();
            }
        }

        public bool isSuccess()
        {
            return success;
        }
    }
}