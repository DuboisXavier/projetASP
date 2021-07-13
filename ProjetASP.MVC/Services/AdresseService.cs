using Newtonsoft.Json;
using ProjetASP.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace ProjetASP.MVC.Services
{
    public class AdresseService
    {
        private HttpClient _client;
        public AdresseService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:58920/API/");
        }
        public IEnumerable<AdresseListItem> Get()
        {

            HttpResponseMessage response = _client.GetAsync("Adresse/").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<IEnumerable<AdresseListItem>>().Result;
        }
        public AdresseDetails Get(int id)
        {
            HttpResponseMessage response = _client.GetAsync($"Adresse/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<AdresseDetails>().Result;
        }
        public void Delete(int id)
        {
            HttpResponseMessage response = _client.DeleteAsync($"Adresse/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la suppression de données.");
            }
            return;
        }
        public void Insert(AdresseDetails bodyContent)
        {
            string body = JsonConvert.SerializeObject(bodyContent);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:58920/API/");

            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = httpClient.PostAsync("Adresse/", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données.");
            }
        }
        public void Put(int id, AdresseDetails bodyContent)
        {
            string jsonContent = JsonConvert.SerializeObject(bodyContent);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PutAsync($"Adresse/{id}", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la mise à jour des données.");
            }
            return;
        }

    }
}