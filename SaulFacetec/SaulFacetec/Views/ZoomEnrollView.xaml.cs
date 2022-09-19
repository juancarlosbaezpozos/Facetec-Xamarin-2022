using SaulFacetec.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaulFacetec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZoomEnrollView : ContentPage
    {
        public ZoomEnrollView()
        {
            InitializeComponent();

            this.BindingContext = new ZoomEnrollViewModel();
            _ = ((ZoomEnrollViewModel)BindingContext).InitializeAsync(true);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((ZoomEnrollViewModel)this.BindingContext)?.StartScannerCommand?.Execute(null);
        }
    }
}