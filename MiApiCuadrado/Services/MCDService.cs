namespace MiApiCuadrado.Services
{
    public class MCDService
    {
        public int CalcularMCD(int dividendo, int divisor)
        {
            while (true)
            {
                if (divisor == 0)
                {
                    return dividendo;
                }

                int residuo = dividendo % divisor;

                dividendo = divisor;
                divisor = residuo;
            }
        }
    }
}