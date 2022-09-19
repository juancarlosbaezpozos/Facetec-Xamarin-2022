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
    public class PhotoIDMatchProcessor : NSObject, IFaceTecFaceScanProcessorDelegate, IFaceTecIDScanProcessorDelegate, IProcessor
    {
        private bool success = false;
        private readonly UIViewController _fromViewController;

        private FaceTecFaceScanResultCallback _faceScanResultCallback;
        private FaceTecIDScanResultCallback _faceTecIDScanResultCallback;

        string _latestExternalDatabaseRefId = Guid.NewGuid().ToString();

        public PhotoIDMatchProcessor(string sessionToken, UIViewController fromViewController)
        {
            _fromViewController = fromViewController;

            FaceTecCustomization.SetIDScanUploadMessageOverridesForFrontSideUploadStarted(
            frontSideUploadStarted: "Uploading\nEncrypted\nID Scan", // Upload of ID front-side has started.
            frontSideStillUploading: "Still Uploading...\nSlow Connection", // Upload of ID front-side is still uploading to Server after an extended period of time.
            frontSideUploadCompleteAwaitingResponse: "Carga Completa", // Upload of ID front-side to the Server is complete.
            frontSideUploadCompleteAwaitingProcessing: "Procesando Anverso", // Upload of ID front-side is complete and we are waiting for the Server to finish processing and respond.
            backSideUploadStarted: "Uploading\nEncrypted\nBack of ID", // Upload of ID back-side has started.
            backSideStillUploading: "Still Uploading...\nSlow Connection", // Upload of ID back-side is still uploading to Server after an extended period of time.
            backSideUploadCompleteAwaitingResponse: "Carga Completa", // Upload of ID back-side to Server is complete.
            backSideUploadCompleteAwaitingProcessing: "Procesando Reverso", // Upload of ID back-side is complete and we are waiting for the Server to finish processing and respond.
            userConfirmedInfoUploadStarted: "Uploading\nYour Confirmed Info", // Upload of User Confirmed Info has started.
            userConfirmedInfoStillUploading: "Still Uploading...\nSlow Connection", // Upload of User Confirmed Info is still uploading to Server after an extended period of time.
            userConfirmedInfoUploadCompleteAwaitingResponse: "Carga Completa", // Upload of User Confirmed Info to the Server is complete.
            userConfirmedInfoUploadCompleteAwaitingProcessing: "Procesando", // Upload of User Confirmed Info is complete and we are waiting for the Server to finish processing and respond.
            nfcUploadStarted: "Uploading Encrypted\nNFC Details", // Upload of NFC Details has started.
            nfcStillUploading: "Still Uploading...\nSlow Connection", // Upload of NFC Details is still uploading to Server after an extended period of time.
            nfcUploadCompleteAwaitingResponse: "Carga Completa", // Upload of NFC Details to the Server is complete.
            nfcUploadCompleteAwaitingProcessing: "Processing\nNFC Details" // Upload of NFC Details is complete and we are waiting for the Server to finish processing and respond.
                );

            var newController = FaceTec.Sdk.CreateSessionVCWithFaceScanProcessor(faceScanProcessorDelegate: this, idScanProcessorDelegate: this, sessionToken);
            _fromViewController.PresentViewController(newController, true, null);
        }

        public void OnFaceTecSDKCompletelyDone()
        {
            if (success)
            {

            }
        }

        public void ProcessSessionWhileFaceTecSDKWaits(FaceTecSessionResult sessionResult, FaceTecFaceScanResultCallback faceScanResultCallback)
        {
            this._faceScanResultCallback = faceScanResultCallback;
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
                                            new JProperty("lowQualityAuditTrailImage", sessionResult.GetLowQualityAuditTrailCompressedBase64()[0]),
                                            new JProperty("externalDatabaseRefID", _latestExternalDatabaseRefId));

                //subir aqui
                var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/json");
                var info_session = sessionResult.SessionId;
                #region Workaround
                var info_agent = $"facetec|sdk|ios|com.desarrollo.saulfacetec|{FacetecConsts.DeviceKeyIdentifier}|E4E6E227FB1CBFDA|iPhone SE|15.4.1|es_US|es|{info_session}"; 
                #endregion

                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Device-Key", FacetecConsts.DeviceKeyIdentifier);
                client.DefaultRequestHeaders.Add("X-User-Agent", info_agent);

                var response = client.PostAsync(FacetecConsts.BaseURL + "/enrollment-3d", content).Result;
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

        //este metodo "processIDScanWhileFaceTecSDKWaits" pasa como "IdScanResultCallback"
        public void IdScanResultCallback(FaceTecIDScanResult idScanResult, FaceTecIDScanResultCallback idScanResultCallback)
        {
            this._faceTecIDScanResultCallback = idScanResultCallback;
            if (idScanResult.Status != FaceTecIDScanStatus.Success)
            {
                idScanResultCallback.OnIDScanResultCancel();
                return;
            }

            try
            {
                var minMatchLevel = 3;  //No puede ser 0

                var parameters = new JObject();
                parameters.Add(new JProperty("idScan", idScanResult.IdScanBase64));
                if (idScanResult.FrontImagesCompressedBase64?.Length > 0)
                {
                    parameters.Add(new JProperty("idScanFrontImage", idScanResult.FrontImagesCompressedBase64[0]));
                }
                if (idScanResult.BackImagesCompressedBase64?.Length > 0)
                {
                    parameters.Add(new JProperty("idScanBackImage", idScanResult.BackImagesCompressedBase64[0]));
                }
                parameters.Add(new JProperty("minMatchLevel", minMatchLevel));
                parameters.Add(new JProperty("externalDatabaseRefID", _latestExternalDatabaseRefId));

                var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/json");
                var info_session = idScanResult.SessionId;
                #region Workaround
                var info_agent = $"facetec|sdk|ios|com.desarrollo.saulfacetec|{FacetecConsts.DeviceKeyIdentifier}|E4E6E227FB1CBFDA|iPhone SE|15.4.1|es_US|es|{info_session}"; 
                #endregion

                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Device-Key", FacetecConsts.DeviceKeyIdentifier);
                client.DefaultRequestHeaders.Add("X-User-Agent", info_agent);

                var response = client.PostAsync(FacetecConsts.BaseURL + "/match-3d-2d-idscan", content).Result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    dynamic parsedResponse = JObject.Parse(result);

                    bool wasProcessed = parsedResponse.wasProcessed;
                    string scanResultBlob = parsedResponse.scanResultBlob;

                    if (wasProcessed)
                    {
                        FaceTecCustomization.SetIDScanResultScreenMessageOverridesForSuccessFrontSide(
                            successFrontSide: "Su cara coincide\ncon su Identificacion", // Successful scan of ID front-side (ID Types with no back-side).
                    successFrontSideBackNext: "Su cara coincide\ncon su Identificacion", // Successful scan of ID front-side (ID Types that do have a back-side).
                    successBackSide: "Back of ID Captured", // Successful scan of the ID back-side.
                    successUserConfirmation: "ID Verification\nComplete", // Successful upload of final IDScan containing User-Confirmed ID Text.
                    successNFC: "NFC Chip Info\nVerified", // Successful upload of the scanned NFC chip information.
                    retryFaceDidNotMatch: "Face Didn’t Match\nHighly Enough", // Case where a Retry is needed because the Face on the Photo ID did not Match the User's Face highly enough.
                    retryIDNotFullyVisible: "ID Document\nNot Fully Visible", // Case where a Retry is needed because a Full ID was not detected with high enough confidence.
                    retryOCRResultsNotGoodEnough: "ID Text Not Legible", // Case where a Retry is needed because the OCR did not produce good enough results and the User should Retry with a better capture.
                    retryIDTypeNotSupported: "ID Type Not Supported\nPlease Use a Different ID", // Case where there is likely no OCR Template installed for the document the User is attempting to scan.
                    skipOrErrorNFC: "NFC Scan Info\nUploaded" // Case where NFC Scan was skipped due to the user's interaction or an unexpected error.
                            );
                        success = idScanResultCallback.OnIDScanResultProceedToNextStep(scanResultBlob);
                    }
                    else
                    {
                        idScanResultCallback.OnIDScanResultCancel();
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                idScanResultCallback.OnIDScanResultCancel();
            }
        }

        public bool isSuccess()
        {
            return success;
        }


    }
}