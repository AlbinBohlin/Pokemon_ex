using System.Reflection;

namespace Ovning_3
{
    using Ovning_3.Pokemons;
    using Ovning_3.Pokemons.Abstract;
    using System.Reflection;

    public class Generate
    {
       

        static int i=0;
        public static Pokemon GenericPokemon()
        {
            
            var factories = new Func<Pokemon>[]
            {
                () => new Charmander($"Charmander_{i++}",1,new List<Attack>()),
                () => new Squirtle($"Squirtle_{i++}", 1, new List<Attack>()),
                () => new Pikachu($"Pikachu_{i++}",1,new List<Attack>()),
            };
            return factories[Random.Shared.Next(factories.Length)]();
        }
    }

}
