namespace Q3
{
    public class VerificaExistenciaPalindromo
    {
        public static bool Verifica(string texto)
        {
            string textoInvertido = Q2.InverteString.Inverter(texto);
            return texto.ToLower() == textoInvertido.ToLower();
        }
    }
}
