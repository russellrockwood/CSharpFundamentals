using _11_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync("https://swapi.dev/api/people/10").Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            Person person = response.Content.ReadAsAsync<Person>().Result;
            Console.WriteLine(person.Name);

            Console.WriteLine($"{person.Name} has {person.Eye_Color} eyes.");

            foreach (string vehicleUrl in person.Vehicles)
            {
                HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
                Console.WriteLine(vehicleResponse.Content.ReadAsStringAsync().Result);
                Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;
                Console.WriteLine(vehicle.Name);
            }

            SWAPIService swapiService = new SWAPIService();

            Person personTwo = swapiService.GetPersonAsync(5).Result;
            if (personTwo != null)
            {
                Console.WriteLine(personTwo.Name);
                foreach (string vehicleUrl in personTwo.Vehicles)
                {
                    Vehicle vehicle = swapiService.GetVehicleAsync(vehicleUrl).Result;
                    Console.WriteLine(vehicle.Name);
                }
            }

            Vehicle genericResponse = swapiService.GetTAsync<Vehicle>("https://swapi.dev/api/people/4").Result;
            if (genericResponse != null)
            {
                Console.WriteLine(genericResponse.Name);
            }
            else
            {
                Console.WriteLine("No vehicle exists here.");
            }

            SearchResult<Person> skywalkers = swapiService.GetPersonSearchAsync("Skywalker").Result; 
            Console.WriteLine(skywalkers.Count);
            foreach (Person personResult in skywalkers.Results)
            {
                Console.WriteLine(personResult.Name);
            }

            // ** not working properly
            SearchResult<Vehicle> starfighters = swapiService.GetVehicleSearchAsync("starfighter").Result;
            Console.WriteLine(starfighters.Count);
            foreach (Vehicle vehicleResults in starfighters.Results)
            {
                Console.WriteLine(vehicleResults.Name);
            }

            Console.ReadKey();
        }
    }
}
