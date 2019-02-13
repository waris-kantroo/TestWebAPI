using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;

namespace TestWebAPI
{
    public class HttpClient
    {
        public async Task<HttpResponseMessage> GetHttpClient(string url)

        {
            HttpResponseMessage result = null;
            System.Net.Http.HttpClient Client = new System.Net.Http.HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50673/");
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            { 
             result = await Client.GetAsync(url).ConfigureAwait(false); // ConfigureAwait otherwise call never returns
            }
            catch(Exception ex)
            {

            }
            return result;

        }

        public  HttpResponseMessage GetHttpClientWithoutAsync( string url)
        {
            HttpResponseMessage result = null;
            System.Net.Http.HttpClient Client = new System.Net.Http.HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50673/");
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                result =  Client.GetAsync(url).Result;
            }
            catch (Exception ex)
            {

            }
            return result;

        }

        public String GetHttpClientWithoutAsync2(string url)
        {
            string result = "";
            System.Net.Http.HttpClient Client = new System.Net.Http.HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50673/");
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                result = Client.GetStringAsync(url).Result;
            }
            catch (Exception ex)
            {

            }
            return result;

        }

        public HttpResponseMessage PostHttpclient(string url, string body)
        {
  //          {
  //              "Id": 11,
  //"Name": "Waris Kantroo",
  //"Town": "Tral Naibasti"
  //          }

            HttpResponseMessage result = null;
            System.Net.Http.HttpClient Client = new System.Net.Http.HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50673/");
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
             HttpContent content = new StringContent(body, Encoding.UTF8,
                    "application/json");

            try
            {
                result = Client.PostAsync(url, content).Result;
            }
            catch (Exception ex)
            {

            }
            return result;

        }

        public HttpResponseMessage PostHttpclient2(string url, HttpContent content)
        {
            //          {
            //              "Id": 11,
            //"Name": "Waris Kantroo",
            //"Town": "Tral Naibasti"
            //          }

            HttpResponseMessage result = null;
            System.Net.Http.HttpClient Client = new System.Net.Http.HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50673/");
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                result = Client.PostAsync(url, content).Result;
            }
            catch (Exception ex)
            {
                HttpResponseMessage msg = new HttpResponseMessage();
                msg.Content = new StringContent(ex.Message);
                return msg;
            }
            return result;

        }


        public HttpResponseMessage GetYodleeHttpClient(string url)
        {
            HttpResponseMessage result = null;
            System.Net.Http.HttpClient Client = new System.Net.Http.HttpClient();
          //  Client.BaseAddress = new Uri("http://localhost:50673/");
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                result = Client.GetAsync(url).Result;
            }
            catch (Exception ex)
            {

            }
            return result;

        }

        public HttpResponseMessage PostYodleeHttpClient(string url,HttpContent body)
        {
            HttpResponseMessage result = null;
            System.Net.Http.HttpClient Client = new System.Net.Http.HttpClient();
            //  Client.BaseAddress = new Uri("http://localhost:50673/");
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Add("Api-Version", "1.1");
            Client.DefaultRequestHeaders.Add("Cobrand-Name", "restserver");
         
            try
            {
                result = Client.PostAsync(url,body).Result;
            }
            catch (Exception ex)
            {

            }
            return result;

        }



    }
}