using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PartidoLiberalWeb.Models;
using Newtonsoft.Json;
using RestSharp;

namespace PartidoLiberalWeb.Pages
{
    public class PersonaModel : PageModel
    {

        public List<Persona> Persona { get; set; }

        public Nullable<int> idCategoria { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Edad { get; set; }

        public void OnGet()
        {
            var client = new RestClient("https://localhost:44320/api/Personas");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            Persona = JsonConvert.DeserializeObject<List<Persona>>(response.Content);
            Persona.ToList();
        }
          
        

        public void OnPost(string Nombre, string Apellidos, string Telefono, int Edad, int idCategoria)
        {
            var client = new RestClient("https://localhost:44320/api/Personas");
            var request = new RestRequest(Method.POST);

            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");

            //agregamos parametros
            request.AddParameter("Nombre", Nombre);
            request.AddParameter("Apellidos", Apellidos);
            request.AddParameter("Telefono", Telefono);
            request.AddParameter("Edad", Edad);
            request.AddParameter("idCategoria", idCategoria);

            IRestResponse res = client.Post(request);

            OnGet();

        }


    

    }
}