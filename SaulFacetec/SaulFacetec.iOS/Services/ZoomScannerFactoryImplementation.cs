using SaulFacetec.iOS.Services;
using SaulFacetec.Services;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(ZoomScannerFactoryImplementation))]
namespace SaulFacetec.iOS.Services
{
    public sealed class ZoomScannerFactoryImplementation : IZoomFactory
    {
        public static IZoomScannerHostController IOSHostController { get; set; }

        public IZoomSdk CreateZoomScanner()
        {
            if (IOSHostController == null)
            {
                throw new NullReferenceException("Establecer IOSHostController en el proyecto iOS.");
            }

            return new iOSZoomPlatform(IOSHostController);
        }
    }
}