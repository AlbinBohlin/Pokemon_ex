namespace Ovning_3.Pokemons.Abstract
{
    using Utils;
    /*Cannot create an Electric Pokemom, its a category, hence abstract.*/
    internal abstract class ElectricPokemon(List<Attack> attacks) : Pokemon( attacks, ElementType.Electric)
    {
        public override string Attack()
        {
            throw new NotImplementedException();
        }
    }
}