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
    public class ReservationService
    {
        private HttpClient _client;
        public ReservationService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:58920/API/");
        }
        public IEnumerable<ReservationListItem> Get()
        {

            HttpResponseMessage response = _client.GetAsync("Reservation/").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<IEnumerable<ReservationListItem>>().Result;
        }
        public ReservationDetails Get(int id)
        {
            HttpResponseMessage response = _client.GetAsync($"Reservation/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<ReservationDetails>().Result;
        }

        public IEnumerable<ReservationListItem> GetByUser(int id)
        {
            HttpResponseMessage response = _client.GetAsync($"Reservation/User/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<IEnumerable<ReservationListItem>>().Result;
        }

        public void Delete(int id)
        {
            HttpResponseMessage response = _client.DeleteAsync($"Reservation/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la suppression de données.");
            }
            return;
        }
        public void Put(int id, ReservationDetails bodyContent)
        {
            string jsonContent = JsonConvert.SerializeObject(bodyContent);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PutAsync($"Reservation/{id}", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la mise à jour des données.");
            }
            return;
        }
        public int Post(int id, ReservationDetails bodyContent)
        {
            string jsonContent = JsonConvert.SerializeObject(bodyContent, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync($"Reservation/create/{id}", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données.");
            }
            return (int)response.Content.ReadAsAsync(typeof(int)).Result;
        }
        public void Insert(int id, ReservationDetails bodyContent)
        {
            string body = JsonConvert.SerializeObject(bodyContent);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:58920/API/");

            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = httpClient.PostAsync($"Reservation/", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données.");
            }
        }

    }
}