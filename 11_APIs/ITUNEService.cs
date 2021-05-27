using _11_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs
{
    public class ITUNESService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public async Task<SearchResult<Song>> GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://itunes.apple.com/search?term=s{query}&limit=10");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Song>>();
            }
            return null;
        }
    }
}
