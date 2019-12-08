using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace Kimberly_DPSM.ServicioRest
{
    public class ServiceSync<T>
    {
        public ServiceSync()
        {
        }

        public async Task<List<T>> GetAll(string url)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponse;
            HttpRequestMessage requestMessage = new HttpRequestMessage();

            requestMessage.Method = HttpMethod.Get;
            requestMessage.RequestUri = new Uri(url);
            requestMessage.Headers.Add("accept", "application/json");

            //httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            //httpClient.DefaultRequestHeaders.Add("bearer", token);

            httpResponse = await httpClient.SendAsync(requestMessage);

            if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<List<T>>(content);

                return json;
            }
            return default;
        }
        public async Task<T> GetbyId(string url, string id)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponse;
            HttpRequestMessage requestMessage = new HttpRequestMessage();

            requestMessage.Method = HttpMethod.Get;
            requestMessage.RequestUri = new Uri(url);
            requestMessage.Headers.Add("accept", "application/json");


            httpResponse = await httpClient.SendAsync(requestMessage);

            if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<T>(content);

                return json;
            }
            return default;
        }
        public async Task<bool> PostById(string uri, T objeto, string token = "")
        {

            var json = JsonConvert.SerializeObject(objeto);

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponse;
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("bearer", token);

            httpResponse = await httpClient.PostAsync(uri, content);

            if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }

    }
}
