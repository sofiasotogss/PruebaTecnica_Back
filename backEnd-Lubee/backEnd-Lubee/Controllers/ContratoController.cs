using backEnd_Lubee.Data;
using backEnd_Lubee.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backEnd_Lubee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoController : ControllerBase
    {

        private readonly IContratoService _contratoService;

        public ContratoController(IContratoService contratoService)
        {
            _contratoService = contratoService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<string>>> ObtenerInformacionContratoDetalles(int id)
        {
            var resultado = await _contratoService.ObtenerInformacionContratoDetalles(id);

            if (resultado == null)
            {
                return NotFound($"Contrato con ID {id} no encontrado");
            }

            return Ok(resultado);
        }
    }
}
