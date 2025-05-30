namespace Ovning_3
{
    
    using Utils;
    internal class ElectricPokemon(List<Attack> attacks) : Pokemon( attacks, ElementType.Electric)
    {
        public override string Attack()
        {
            throw new NotImplementedException();
        }
    }
}