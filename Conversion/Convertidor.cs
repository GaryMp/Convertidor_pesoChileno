namespace ConversorDeMoneda1
{
    public static class Convertidor
    {
        private const double TasaDeCambio = 0.023;

        public static bool TryConvertir(string cantidad, out double resultado)
        {
            if (double.TryParse(cantidad, out var cantidadChilena))
            {
                resultado = cantidadChilena * TasaDeCambio;
                return true;
            }

            resultado = 0;
            return false;
        }
    }
}
