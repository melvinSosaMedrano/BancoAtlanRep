using AtlanApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AtlanApi.Services
{
    public interface ICLIENTE_Service
    {
        Task<TBL_CLIENTE> GetCliente(int CODCLIENTE);
        Task<List<TBL_CLIENTE>> GetClientes(int CODCLIENTE);
    }
    public class CLIENTE_Service : ICLIENTE_Service
    {
        private readonly IConfiguration _configuration;

        public CLIENTE_Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<TBL_CLIENTE> GetCliente(int CODCLIENTE)
        {
            try
            {
                // Obtener la cadena de conexión desde appsettings.json
                string connectionString = _configuration.GetConnectionString("BDconnection");

                // Crear y abrir la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Crear un comando para ejecutar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("ObtenerClientePorCodigo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar el parámetro CODCLIENTE al comando
                        command.Parameters.AddWithValue("@pCODCLIENTE", CODCLIENTE);

                        // Ejecutar el comando y leer el resultado
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                // Aquí puedes leer los datos del cliente y crear un objeto TBL_CLIENTE
                                // Supongamos que TBL_CLIENTE tiene propiedades como ID, Nombre, etc.
                                TBL_CLIENTE cliente = new TBL_CLIENTE
                                {
                                    CODCLIENTE = Convert.ToInt32(reader["CODCLIENTE"]),
                                    CODAGENCIA = Convert.ToInt32(reader["CODAGENCIA"]),
                                    NOMBRECLIENTE = reader["NOMBRECLIENTE"].ToString(),
                                    // Así sucesivamente para otras propiedades
                                };

                                return cliente;
                            }
                        }
                    }
                }

                TBL_CLIENTE clienteNULL = new TBL_CLIENTE();
                // Si no se encuentra el cliente, devuelve null
                return clienteNULL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<TBL_CLIENTE>> GetClientes(int CODCLIENTE)
        {
            try
            {
                // Crear una lista para almacenar los clientes
                List<TBL_CLIENTE> clientes = new List<TBL_CLIENTE>();

                // Obtener la cadena de conexión desde appsettings.json
                string connectionString = _configuration.GetConnectionString("BDconnection");

                // Crear y abrir la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Crear un comando para ejecutar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("ObtenerClientePorCodigo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar el parámetro CODCLIENTE al comando
                        command.Parameters.AddWithValue("@pCODCLIENTE", CODCLIENTE);

                        // Ejecutar el comando y leer el resultado
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            // Iterar a través de todas las filas devueltas por el procedimiento almacenado
                            while (reader.Read())
                            {
                                // Crear un objeto cliente para cada fila y agregarlo a la lista
                                TBL_CLIENTE cliente = new TBL_CLIENTE
                                {
                                    CODCLIENTE = Convert.ToInt32(reader["CODCLIENTE"]),
                                    CODAGENCIA = Convert.ToInt32(reader["CODAGENCIA"]),
                                    NOMBRECLIENTE = reader["NOMBRECLIENTE"].ToString(),
                                    // Así sucesivamente para otras propiedades
                                };

                                clientes.Add(cliente);
                            }
                        }
                    }
                }

                // Devolver la lista de clientes
                return clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
