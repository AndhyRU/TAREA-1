using Microsoft .AspNetCore.Mvc;

namespace MiApiCuadrado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCD_Controller : ControllerBase
    {
        // GET: api/MCD/5/10
        [HttpGet("{a}/{b}")]
        public ActionResult<int> GetMCD(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                return BadRequest("Los números deben ser mayores que cero.");
            }

            int mcd = CalcularMCD(a, b);
            return Ok(mcd);
        }

        private int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
