namespace Ovning_3.Pokemons
{
    using Ovning_3.Pokemons.Abstract;

    public class Charmander(string name, int level, List<Attack> attacks) : FirePokemon(name, level, attacks), IEvolvable
    {
        
           public string NewName { get; } = "Charmeleon";
        public void Evolve()
        {
            Evolve(NewName);

        }
        
        
    }
}