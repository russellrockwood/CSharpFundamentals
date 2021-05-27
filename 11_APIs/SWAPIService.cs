using _11_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs
{
    public class SWAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();
         
        public async Task<Person> GetPersonAsync(int id)
        {
            // Ask our api for a response, wait for it here
            HttpResponseMessage response = await _httpClient.GetAsync($"https://swapi.dev/api/people/{id}");

            if (response.IsSuccessStatusCode)
            {
                // Read the content of the response as a person object
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }
            return null;
        }

        public async Task<Vehicle> GetVehicleAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Vehicle>();
            }
            return null;
        }

        public async Task<T> GetTAsync<T>(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            return default;
        }

        public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/people/?search=" + query);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            }
            return null;
        }

        public async Task<SearchResult<T>> GetSearchAsync<T>(string catagory, string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://swapi.dev/api/people/?search={query}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }
            return null;
        }

        public async Task<SearchResult<Vehicle>> GetVehicleSearchAsync(string query)
        {
            return await GetSearchAsync<Vehicle>("vehicles", query);
        }
    } 


}
