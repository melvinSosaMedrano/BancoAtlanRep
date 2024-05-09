using AtlanProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VistaAtlan.Models;

namespace AtlanProject.Services
{
    public interface ITARJETAS_Service
    {
        Task<List<TBL_CNTTARJETA>> GetTarjetas(int CODCLIENTE);
        Task<List<TBL_CUENTASDET>> GetTarjetasDet(int NUMCUENTA);
        Task<List<TBL_HISTRANSAC>> GetTransacciones(int NUMCUENTA);
        Task<RESPUESTATRANSAC> RealizarCompra(TRANSACCIONBD TRANSACCION);
    }
    public class TARJETAS_Service : ITARJETAS_Service
    {
        public async Task<List<TBL_CNTTARJETA>> GetTarjetas(int CODCLIENTE)
        {
            try
            {
                var api = ConfigurationManager.AppSettings["ApiAtlan"];
                // URL de la API destino
                string apiUrl = api+"TARJETAS/api/Gets?codcliente=" + CODCLIENTE;

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
                        List<TBL_CNTTARJETA> cliente = JsonConvert.DeserializeObject<List<TBL_CNTTARJETA>>(jsonResponse);

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
        public async Task<List<TBL_CUENTASDET>> GetTarjetasDet(int NUMCUENTA)
        {
            try
            {
                var api = ConfigurationManager.AppSettings["ApiAtlan"];
                // URL de la API destino
                string apiUrl = api+"TARJETAS/api/GetDetalle?numcuenta=" + NUMCUENTA;

                // Crear un objeto HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Configurar la solicitud HTTP POST con los datos necesarios
                    var postData = new System.Collections.Generic.Dictionary<string, string>
                {
                    { "NUMCUENTA", NUMCUENTA.ToString() }
                };

                    // Realizar la solicitud HTTP POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, new FormUrlEncodedContent(postData));

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta como una cadena JSON
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Deserializar la respuesta JSON al tipo TBL_CLIENTE
                        List<TBL_CUENTASDET> cliente = JsonConvert.DeserializeObject<List<TBL_CUENTASDET>>(jsonResponse);

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
        public async Task<List<TBL_HISTRANSAC>> GetTransacciones(int NUMCUENTA)
        {
            try
            {
                var api = ConfigurationManager.AppSettings["ApiAtlan"];
                // URL de la API destino
                string apiUrl = api+"TARJETAS/api/HisTransacciones?numcuenta=" + NUMCUENTA;

                // Crear un objeto HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Configurar la solicitud HTTP POST con los datos necesarios
                    var postData = new System.Collections.Generic.Dictionary<string, string>
                {
                    { "NUMCUENTA", NUMCUENTA.ToString() }
                };

                    // Realizar la solicitud HTTP POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, new FormUrlEncodedContent(postData));

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta como una cadena JSON
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Deserializar la respuesta JSON al tipo TBL_HISTRANSAC
                        List<TBL_HISTRANSAC> transacc = JsonConvert.DeserializeObject<List<TBL_HISTRANSAC>>(jsonResponse);

                        // Retornar el objeto cliente
                        return transacc;
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
        public async Task<RESPUESTATRANSAC> RealizarCompra(TRANSACCIONBD TRANSACCION)
        {
            try
            {
                var api = ConfigurationManager.AppSettings["ApiAtlan"];
                // URL de la API destino
                string apiUrl = api+"TARJETAS/api/RealizarCompra";

                // Crear un objeto HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Serializar el objeto TRANSACCION a JSON
                    string jsonData = JsonConvert.SerializeObject(TRANSACCION);

                    // Configurar la solicitud HTTP POST con los datos serializados
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Realizar la solicitud HTTP POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta como una cadena JSON
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Deserializar la respuesta JSON al tipo RESPUESTATRANSAC
                        RESPUESTATRANSAC transacc = JsonConvert.DeserializeObject<RESPUESTATRANSAC>(jsonResponse);

                        // Retornar el objeto cliente
                        return transacc;
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
