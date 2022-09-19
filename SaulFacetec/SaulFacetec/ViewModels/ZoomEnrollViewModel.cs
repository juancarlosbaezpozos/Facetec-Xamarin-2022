using SaulFacetec.Services;
using SaulFacetec.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SaulFacetec.ViewModels
{
    public class ZoomEnrollViewModel : ViewModelBase
    {
        #region Interfaces
        private IZoomSdk _platform;
        #endregion

        #region Fields & Properties
        private bool EscanerListo { get; set; }
        #endregion

        #region Commands
        public ICommand StartScannerCommand { get; set; }
        #endregion

        #region Constructor
        public ZoomEnrollViewModel()
        {
            StartScannerCommand = new Command(StartScanner, EvalExecution());
        }
        #endregion

        public override async Task InitializeAsync(object navigationData)
        {
            IsBusy = true;

            IZoomFactory zoomFactory = DependencyService.Get<IZoomFactory>();
            if (zoomFactory != null)
            {
                _platform = zoomFactory.CreateZoomScanner();
                MessagingCenter.Subscribe<MessagesZoom.ScannerStatusMessage>(this, MessagesZoom.ScannerSetup, (sender) =>
                {
                    EscanerListo = sender.ScannerReady;
                });
            }

            IsBusy = false;
            await base.InitializeAsync(navigationData);
        }

        private void StartScanner()
        {
            if (_platform != null && StartScannerCommand.CanExecute(null))
            {
                _platform.Scan();
                MessagingCenter.Subscribe<MessagesZoom.ScanningDoneMessage>(this, MessagesZoom.ScanningDoneMessageId, (sender) =>
                {
                    string stringResult = "Sin resultados válidos.";
                    if (sender.ScanningCancelled)
                    {
                        stringResult = "Escaneo cancelado";
                    }
                    else
                    {
                        stringResult = "Escaneo valido";
                    }
                });
            }
        }

        private Func<bool> EvalExecution()
        {
            return new Func<bool>(() =>
            {
                return EscanerListo;
            });
        }

    }
}
