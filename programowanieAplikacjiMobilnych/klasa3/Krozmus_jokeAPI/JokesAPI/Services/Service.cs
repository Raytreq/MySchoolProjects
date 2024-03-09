using JokesAPI.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace JokesAPI.Services
{
    public class Service : IService
    {
        private HttpClient client;

        public Service()
        {
            client = new HttpClient();
        }

        public async Task<List<JokeClass>> GetJokesAsync()
        {
            var responseModel = new List<JokeClass>();


            Uri uri = new Uri($"{Constant.Url}");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    responseModel = JsonConvert.DeserializeObject<List<JokeClass>>(content);
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return responseModel;
        }
    }
}
