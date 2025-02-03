namespace Q4
{
    public class VerificaAnagrama
    {
        public static bool Verifica(string texto1, string texto2)
        {
            if (texto1.Length != texto2.Length)
            {
                return false;
            }
            else
            {
                int contagem = 0;
                foreach (char letraTexto1 in texto1.ToLower())
                {
                    foreach (char letraTexto2 in texto2.ToLower())
                    {
                        if (letraTexto1 == letraTexto2)
                        {
                            contagem++;
                        }
                    }
                }
                return contagem == texto1.Length;
            }
        }
    }
}
