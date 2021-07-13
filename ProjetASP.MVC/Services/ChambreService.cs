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
    public class ChambreService
    {
        private HttpClient _client;
        public ChambreService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:58920/API/");
        }
        public IEnumerable<ChambreListItem> Get()
        {

            HttpResponseMessage response = _client.GetAsync("chambre/").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<IEnumerable<ChambreListItem>>().Result;
        }
        //[HttpGet]

        public IEnumerable<ChambreListItem> GetBy(int id)
        {

            HttpResponseMessage response = _client.GetAsync($"chambre/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<IEnumerable<ChambreListItem>>().Result;
        }
        public ChambreDetails Get(int id)
        {
            HttpResponseMessage response = _client.GetAsync($"Chambre/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<ChambreDetails>().Result;
        }

        public void Delete(int id)
        {
            HttpResponseMessage response = _client.DeleteAsync($"Chambre/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la suppression de données.");
            }
            return;
        }
        public void Insert(ChambreDetails bodyContent)
        {
            string body = JsonConvert.SerializeObject(bodyContent);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:58920/API/");

            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = httpClient.PostAsync($"Chambre/", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données.");
            }
        }
        public void Put(int id, ChambreDetails bodyContent)
        {
            string jsonContent = JsonConvert.SerializeObject(bodyContent);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PutAsync($"Chambre/{id}", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la mise à jour des données.");
            }
            return;
        }
    }
}