// Verificar Vogais
namespace Aula02_1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("===== VERIFICADOR DE VOGAIS =====");
            Console.Write("Digite uma letra: ");

            string letra = Console.ReadLine()!.Trim().ToLower();

            switch (letra)
            {
                case "a":
                    Console.WriteLine("A letra A é uma vogal.");
                    break;

                case "e":
                    Console.WriteLine("A letra E é uma vogal.");
                    break;

                case "i":
                    Console.WriteLine("A letra I é uma vogal.");
                    break;

                case "o":
                    Console.WriteLine("A letra O é uma vogal.");
                    break;

                case "u":
                    Console.WriteLine("A letra U é uma vogal.");
                    break;

                default:
                    Console.WriteLine("A letra digitada não é uma vogal.");
                    break;
                    // Mais uma linha de código
            }
        }
    }
}