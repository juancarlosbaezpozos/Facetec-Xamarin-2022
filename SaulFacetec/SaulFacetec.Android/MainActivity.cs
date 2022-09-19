
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using SaulFacetec.Droid.Services;
using SaulFacetec.Droid.Services.Processors;

namespace SaulFacetec.Droid
{
    [Activity(Label = "SaulFacetec", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IZoomScannerAndroidHostActivity
    {
        public AndroidZoomPlatform CurrentZoomImplementation;

        public Activity HostActivity => this;

        public int ScanZoomActivityRequestCode => 1002;

        public IProcessor latestProcessor;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ZoomScannerFactoryImplementation.AndroidHostActivity = this;

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Android.Content.Intent data)
        {
            if (latestProcessor == null)
            {
                return;
            }

            var realizado = latestProcessor.isSuccess();
            var resultado = realizado ? Result.Ok : Result.Canceled;
            if (requestCode == 1002)
            {
                CurrentZoomImplementation.OnActivityResult(requestCode, resultado, data);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void ScanningStarted(AndroidZoomPlatform implementation, string theToken)
        {
            CurrentZoomImplementation = implementation;

            //latestProcessor = new LivenessCheckProcessor(this, theToken);
            latestProcessor = new PhotoIDMatchProcessor(this, theToken);
        }
    }
}