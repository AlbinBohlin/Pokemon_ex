namespace Ovning_3.Pokemons.Abstract
{

    /*Cannot create an Electric Pokemom, its a category, hence abstract.*/
    public abstract class ElectricPokemon(string name, int level, List<Attack> attacks) : Pokemon(name, level, attacks, ElementType.Electric)
    {

    }
}