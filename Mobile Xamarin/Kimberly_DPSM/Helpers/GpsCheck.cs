using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Kimberly_DPSM.Helpers
{
    public class GpsCheck
    {
        public GpsCheck()
        {

        }
        public async Task<string> GpsActivate()
        {
            string resultado = "true";
            MainThread.BeginInvokeOnMainThread(async () =>
            {

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
            });
            return resultado;
        }
    }
}
