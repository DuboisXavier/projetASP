using Newtonsoft.Json;
using ProjetASP.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ProjetASP.MVC.Services
{
    public class HotelService
    {
        private HttpClient _client;
        public HotelService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:58920/API/");
        }
        public IEnumerable<HotelListItem> Get()
        {
            
            HttpResponseMessage response = _client.GetAsync("Hotel/").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<IEnumerable<HotelListItem>>().Result;
        }
        public HotelDetails Get(int id)
        {
            HttpResponseMessage response = _client.GetAsync($"Hotel/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<HotelDetails>().Result;
        }
        public void Delete(int id)
        {
            HttpResponseMessage response = _client.DeleteAsync($"Hotel/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la suppression de données.");
            }
            return;
        }

        public void Put(int id,HotelDetails bodyContent)
        {
            string jsonContent = JsonConvert.SerializeObject(bodyContent);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PutAsync($"Hotel/{id}", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la mise à jour des données.");
            }
            return;
        }
        public int Post(HotelDetails bodyContent)
        {
            string jsonContent = JsonConvert.SerializeObject(bodyContent, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync("Hotel/", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données.");
            }
            return (int)response.Content.ReadAsAsync(typeof(int)).Result;
        }
        public void Insert(HotelDetails bodyContent)
        {
            string body = JsonConvert.SerializeObject(bodyContent);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:58920/API/");

            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = httpClient.PostAsync("Hotel/", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données.");
            }
        }

    }
}