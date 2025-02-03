using System.Text;

namespace Q2
{
    public class InverteString
    {
        public static string Inverter(string texto)
        {
            int tamanhoTexto = texto.Length - 1;
            StringBuilder sb = new StringBuilder();
            for (int i = tamanhoTexto; i >= 0; i--)
            {
                sb.Append(texto[i]);
            }
            return sb.ToString();
        }
    }
}
