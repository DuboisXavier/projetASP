using Newtonsoft.Json;
using ProjetASP.MVC.Models;
using ProjetASP.MVC.Models.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;


namespace ProjetASP.MVC.Services
{
    public class UtilisateurService
    {
        private HttpClient _client;
        public UtilisateurService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:58920/API/");
        }
        public IEnumerable<UtilisateurListItem> Get()
        {

            HttpResponseMessage response = _client.GetAsync("Utilisateur/").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<IEnumerable<UtilisateurListItem>>().Result;
        }
        public UtilisateurDetails Get(int id)
        {
            HttpResponseMessage response = _client.GetAsync($"Utilisateur/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la réception de données.");
            }
            return response.Content.ReadAsAsync<UtilisateurDetails>().Result;
        }
        public void Delete(int id)
        {
            HttpResponseMessage response = _client.DeleteAsync($"Utilisateur/{id}").Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la suppression de données.");
            }
            return;
        }
        public void Put(int id, UtilisateurDetails bodyContent)
        {
            string jsonContent = JsonConvert.SerializeObject(bodyContent);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PutAsync($"Utilisateur/{id}", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la mise à jour des données.");
            }
            return;
        }
        public int Post(UtilisateurDetails bodyContent)
        {
            string jsonContent = JsonConvert.SerializeObject(bodyContent, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync("Utilisateur/", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données.");
            }
            return (int)response.Content.ReadAsAsync(typeof(int)).Result;
        }
        public void Insert(UtilisateurDetails bodyContent)
        {
            string body = JsonConvert.SerializeObject(bodyContent);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:58920/API/");

            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = httpClient.PostAsync("Utilisateur/", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de l'envois de données.");
            }
        }

        public UtilisateurDetails Login(string adresseMail, string motDePasse)
        {
            string jsonContent = JsonConvert.SerializeObject(new { AdresseMail = adresseMail, MotDePasse = motDePasse }, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync("Auth/Login", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la reception des données.");
            }
            return (UtilisateurDetails)response.Content.ReadAsAsync<UtilisateurDetails>().Result;
        }
        public UtilisateurDetails Register(RegisterForm RegisterForm)
        {
            string jsonContent = JsonConvert.SerializeObject(RegisterForm, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _client.PostAsync("Auth/Register", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Echec de la reception des données.");
            }
            return (UtilisateurDetails)response.Content.ReadAsAsync<UtilisateurDetails>().Result;
        }
    }
}