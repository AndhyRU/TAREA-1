using Microsoft.AspNetCore.Mvc;
using MiApiCuadrado.Services;

namespace MiApiCuadrado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCD_Controller : ControllerBase
    {
        private readonly MCDService _mcdService;

        public MCD_Controller(MCDService mcdService)
        {
            _mcdService = mcdService;
        }

        [HttpGet]
        public IActionResult CalcularMCD(int dividendo, int divisor)
        {
            int resultado = _mcdService.CalcularMCD(dividendo, divisor);

            return Ok(new
            {
                mcd = resultado
            });
        }
    }
}
