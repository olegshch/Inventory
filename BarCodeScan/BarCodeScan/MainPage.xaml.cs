using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace BarCodeScan
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Intialize the button
            Button btnScan = new Button
            {
                Text = "Start Scan",
                BackgroundColor = Color.FromRgb(207, 197, 159),
                TextColor = Color.White,
                BorderRadius = 5,
                TranslationY = 120
            };
            //Attach the click event
            btnScan.Clicked += btnScan_Clicked;

            this.Content = new StackLayout
            {
                BackgroundColor = Color.FromRgb(150, 172, 135),
                Spacing = 10,
                Padding = 25,
                Children =
            {
                btnScan
            }
            };
        }

        async void btnScan_Clicked(object sender, EventArgs e)
        {
            var scanPage = new ZXingScannerPage();
            // Navigate to our scanner page
            await Navigation.PushAsync(scanPage);

            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    await DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };
        }

        void HandleResult(ZXing.Result result)
        {
            var msg = "No Barcode!";
            if (result != null)
            {
                msg = "Barcode: " + result.Text + " (" + result.BarcodeFormat + ")";
            }

            DisplayAlert("", msg, "Ok");
        }
    }
}
