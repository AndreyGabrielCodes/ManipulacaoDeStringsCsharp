using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoDeStringsCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            string textoQ1 = "Eu quero uma pizza";
            Console.WriteLine("Q1 - Conte o número de vogais e consoantes a partir " +
                $"de uma string\n   - Input: {textoQ1}");
            Console.WriteLine("   - Output: " + Q1.ContaVogaisEConsoantes.VerificaOcorrencias(textoQ1));

            //Q2
            Console.WriteLine("\nQ2 - Inverta a ordem dos caracteres de uma string" +
                $"de uma string\n   - Input: {textoQ1}");
            Console.WriteLine("   - Output: \"" + Q2.InverteString.Inverter(textoQ1) + "\"");

            //Q3
            string[] textosQ3 = { "Ovo", "Pizza", "Apos a sopa" };
            Console.WriteLine("\nQ3 - Determine se uma string é um palíndromo " +
                "(se ela é igual quando lida da direita para esquerda e vice-versa)" +
                $"\n   - Inputs: \"{textosQ3[0]}\", \"{textosQ3[1]}\", \"{textosQ3[2]}\" ");
            Console.WriteLine($"   - Outputs: " +
                $"{Q3.VerificaExistenciaPalindromo.Verifica(textosQ3[0])}, " +
                $"{Q3.VerificaExistenciaPalindromo.Verifica(textosQ3[1])}, " +
                $"{Q3.VerificaExistenciaPalindromo.Verifica(textosQ3[2])}");

            //Q4
            string[] textosQ4 = { "Perda", "Pedra" };
            Console.WriteLine("\nQ4 - Determine se duas strings são anagramas " +
                "(possuem os mesmos caracteres em ordens diferentes)" +
                $"\n   - Inputs: {textosQ4[0]} e {textosQ4[1]}");
            Console.WriteLine("   - Output: " +
                $"{Q4.VerificaAnagrama.Verifica(textosQ4[0], textosQ4[1])}");

            //Q5
            string senha = "Djkd1!mas";
            Console.WriteLine("\nQ5 - Valide se a senha inserida atende aos requisitos" +
                $"\n   - Input: {senha}");
            Console.WriteLine($"   - Output: {Q5.Senha.Valida(senha)}");

            //Pausa
            Console.ReadLine();
        }
    }
}
