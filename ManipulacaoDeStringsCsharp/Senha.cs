using System.Text.RegularExpressions;

namespace Q5
{
    public class Senha
    {
        public static bool Valida(string texto)
        {
            return Regex.IsMatch(
                texto,"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        }
    }
}
