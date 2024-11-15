namespace EscrevendoClassesJogo
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Digite o nome do herói: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a idade do herói: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Digite o tipo do herói: \n" +
                    "1 - Guerreiro\n" +
                    "2 - Mago\n" +
                    "3 - Monge\n" +
                    "4 - Ninja\n");
                string enumHeroi = Console.ReadLine();
                Enum.TryParse<TipoHeroi>(enumHeroi, out var enumParsed);

                var heroi = new Heroi(nome, idade, enumParsed);
                heroi.Atacar();

                Console.WriteLine("Aperte qualquer botão para reiniciar o programa.");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}