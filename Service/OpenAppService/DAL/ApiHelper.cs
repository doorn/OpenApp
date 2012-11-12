using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DAL
{
     class ApiHelper
    {
        public string CallService(string baseUrl, string suffixUrl, string format) {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(format));
            HttpResponseMessage response = client.GetAsync(suffixUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ToString();
            }
            else {
                return response.StatusCode.ToString();
            }
        }
    }
}
