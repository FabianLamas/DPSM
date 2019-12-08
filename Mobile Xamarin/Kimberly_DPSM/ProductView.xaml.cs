using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kimberly_DPSM.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace Kimberly_DPSM
{
    public partial class ProductView : ContentPage
    {
        public ProductView()
        {
            InitializeComponent();
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged; ;
        }

        private void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            DisplayAlert("Alerta", "Conexion de internet perdida", "Aceptar");
        }


        private bool CheckConnection()
        {
            if (!CrossConnectivity.Current.IsConnected)
                return false;

            return true;

        }
        private async void actualizar_click(object sender, EventArgs e)
        {
            if (CheckConnection())
            {
                try
                {
                    MainThread.BeginInvokeOnMainThread(async () =>
                     {
                         string resultado = "";
                         try
                         {
                             var g = await Geolocation.GetLocationAsync();

                             if (g != null)
                                 resultado = "false";

                         }
                         catch (FeatureNotSupportedException fnsEx)
                         {
                             resultado = fnsEx.Message;
                         }
                         catch (FeatureNotEnabledException fneEx)
                         {
                             resultado = fneEx.Message;
                             // Handle not enabled on device exception
                         }
                         catch (PermissionException pEx)
                         {
                             resultado = pEx.Message;
                             // Handle permission exception
                         }
                         catch (Exception ex)
                         {
                             resultado = ex.Message;
                             // Unable to get location
                         }

                         if (resultado.Equals(true))
                         {
                             await DisplayAlert("GPS", resultado, "Aceptar");
                             return;
                         }
                     });

                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                }

            }

        }
    }
}
