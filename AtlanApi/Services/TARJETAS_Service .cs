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
    public interface ITARJETAS_Service
    {
        Task<List<TBL_CNTTARJETA>> GetTARJETAS(int CODCLIENTE);
        Task<List<TBL_CUENTASDET>> GetDetalle(int NumCuenta);
        Task<List<TBL_HISTRANSAC>> HisTransacciones(int NumCuenta);
        Task<RESPUESTATRANSAC> RealizarCompra(TRANSACCIONBD TRANSACCION);
    }
    public class TARJETAS_Service : ITARJETAS_Service
    {
        private readonly IConfiguration _configuration;

        public TARJETAS_Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<TBL_CNTTARJETA>> GetTARJETAS(int CODCLIENTE)
        {
            try
            {
                // Crear una lista para almacenar los TARJETASs
                List<TBL_CNTTARJETA> TARJETASB = new List<TBL_CNTTARJETA>();

                // Obtener la cadena de conexión desde appsettings.json
                string connectionString = _configuration.GetConnectionString("BDconnection");

                // Crear y abrir la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Crear un comando para ejecutar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("ObtenerTARJETASPorCodigo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar el parámetro CODTARJETAS al comando
                        command.Parameters.AddWithValue("@pCODCLIENTE", CODCLIENTE);

                        // Ejecutar el comando y leer el resultado
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            // Iterar a través de todas las filas devueltas por el procedimiento almacenado
                            while (reader.Read())
                            {
                                // Crear un objeto TARJETAS para cada fila y agregarlo a la lista
                                TBL_CNTTARJETA TARJETAS = new TBL_CNTTARJETA
                                {
                                    CODAGENCIA = Convert.ToInt32(reader["CODAGENCIA"]),
                                    NUMTARJETA = Convert.ToInt32(reader["NUMTARJETA"]),
                                    NUMCUENTA = Convert.ToInt32(reader["NUMCUENTA"]),
                                    // Así sucesivamente para otras propiedades
                                };

                                TARJETASB.Add(TARJETAS);
                            }
                        }
                    }
                }

                // Devolver la lista de TARJETASs
                return TARJETASB;
            }
            catch (SqlException exsql)
            {
                throw exsql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<TBL_CUENTASDET>> GetDetalle(int NumCuenta)
        {
            try
            {
                // Crear una lista para almacenar los TARJETASs
                List<TBL_CUENTASDET> CUENTASDET = new List<TBL_CUENTASDET>();

                // Obtener la cadena de conexión desde appsettings.json
                string connectionString = _configuration.GetConnectionString("BDconnection");

                // Crear y abrir la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Crear un comando para ejecutar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("ObtenerCuentasTarjeta", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar el parámetro CODTARJETAS al comando
                        command.Parameters.AddWithValue("@pNUMCUENTA", NumCuenta);

                        // Ejecutar el comando y leer el resultado
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            // Iterar a través de todas las filas devueltas por el procedimiento almacenado
                            while (reader.Read())
                            {
                                // Crear un objeto TARJETAS para cada fila y agregarlo a la lista
                                TBL_CUENTASDET CUENTA = new TBL_CUENTASDET
                                {
                                    CODAGENCIA = reader["CODAGENCIA"] != DBNull.Value ? Convert.ToInt32(reader["CODAGENCIA"]) : default(int),
                                    INTERESCONFBONIF = reader["INTERESCONFBONIF"] != DBNull.Value ? Convert.ToDecimal(reader["INTERESCONFBONIF"]) : default(decimal),
                                    INTERESCONF = reader["INTERESCONF"] != DBNull.Value ? Convert.ToDecimal(reader["INTERESCONF"]) : default(decimal),
                                    INTERESCONFCUOMIN = reader["INTERESCONFCUOMIN"] != DBNull.Value ? Convert.ToDecimal(reader["INTERESCONFCUOMIN"]) : default(decimal),
                                    LIMITEMAXACTUAL = reader["LIMITEMAXACTUAL"] != DBNull.Value ? Convert.ToDecimal(reader["LIMITEMAXACTUAL"]) : default(decimal),
                                    PAGOMINIMO = reader["PAGOMINIMO"] != DBNull.Value ? Convert.ToDecimal(reader["PAGOMINIMO"]) : default(decimal),
                                    SALDOGLOBAL = reader["SALDOGLOBAL"] != DBNull.Value ? Convert.ToDecimal(reader["SALDOGLOBAL"]) : default(decimal),
                                    SALDOGLOBALDISPO = reader["SALDOGLOBALDISPO"] != DBNull.Value ? Convert.ToDecimal(reader["SALDOGLOBALDISPO"]) : default(decimal),
                                    NUMCUENTA = reader["NUMCUENTA"] != DBNull.Value ? Convert.ToInt32(reader["NUMCUENTA"]) : default(int)

                                };

                                CUENTASDET.Add(CUENTA);
                            }
                        }
                    }
                }

                // Devolver la lista de TARJETASs
                return CUENTASDET;
            }
            catch (SqlException exsql)
            {
                throw exsql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<TBL_HISTRANSAC>> HisTransacciones(int NumCuenta)
        {
            try
            {
                // Crear una lista para almacenar los TARJETASs
                List<TBL_HISTRANSAC> CUENTASDET = new List<TBL_HISTRANSAC>();

                // Obtener la cadena de conexión desde appsettings.json
                string connectionString = _configuration.GetConnectionString("BDconnection");

                // Crear y abrir la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Crear un comando para ejecutar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("ObtenerHistTransacciones", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar el parámetro CODTARJETAS al comando
                        command.Parameters.AddWithValue("@pNUMCUENTA", NumCuenta);

                        // Ejecutar el comando y leer el resultado
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            // Iterar a través de todas las filas devueltas por el procedimiento almacenado
                            while (reader.Read())
                            {
                                // Crear un objeto TARJETAS para cada fila y agregarlo a la lista
                                TBL_HISTRANSAC CUENTA = new TBL_HISTRANSAC
                                {
                                    CODAGENCIA = reader["CODAGENCIA"] != DBNull.Value ? Convert.ToInt32(reader["CODAGENCIA"]) : default(int),
                                    CREDDEB = reader["CREDDEB"] != DBNull.Value ? Convert.ToInt32(reader["CREDDEB"]) : default(int),
                                    DESCRIPCION = reader["DESCRIPCION"].ToString(),
                                    MONTO = reader["MONTO"] != DBNull.Value ? Convert.ToDecimal(reader["MONTO"]) : default(decimal),
                                    FECHATRANSAC = reader["FECHATRANSAC"] != DBNull.Value ? Convert.ToDateTime(reader["FECHATRANSAC"]) : default(DateTime),
                                    TRANSACNUM = reader["TRANSACNUM"] != DBNull.Value ? Convert.ToInt32(reader["TRANSACNUM"]) : default(int),
                                    NUMCUENTA = reader["NUMCUENTA"] != DBNull.Value ? Convert.ToInt32(reader["NUMCUENTA"]) : default(int)

                                };

                                CUENTASDET.Add(CUENTA);
                            }
                        }
                    }
                }

                // Devolver la lista de TARJETASs
                return CUENTASDET;
            }
            catch (SqlException exsql)
            {
                throw exsql;
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
                // Obtener la cadena de conexión desde appsettings.json
                string connectionString = _configuration.GetConnectionString("BDconnection");

                // Crear un objeto para almacenar la respuesta del procedimiento almacenado
                RESPUESTATRANSAC respuestaTransac = new RESPUESTATRANSAC();

                // Crear y abrir la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Crear un comando para ejecutar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("RealizarTransaccion", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros al comando
                        command.Parameters.AddWithValue("@pNUMTARJETA", TRANSACCION.NUMTARJETA);
                        command.Parameters.AddWithValue("@pMONTO", TRANSACCION.MONTO);
                        command.Parameters.AddWithValue("@pDESCRIPCION", TRANSACCION.DESCRIPCION);
                        command.Parameters.AddWithValue("@pFECHA", DateTime.Now);
                        command.Parameters.AddWithValue("@pTIPO", TRANSACCION.TIPO);

                        // Agregar parámetros de salida
                        SqlParameter outputCodigoParameter = new SqlParameter("@oCODIGO", SqlDbType.Int);
                        outputCodigoParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputCodigoParameter);

                        SqlParameter outputMensajeParameter = new SqlParameter("@oMENSAJE", SqlDbType.VarChar, 255);
                        outputMensajeParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputMensajeParameter);

                        // Ejecutar el comando y obtener la respuesta del procedimiento almacenado
                        await command.ExecuteNonQueryAsync();

                        // Leer los valores de retorno del procedimiento almacenado
                        respuestaTransac.codigo = Convert.ToInt32(command.Parameters["@oCODIGO"].Value);
                        respuestaTransac.mensaje = command.Parameters["@oMENSAJE"].Value.ToString();
                    }
                }

                // Devolver la respuesta del procedimiento almacenado
                return respuestaTransac;
            } 
            catch (SqlException exsql) {

                throw exsql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
            
        }

    }
}
