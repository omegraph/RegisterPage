﻿using IntroToAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result;

            if (response.IsSuccessStatusCode)
            {
                //var content = response.Content.ReadAsStringAsync().Result;
                //var person = JsonConvert.DeserializeObject<Person>(content);

                Person luke = response.Content.ReadAsAsync<Person>().Result;
                Console.WriteLine(luke.Name);
                Console.WriteLine(luke.Mass);
                Console.WriteLine(luke.Gender);

                foreach(string vehicleUrl in luke.Vehicles)
                {
                    HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
                    //Console.WriteLine(vehicleResponse.Content.ReadAsStringAsync().Result);

                    Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;
                    Console.WriteLine(vehicle.Name);
                }
            }

            Console.WriteLine("----------------------");

            SWAPIService service = new SWAPIService();
            Person person = service.GetPersonAsync("https://swapi.dev/api/people/11").Result;
            if (person != null)
            {
                Console.WriteLine(person.Name);

                foreach(var vehicleUrl in person.Vehicles)
                {
                    var vehicle = service.GetVehicleAsync(vehicleUrl).Result;
                    Console.WriteLine(vehicle.Name);
                }
            }

            Console.WriteLine("----------------------");

            //var genericResponse = service.GetAsync<Vehicle>("https://swapi.dev/api/vehicles/4").Result;
            var genericResponse = service.GetAsync<Person>("https://swapi.dev/api/people/4").Result;
            if (genericResponse != null)
            {
                Console.WriteLine(genericResponse.Name);
            }
            else
            {
                Console.WriteLine("Targeted object does not exist.");
            }

            Console.WriteLine("----------------------");
            SearchResult<Person> skywalkers = service.GetPersonSearchAsync("skywalker").Result;
            foreach (Person p in skywalkers.Results)
            {
                Console.WriteLine(p.Name);
            }

            var genericSearch = service.GetSearchAsync<Vehicle>("speeder", "vehicles");
            var vehicleSearch = service.GetVehicleSearchAsync("speeder").Result;
        }
    }
}
