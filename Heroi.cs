namespace EscrevendoClassesJogo
{
    public class Heroi
    {
        public Heroi(string nome, int idade, TipoHeroi tipoHeroi)
        {
            Nome = nome;
            Idade = idade;
            TipoHeroi = tipoHeroi;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public TipoHeroi TipoHeroi { get; set; }

        public void Atacar()
        {
            string ataque = TipoHeroi switch
            {
                TipoHeroi.Guerreiro => "espada",
                TipoHeroi.Mago => "magia",
                TipoHeroi.Monge => "artes marciais",
                TipoHeroi.Ninja => "shuriken",
                _ => "ataque",
            };
            Console.WriteLine($"O {this.TipoHeroi} atacou usando {ataque}.\n");
        }
    }

    public enum TipoHeroi
    {
        Guerreiro = 1,
        Mago = 2,
        Monge = 3,
        Ninja = 4
    }
}