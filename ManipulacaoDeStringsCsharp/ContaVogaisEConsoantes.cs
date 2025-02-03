namespace Q1
{
    public class ContaVogaisEConsoantes
    {
        public static string VerificaOcorrencias(string texto)
        {
            return $"\"{texto}\" - Vogais: {ContaVogais(texto)} " +
                $"| Consoantes: {ContaConsoantes(texto)}";
        }

        private static int ContaVogais(string texto)
        {
            int contagem = 0;
            foreach (char letra in texto.ToLower())
            {
                switch (letra)
                {
                    case 'a':
                        contagem++;
                        break;
                    case 'e':
                        contagem++;
                        break;
                    case 'i':
                        contagem++;
                        break;
                    case 'o':
                        contagem++;
                        break;
                    case 'u':
                        contagem++;
                        break;
                    default:
                        break;
                }
            }
            return contagem;
        }

        private static int ContaConsoantes(string texto)
        {
            int contagem = 0;
            char[] consoantes = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k',
                'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

            foreach (char letra in texto.ToLower())
            {
                foreach (char consoante in consoantes)
                {
                    if (letra == consoante)
                    {
                        contagem++;
                    }
                }
            }
            return contagem;
        }
    }
}
