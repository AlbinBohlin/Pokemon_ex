

namespace Ovning_3.Utils
{
    using Ovning_3.Pokemons;
    using Ovning_3.Pokemons.Abstract;
    using System.Reflection;

    public class Generate
    {
 

        public static int RandomInt(int upTo) {return Random.Shared.Next(upTo);}
        
        static int i = 0;
        public static Pokemon GenericPokemon()
        {
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);
            var shock = new Attack("shock", ElementType.Electric, 8);
            var lightning = new Attack("Lightning", ElementType.Electric, 13);
            var wave = new Attack("Wave", ElementType.Water, 34);
            var vortex = new Attack("Vortex", ElementType.Water, 6);
            

            var factories = new Func<Pokemon>[]
            {
                () => new Charmander($"Charmander_{i++}",1,[flamethrower,ember]),
                () => new Squirtle($"Squirtle_{i++}", 1, [wave,vortex]),
                () => new Pikachu($"Pikachu_{i++}",1,[shock, lightning]),
            };
            return factories[Random.Shared.Next(factories.Length)]();
        }
    }

}
