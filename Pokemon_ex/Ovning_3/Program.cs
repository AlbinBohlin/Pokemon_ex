namespace Ovning_3
{
    using Ovning_3.Pokemons;
    using Utils;

    internal class Program
    {
        static void Main(string[] args)
        {
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);
            var shock = new Attack("shock", ElementType.Electric, 8);
            var lightning = new Attack("Lightning", ElementType.Electric, 13);
            var wave = new Attack("Wave", ElementType.Water, 34);
            var vortex = new Attack("Vortex", ElementType.Water,6);
            var o=new List<Attack>() { flamethrower,ember,shock};

            Charmander f = new Charmander( o) { Name ="#", Level = 1};
            var c = new Squirtle(o) { Name = "#", Level = 1 };
            Console.WriteLine(f.Name);
            f.Attack();



        }
    }
}
