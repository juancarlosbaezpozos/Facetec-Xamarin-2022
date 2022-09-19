using SaulFacetec.Droid.Services;
using SaulFacetec.Services;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(ZoomScannerFactoryImplementation))]
namespace SaulFacetec.Droid.Services
{
    public sealed class ZoomScannerFactoryImplementation : IZoomFactory
    {
        public static IZoomScannerAndroidHostActivity AndroidHostActivity { get; set; }

        public IZoomSdk CreateZoomScanner()
        {
            if (AndroidHostActivity == null)
            {
                throw new NullReferenceException("Establecer AndroidHostActivity en el proyecto Droid.");
            }

            return new AndroidZoomPlatform(AndroidHostActivity);
        }
    }
}