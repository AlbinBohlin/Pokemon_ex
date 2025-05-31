namespace Ovning_3.Pokemons
{
    using Abstract;

    internal class Pikachu(string name, int level, List<Attack> attacks) : ElectricPokemon(name, level, attacks)
    {

        public void ThisMetodOnlyExistInPikachu() { Console.WriteLine("I am accessed from List<Pokemon>"); }

    }

}