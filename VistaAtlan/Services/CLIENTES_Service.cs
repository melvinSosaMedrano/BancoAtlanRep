using AtlanProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AtlanProject.Services
{
    public interface ICLIENTE_Service
    {
        Task<TBL_CLIENTE> GetCliente(int CODCLIENTE);
        Task<List<TBL_CLIENTE>> GetClientes();
    }
    public class CLIENTE_Service : ICLIENTE_Service
    {
       


        public async Task<TBL_CLIENTE> GetCliente(int CODCLIENTE)
        {
            try
            {
                var api = ConfigurationManager.AppSettings["ApiAtlan"];
                // URL de la API destino
                string apiUrl = api+"CLIENTE/api/Get?codcliente=" + CODCLIENTE;

                // Crear un objeto HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Configurar la solicitud HTTP POST con los datos necesarios
                    var postData = new System.Collections.Generic.Dictionary<string, string>
                    {
                        { "CODCLIENTE", CODCLIENTE.ToString() }
                    };

                    // Realizar la solicitud HTTP POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, new FormUrlEncodedContent(postData));

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta como una cadena JSON
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Deserializar la respuesta JSON al tipo TBL_CLIENTE
                        TBL_CLIENTE cliente = JsonConvert.DeserializeObject<TBL_CLIENTE>(jsonResponse);

                        // Retornar el objeto cliente
                        return cliente;
                    }
                    else
                    {
                        Console.WriteLine("La solicitud no fue exitosa. Código de estado: " + response.StatusCode);
                        // Si la solicitud no es exitosa, podrías manejarlo devolviendo null o lanzando una excepción, según lo que necesites.
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<TBL_CLIENTE>> GetClientes()
        {
            try
            {

                int CODCLIENTE = 0;
                var api = ConfigurationManager.AppSettings["ApiAtlan"];
                // URL de la API destino
                string apiUrl = api+"CLIENTE/api/Gets?codcliente=" + CODCLIENTE;

                // Crear un objeto HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Configurar la solicitud HTTP POST con los datos necesarios
                    var postData = new System.Collections.Generic.Dictionary<string, string>
                    {
                        { "CODCLIENTE", CODCLIENTE.ToString() }
                    };

                    // Realizar la solicitud HTTP POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, new FormUrlEncodedContent(postData));

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta como una cadena JSON
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Deserializar la respuesta JSON al tipo TBL_CLIENTE
                        List<TBL_CLIENTE> cliente = JsonConvert.DeserializeObject<List<TBL_CLIENTE>>(jsonResponse);

                        // Retornar el objeto cliente
                        return cliente;
                    }
                    else
                    {
                        Console.WriteLine("La solicitud no fue exitosa. Código de estado: " + response.StatusCode);
                        // Si la solicitud no es exitosa, podrías manejarlo devolviendo null o lanzando una excepción, según lo que necesites.
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
