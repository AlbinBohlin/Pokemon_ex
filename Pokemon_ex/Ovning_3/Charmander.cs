namespace Ovning_3
{using Utils;
    internal class Charmander(string name, int level, List<Attack> attacks) : FirePokemon(name, level, attacks), IEvolvable
    {
        public void Evolve()
        {
            string new_name = "Charmeleon";
            Console.WriteLine(" is evolving... Now it's Raichu! Level 25!");
        }
    }
}