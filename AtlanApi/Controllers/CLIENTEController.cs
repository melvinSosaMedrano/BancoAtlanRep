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
    public class CLIENTEController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ICLIENTE_Service _clientes;

        public CLIENTEController(IConfiguration configuration, ICLIENTE_Service clientes)
        {
            _configuration = configuration;
            _clientes = clientes;
        }

        [HttpPost]
        [Route("Get")]
        public async Task<TBL_CLIENTE> Get(int codcliente)
        {
            try
            {
                return await _clientes.GetCliente(codcliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("Gets")]
        public async Task<List<TBL_CLIENTE>> Gets(int codcliente)
        {
            try
            {
                return await _clientes.GetClientes(codcliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
