namespace Ovning_3
{
    using Ovning_3.Pokemons;
    using Ovning_3.Pokemons.Abstract;
    using Ovning_3.Utils;
    using System.Linq;
    using System.Text.RegularExpressions;

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
            var attacks=new List<Attack>() { flamethrower,ember,shock, lightning, wave, vortex};



            Pokemon f = new Charmander("Charry", 1, attacks);
            var c = new Squirtle("Squirty", 1, attacks);
            List<Pokemon> l = [f,c];

            for (int i = 0; i < 20; i++)
            {
                l.Add(Generate.GenericPokemon());
                
            }
            f.Name = "fs";
            foreach (var item in l)
            {
                Console.WriteLine(item.Name);
                item.Attacks.First().Use(item.Level);
                

            }
            Console.WriteLine(l.ToString());
            Console.WriteLine(f.Name);
            Console.WriteLine(c.GetType());
            f.Attack();
            
            
            //Reflections final question
            List<Pokemon> d = [new Pikachu("RelfectionTester", 11, new List<Attack>()), ];
            if (d[0] is Pikachu) ((Pikachu)d.First()).ThisMetodOnlyExistInPikachu();
         

           
           



        }
        
    }
}
