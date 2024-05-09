using AtlanApi.Models;
using AtlanApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlanApi.Controllers
{
    [Route("[Controller]/api")]
    [ApiController]
    public class TARJETASController : ControllerBase
    {
      
        private readonly ITARJETAS_Service _TARJETAS;      

        public TARJETASController(ITARJETAS_Service TARJETAS) {
            _TARJETAS = TARJETAS;
        }

       
        [HttpPost]
        [Route("Gets")]
        public async Task<List<TBL_CNTTARJETA>> Gets(int CODCLIENTE)
        {
            try
            {
                return await _TARJETAS.GetTARJETAS(CODCLIENTE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("GetDetalle")]
        public async Task<List<TBL_CUENTASDET>> GetDetalle(int NUMCUENTA)
        {
            try
            {
                return await _TARJETAS.GetDetalle(NUMCUENTA);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("HisTransacciones")]
        public async Task<List<TBL_HISTRANSAC>> HisTransacciones(int NUMCUENTA)
        {
            
            try
            {
                return await _TARJETAS.HisTransacciones(NUMCUENTA);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("RealizarCompra")]
        public async Task<RESPUESTATRANSAC> RealizarCompra([FromBody]TRANSACCIONBD TRANSACCION)
        {
            try
            {
                return await _TARJETAS.RealizarCompra(TRANSACCION);
            }
            catch (Exception ex)
            {
                throw ex;
            }
       
        }
    }
}
